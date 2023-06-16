FORMAT MZ
ORG 100H


MOV     BX, [NUM1]
MOV     AX, [NUM2]

; 150H ; 336
MUL    BX

MOV     DX, AX
MOV     AH, 02H
INT     21H



@Close:

        ; Read a key before program closing
        MOV     AH, 01H
        INT     21H



        ; Closing console
        MOV     AH, 4CH
        INT     21H



NUM1    DW 30H
NUM2    DW 7