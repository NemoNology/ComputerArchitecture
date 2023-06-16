FORMAT MZ
ORG 100H





MOV     BX, [NUM1]
DEC     BX

MOV     BX, [NUM2]
DEC     BX

MOV     DX, 50
MOV     AH, 02H
INT     21H

@Close:


        MOV     AH, 01H
        INT     21H

        MOV     AH, 4CH
        INT     21H






NUM1 DW 10
NUM2 DW 10H