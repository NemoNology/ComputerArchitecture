FORMAT MZ
ORG 100H




@InputString:

        ; Input string
        MOV     DX, STRING
        MOV     AH, 0AH
        INT     21H

        MOV     DX, nl
        MOV     AH, 09H
        INT     21H


MOV     DX, WORD [STRING + 1]
MOV     AH, 02H
INT     21H


MOV     AH, 01H
INT     21H

MOV     AH, 4CH
INT     21H





STRING  DB 5, ?, 5 DUP(?), '$'

nl      DB 0AH, '$'