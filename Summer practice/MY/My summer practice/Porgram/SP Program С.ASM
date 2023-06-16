FORMAT MZ
ORG 100H



;-----------------------------------------------
; START OF PROGRAM
;-----------------------------------------------

@Input:
        ; X coordinates
        MOV     SI, 0

        MOV     [IsY], 0

        MOV     DX, nachs1
        MOV     AH, 09H
        INT     21H

        MOV     BX, inputS

        CALL    @InputString

        ; Y coordinates
        MOV     SI, 0

        MOV     [IsY], 1

        MOV     DX, nachs2
        MOV     AH, 09H
        INT     21H

        MOV     BX, inputS
        INC     BYTE [BX]
        MOV     [BX + 1], BYTE 30H

        CALL    @InputString



JMP     @SPIncArr


;-----------------------------------------------
; INPUT STRING (PART 1)
;-----------------------------------------------


; STRING is buffer string for string input (With 0AH)
; N - numbers of angles
; SI, DI - counters

; SI - Counter (Count from 0 to N [10 angles])

@InputString:

        MOV     DX, BX
        MOV     AH, 09H
        INT     21H

        ; Input string
        MOV     DX, STRING
        MOV     AH, 0AH
        INT     21H

        MOV     DX, nl
        MOV     AH, 09H
        INT     21H


;-----------------------------------------------
;  STRING CHECK & STR TO INT
;-----------------------------------------------

        @CheckInputedString:

                ; Inputed string is in STRING + 2

                ; DI - Counter
                MOV     DI, 0
                PUSH    SI
                MOV     SI, 1

                @CheckFS:

                        ; Check first symbol
                        CMP     [STRING + 2], 2DH
                        JNE     @IsEmpty

                @IsSign:

                        INC     DI
                        MOV     SI, -1

                @IsEmpty:

                        CMP     [STRING + 2 + DI], 0DH
                        JE      @Error
                        CMP     [STRING + 2 + DI], 24H
                        JE      @Error

                @IsNumber:

                        ; Check the digits
                        CMP     [STRING + 2 + DI], '0'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '1'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '2'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '3'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '4'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '5'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '6'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '7'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '8'
                        JE      @Correct
                        CMP     [STRING + 2 + DI], '9'
                        JE      @Correct


                        ; Check if it was a last symbol - CR
                        CMP     [STRING + 2 + DI], 0DH
                        JE      @ReplaceCR
                        JNE     @Error


                @Correct:

                        ;-----------------------------------------------

                        ;  StrToInt:  '0' - 30h = H [ASCII]

                        PUSH    BX
                        MOV     BL, [STRING + 2 + DI]

                        SUB     BL, 30H
                        MOV     [STRING + 2 + DI], BL

                        POP     BX

                        ;-----------------------------------------------

                        ; Going to next symbol
                        INC     DI
                        JMP     @IsNumber


                @ReplaceCR:

                        MOV     [STRING + 2 + DI], 24H

                ;-----------------------------------------------
                ;  DIGITS TO NUMBER
                ;-----------------------------------------------

                @DigitsToNumber:

                        PUSH    BX
                        PUSH    AX

                        ; Constant multiplier
                        MOV     BX, 10

                        CMP     SI, -1
                        JE      @Sign

                        ; 10^n
                        MOV     AX, 1
                        MOV     BP, 3

                        JMP     @StartDTN

                        @Sign:

                                MOV     AX, -1
                                MOV     BP, 4

                        @StartDTN:
                        ; Here will be result number
                        MOV     CX, 0
                        MOV     DX, 0

                        ; Get a length
                        MOV     DL, [STRING + 1]
                        ; Add 2, because first 2 bytes - max L and current L
                        ADD     DL, 2

                        MOV     DI, DX
                        MOV     DX, 0

                        @L1:
                                MOV    DX, WORD [STRING + DI - 1]
                                MOV    DH, 0
                                MOV    [TEMP], AX
                                IMUL   DX, WORD [TEMP]

                                ; DX = Digit * 10^n
                                ; (n = from STRING lenght to BP)

                                ; Result = DX + Result
                                ADD     WORD CX, WORD DX

                                CMP     DI, BP
                                JE      @Save

                                DEC     DI
                                MUL     BX
                                JMP     @L1


                @Save:

                        MOV     [TEMP], CX

                        POP     AX
                        POP     BX
                        POP     SI

                        PUSH    BX

                        MOV     AX, [TEMP]
                        MOV     BX, SI
                        IMUL    BX, 2

                        CMP     [IsY], 0
                        JE      @SaveX

                @SaveY:

                        ; X[n]/Y[n] = 2 bytes. X[0] start in 1-st byte
                        ; X[1] start in 3-rd byte

                        MOV     [Y + BX], AX
                        JMP     @InputEnd

                @SaveX:

                        MOV     [X + BX], AX


;-----------------------------------------------
;  INPUT STRING (PART 2)
;-----------------------------------------------

@InputEnd:

        POP     BX

        ; Inc counters
        INC     WORD SI
        INC     WORD [BX + 1]

        CMP     SI, N
        JNE     @InputString

        RET



;-----------------------------------------------
;  ADD FIRST POINT COORDINATE TO ARRAYS END
;-----------------------------------------------

@SPIncArr:

        MOV     BX, N
        IMUL    BX, 2

        MOV     DI, X
        MOV     AX, [DI]
        MOV     WORD [X + BX], AX

        MOV     DI, Y
        MOV     AX, [DI]
        MOV     WORD [Y + BX],  AX

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
; And here will be console out from stack
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
; ERROR: WAS INPUTED NOT A NUMBER
;-----------------------------------------------


@Error:

        MOV     DX, error
        MOV     AH, 09H
        INT     21H

        JMP     @Close


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
N = 10


; Inputed string; Max length = [1-st byte] - 1
STRING  DB 5, ?, 5 DUP('$'), '$'

TEMP DW ?


X DW N + 1 DUP(?)
Y DW N + 1 DUP(?)

; R - Use for saving result
; (Length of line segment)
R DW ?

IsY DB ?

; Array for tests; P =  52
;ArrX DB 1, -1, -5, -5, -2,  1,  5, 7,  2, 2
;ArrY DB 1,  3,  1, -4, -2, -7, -4, 6, 10, 3

; Array 2 for tests; P =  12
;ArrX2 DB 1,  1,  1,  1,  1,  2,  3, 4,  4, 3
;ArrY2 DB 1,  2,  3,  4,  5,  5,  5, 4,  2, 1


;-----------------------------------------------
; STRINGS
;-----------------------------------------------

nachs1  DB 'Input x0..x', N + 47, ' (Use Enter)', 0AH, '[Input only integers!  Use only numerals and minus!]', 0AH, '$'
nachs2  DB 'Input y0..y', N + 47, ' (Use Enter)', 0AH, '[Input only integers!  Use only numerals and minus!]', 0AH, '$'

inputS  DB 'x0]  ', '$'

ends    DB 0AH, 0AH, 'Program successfuly completed', 0AH, 'Press Enter to exit...' , '$'

error   DB 0AH, 'ERROR: Was inputed not a integer/number or nothing!', 0AH, 'Program ended ahead of schedule', 0AH, 'Press Enter to exit...' , '$'

results DB 0AH, 'Polygon perimeter =  ', '$'


nl DB 0AH, '$'
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








