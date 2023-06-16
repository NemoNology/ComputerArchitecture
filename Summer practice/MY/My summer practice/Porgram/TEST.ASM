FORMAT MZ
ORG 100H



;-----------------------------------------------
; START OF PROGRAM
;-----------------------------------------------


; Show result string, because next we need to show result
MOV     DX, results
MOV     AH, 09H
INT     21H

;-----------------------------------------------
;  CALCULATING (USING FPU)
;-----------------------------------------------

; L = SQRT((x2 - x1)^2 + (y2 - y1)^2)

MOV     SI, X
MOV     DI, Y

; CL is counter
MOV     CL, 0

MOV     AX, WORD 0


; Coordinates have to be in 2 arrays:
; 1) Array with x1..x10          Address of array beginning have to be in SI
; 2) Array with y1..y10          Address of array beginning have to be in DI
; Result will be in AX
FindLength:

        @Calculating:

                                        ;       |  |  |  |  |  |  |  |  |
                FILD    WORD [SI]       ;       |x1|  |  |  |  |  |  |  |
                ADD     SI, 2           ;       xn -> xn+1
                FILD    WORD [SI]       ;       |x2|x1|  |  |  |  |  |  |
                FSUB    ST0, ST1        ;       |a1|x1|  |  |  |  |  |  | a1 = x2 - x1
                FLD     ST0             ;       |a1|a1|x1|  |  |  |  |  |
                FMUL    ST0, ST1        ;       |a3|a1|x1|  |  |  |  |  | a2 = a1^2
                FILD    WORD [DI]       ;       |y1|a3|a1|x1|  |  |  |  |
                ADD     DI, 2           ;       yn -> yn+1
                FILD    WORD[DI]        ;       |y2|y1|a3|a1|x1|  |  |  |
                FSUB    ST0, ST1        ;       |a2|y1|a3|a1|x1|  |  |  | a3 = y2 - y1
                FLD     ST0             ;       |a2|a2|y1|a3|a1|x1|  |  |
                FMUL    ST0, ST1        ;       |a4|a2|y1|a3|a1|x1|  |  | a4 = a3^2
                FADD    ST0, ST3        ;       |a5|a2|y1|a3|a1|x1|  |  | a5 = a3 + a4
                FSQRT                   ;       |a6|a2|y1|a3|a1|x1|  |  | a6 = sqrt(a5)

                FISTP   [R]             ;       |a2|y1|a3|a1|x1|  |  |  |

                ADD     AX, WORD [R]

                FISTP   [R]             ;       |y1|a3|a1|x1|  |  |  |  |
                FISTP   [R]             ;       |a3|a1|x1|  |  |  |  |  |
                FISTP   [R]             ;       |a1|x1|  |  |  |  |  |  |
                FISTP   [R]             ;       |x1|  |  |  |  |  |  |  |
                FISTP   [R]             ;       |  |  |  |  |  |  |  |  |


                INC     CL

                CMP     CL, N
                JNE     @Calculating


;-----------------------------------------------
; INT TO STR
;-----------------------------------------------
             
MOV     BX, WORD 0
MOV     BL, 10

MOV     DX, WORD 0

PUSH    WORD '$'

; Resulting string will be in stack
@IntToStr:

        ; Result is in AX
        DIV     BL

        ; Now digit in AH/DX; Number without digit in AL/AX

        MOV     DH, AH
        ADD     DH, 30H
        MOV     DL, DH
        MOV     DH, 0

        PUSH    DX

        MOV     AH, 0

        CMP     AL, 0
        JNE     @IntToStr

        MOV     AH, 02H

        @ShowResult:

                POP     DX

                CMP     DX, WORD '$'
                JE      @HappyClose

                INT     21H
                JMP     @ShowResult


;-----------------------------------------------
; END OF PROGRAM
;-----------------------------------------------


@HappyClose:


        MOV     DX, ends
        MOV     AH, 09H
        INT     21H


@Close:


        ; Read a Enter before program closing
        MOV     DX, el
        MOV     AH, 0AH
        INT     21H

        ; Usual read a key before program closing
        ;MOV      AH, 01H
        ;INT      21H


        ; Closing console
        MOV      AH, 4CH
        INT      21H


;-----------------------------------------------
; VARIABLES
;-----------------------------------------------


; Number of angles
N = 6



;X DW N + 1 DUP(?)
;Y DW N + 1 DUP(?)

;X       DW 1, 1, 3, 3, 1
;Y       DW 1, 3, 3, 1, 1

; R - Use for saving result
; (Length of line segment)
R DW ?

IsY DB ?

; Array for tests; P =  52
X      DW  1, -1, -5, -5, -2,  1,  5, 7,  2, 2, 1
Y      DW  1,  3,  1, -4, -2, -7, -4, 6, 10, 3, 1

; Array 2 for tests; P =  12
;X       DW 1,  1,  1,  1,  1,  2,  3, 4,  4, 3, 1
;Y       DW 1,  2,  3,  4,  5,  5,  5, 4,  2, 1, 1


;-----------------------------------------------
; STRINGS
;-----------------------------------------------


ends    DB 0AH, 0AH, 'Program successfuly completed', 0AH, 'Press Enter to exit...' , '$'

results DB 0AH, 'Polygon perimeter =  ', '$'


el DB 1, 2 DUP(?)


;-----------------------------------------------
; SOME COMMENTS
;-----------------------------------------------

; 5 - Max size of input string (At practice - 4 is max size)
; DX have STRING address
; DX -> BX; First byte in STRING - STRING length
; Second byte - inputed string length;
; Trird - address of imputed string
; So I just put in our first byte - STRING length
; (7 - 2 = 5 (4, in fact, because fifth symbol is CR [0D in ASCII]))








