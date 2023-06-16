FORMAT  MZ
ORG 100H



; Calculating length of line segment
; by coordinates of his point

; L = SQRT((x2 - x1)^2 + (y2 - y1)^2)

MOV     SI, WORD X
MOV     DI, WORD Y

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
               
           



; Read a key before program closing
MOV AH, 01H
INT 21H



; Closing console
MOV AH, 4CH
INT 21H



; Array for tests; P =  52
;X DW 1, -1, -5, -5, -2,  1,  5, 7,  2, 2, 1
;Y DW 1,  3,  1, -4, -2, -7, -4, 6, 10, 3, 1

X DW 1,  1,  1,  1,  1,  2,  3, 4,  4, 3, 1
Y DW 1,  2,  3,  4,  5,  5,  5, 4,  2, 1, 1


; Number of angles
N = 10


; R - Use for saving result
; (Length of line segment)
R DW ?




