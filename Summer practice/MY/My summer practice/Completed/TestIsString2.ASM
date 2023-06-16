FORMAT MZ
ORG 100H


                ; DI - Counter
                MOV     DI, 0

                @IsSign:

                        ; Sign check
                        CMP     [String + 2], 2DH
                        JE      @IsSignTrue
                        JNE     @IsNumber

                @IsSignTrue:

                        ; Inc DI -> program will check number starting from the second symbol
                        INC     DI

                @IsNumber:

                        CMP     [String + 2 + DI], '0'
                        JE      @Correct
                        CMP     [String + 2 + DI], '1'
                        JE      @Correct
                        CMP     [String + 2 + DI], '2'
                        JE      @Correct
                        CMP     [String + 2 + DI], '3'
                        JE      @Correct
                        CMP     [String + 2 + DI], '4'
                        JE      @Correct
                        CMP     [String + 2 + DI], '5'
                        JE      @Correct
                        CMP     [String + 2 + DI], '6'
                        JE      @Correct
                        CMP     [String + 2 + DI], '7'
                        JE      @Correct
                        CMP     [String + 2 + DI], '8'
                        JE      @Correct
                        CMP     [String + 2 + DI], '9'
                        JE      @Correct

                        JMP     @Error


                @Correct:

                        ; Going to next symbol
                        INC     DI

                        ; Check if it was a last symbol
                        CMP     [String + 2 + DI], '$'
                        JNE     @IsNumber



                JMP     @HappyClose


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


        MOV     AH, 01H
        INT     21H


        MOV     AH, 4CH
        INT     21H


;-----------------------------------------------
; VARIABLES
;-----------------------------------------------


String  DB 05H, 02H,  '56', '$'




ends DB 0AH, 'Program completed', 0AH, 'Press any key to exit...' , '$'

error DB 0AH, 'Error: Was inputed not a integer/number/nothing!$', 0AH, 'Program ended ahead of schedule', 0AH, 'Press any key to exit...' , '$'










