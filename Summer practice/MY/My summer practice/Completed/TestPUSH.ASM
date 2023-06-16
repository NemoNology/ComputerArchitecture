FORMAT MZ
ORG 100H



MOV     SI, 0

@LOOP1:

        MOV     BX, STRING
        PUSH    BX
        MOV     BX, 30H
        PUSH    BX


        INC     SI
        CMP     SI, 40
        JNE     @LOOP1


MOV     SI, 0
MOV     AH, 02H

@LOOP2:

        MOV     DX, BX
        POP     BX
        INT     21H

        MOV     DX, 0AH
        INT     21H

        INC     SI
        CMP     SI, 40
        JNE     @LOOP2



MOV     AH, 01H
INT     21H

MOV     AH, 4CH
INT     21H



STRING  DB 'Hello!', 0AH, '$'