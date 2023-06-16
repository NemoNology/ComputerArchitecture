FORMAT MZ
ORG    100H


MOV     BX, 30
MOV     AX, 1H

MUL     BX

MOV     [R], AX

FILD    DWORD [R]

FIST    [R]

MOV     DX, AX
MOV     AH, 02H
INT     21H




; Usual read a key before program closing
MOV     AH, 01H
INT     21H


; Closing console
MOV     AH, 4CH
INT     21H




R       DW ?