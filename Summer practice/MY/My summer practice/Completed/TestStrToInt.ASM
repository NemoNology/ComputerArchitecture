FORMAT MZ
ORG 100H

MOV     DX, DANO
MOV     AH, 09H
INT     21H

MOV     DX, STRING
INT     21H

MOV     DX, 0AH
MOV     AH, 02H
INT     21H


@StrToInt:

        MOV     BX, STRING

        ;@Loop:
        REPEAT 0

                SUB     [BX], WORD 48

                MOV     DX, [BX]
                MOV     AH, 02H
                INT     21H

                INC     WORD BX

        END REPEAT

        POP BX

        MOV     DX, 0AH
        INT     21H

        MOV     DX, NUM1
        INT     21H

        MOV     DX, NUM2
        INT     21H


MOV     AH, 01H
INT     21H

MOV     AH, 4CH
INT     21H



;-----------------------------------------------


; NUMBER OF STRINGS
N = 1


STRING DB '1234056789', '$'

NUMBERS DW N DUP(?)
NA = NUMBERS

DANO DB 'STRING:  ', '$'

NUM1 DB 30H
NUM2 DB 34H