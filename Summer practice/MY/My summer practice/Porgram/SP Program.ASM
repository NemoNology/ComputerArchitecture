FORMAT MZ
ORG 100H



;-----------------------------------------------
; START OF PROGRAM - PREDISLOVIE 1
;-----------------------------------------------


@Predislovie1:

        MOV     DX, nachs1
        MOV     AH, 09H
        INT     21H


;-----------------------------------------------
; INPUT STRING (PART 1)
;-----------------------------------------------

; STRING is buffer string for string input (With 0AH)
; N - numbers of angles
; SI, DI - counters

; Counter (Count from 0 to N [10 angles])
; If SP = 00H --> We are saving X coordinated; SP != 00H --> Y coordinates
MOV     SI, 7
MOV     BX, input1
MOV     BP, 00H


CALL    @InputString

JMP     @HappyClose


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
;  StrToInt & Check
;-----------------------------------------------

        @CheckInputedString:

                ; Inputed string is in STRING + 2

                ; DI - Counter
                MOV     DI, 0

                @CheckFS:

                        ; Check first symbol
                        CALL    @IsEmpty
                        CMP     [STRING + 2], 2DH
                        JNE     @IsNumber

                        ; Inc DI -> program will check number starting from the second symbol
                        INC     DI
                        MOV     AL, 01H
                        CALL    @IsEmpty
                        JMP     @IsNumber

                @IsEmpty:

                        CMP     [STRING + 2 + DI], 0DH
                        JE      @Error
                        CMP     [STRING + 2 + DI], 24H
                        JE      @Error

                        RET

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


                        ; Check if it was a last symbol or CR
                        CMP     [STRING + 2 + DI], 0DH
                        JE      @ReplaceCR
                        JNE     @Error


                @Correct: ; (And StrToIntDec)

                        ;----------------------------------------------------------|
                        ; StrToInt: '0' = 30H; '1' = 31H [ASCII] -> ('n' - 30H = n)|
                        ;SUB     [STRING + 2 + DI], 30H                            ;|
                        ;----------------------------------------------------------|

                        ; Going to next symbol
                        INC     DI
                        JMP     @IsNumber


                @ReplaceCR:

                        MOV     [STRING + 2 + DI], 24H
                        MOV     DI, 0


                ;-----------------------------------------------
                ;  CORRECT STRING
                ;-----------------------------------------------

                @CorrectingSTRING:

                        MOV     BP, CSTRING
                        PUSH    BX

                        CMP     AL, 01H
                        JE      @SignTrue
                        JNE     @ClearZ


                        @SignTrue:

                                MOV     [BP], BYTE 2DH
                                INC     DI
                                INC     BP

                                JMP     @ClearZ

                        @ClearZ:

                                MOV     BX, WORD [STRING + 2 + DI]
                                CMP     [BX], BYTE 00H
                                JE      @GTNS

                                CMP     [BX], BYTE 24H
                                JE      @GTPS
                                JNE     @Save


                        ; Saving X coordinate (string) in AX (Using PUSH)
                        ; Y coordinates wiil be in CX
                        ;-----------------------------------------------
                        ;  SAVING STRING IN REGISTR
                        ;-----------------------------------------------
                        @Save:

                                @EoCS:

                                        MOV     BX, WORD [STRING + 2 + DI]
                                        MOV     [BP], BX
                                        INC     BP


                                POP BX

                                CMP     SP, 00H
                                JE      @SaveX
                                JNE     @SaveY

                        @GTNS:

                                INC     DI
                                JMP     @ClearZ

                        @GTPS:

                                DEC     DI
                                JMP     @Save


                        @SaveX:

                                MOV     AX, WORD [STRING + 2 + DI]

                                JMP     @ContinueInput

                        @SaveY:




                                JMP     @ContinueInput






@ContinueInput:


;-----------------------------------------------
;  INPUT STRING (PART 2)
;-----------------------------------------------

        ; Inc counters
        INC     WORD SI
        INC     BYTE [BX + 1]

        CMP     SI, N
        JNE     @InputString

        MOV     SP, 01H

        RET


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


; Inputed string (temp); Max length = 4 symbols
STRING DB 5, ?, 5 DUP('$'), '$'

; Corrected string (temp); Max length = STRING max length
CSTRING DB 5 DUP('$'), '$'

; Arrays for inputed data
X DB 60 DUP(?)
Y DB 60 DUP(?)


; Array for tests; P =  52
;ArrX DB 1, -1, -5, -5, -2,  1,  5, 7,  2, 2
;ArrY DB 1,  3,  1, -4, -2, -7, -4, 6, 10, 3

; Array 2 for tests; P =  12
;ArrX2 DB 1,  1,  1,  1,  1,  2,  3, 4,  4, 3
;ArrY2 DB 1,  2,  3,  4,  5,  5,  5, 4,  2, 1


;-----------------------------------------------
; STRINGS
;-----------------------------------------------

nachs1 DB 'Input x1..x10 (Use Enter)', 0AH, '[Input only integers!  Use only numerals and minus!]', 0AH, '$'
nachs2 DB 'Input y1..y10 [Use Enter]', 0AH, '[Input only integers!  Use only numerals and minus!]', 0AH, '$'

input1 DB 'x0]  $'

ends DB 0AH, 'Program successfuly completed', 0AH, 'Press Enter to exit...' , '$'

error DB 0AH, 'ERROR: Was inputed not a integer/number or nothing!', 0AH, 'Program ended ahead of schedule', 0AH, 'Press Enter to exit...' , '$'

;label1 DB 0AH, 'label1', 0AH, '$'


le DB '$'
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








