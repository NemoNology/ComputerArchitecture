FORMAT MZ
ORG 100H


MOV     BX, [NUM1]
MOV     AX, [NUM2]

MUL     BX

MOV     [R], AX


@Close:


        MOV     AH, 01H
        INT     21H

        MOV     AH, 4CH
        INT     21H



NUM1    DW 244
NUM2    DW 19

; EDE4 (-)
; 121C (+)
R       DW ?