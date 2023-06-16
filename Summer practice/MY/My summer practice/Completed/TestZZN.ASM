FORMAT MZ
ORG 100H

;------------------------------------------------

MOV     DI, ZZN1
MOV     SI, NUM1

MOV     DX, [SI]

SUB     [DI], DX


MOV     DX, [DI]
MOV     AH, 02H
INT     21H
MOV     DX, 0AH
INT     21H

;------------------------------------------------

MOV     DI, NUM2
MOV     SI, ZZN2

MOV     DX, [SI]

SUB     [DI], DX


MOV     DX, [DI]
MOV     AH, 02H
INT     21H
MOV     DX, 0AH
INT     21H

;------------------------------------------------

MOV     DI, ZZN1
MOV     SI, ZZN2

MOV     DX, [SI]

SUB     [DI], DX


MOV     DX, [DI]
MOV     AH, 02H
INT     21H
MOV     DX, 0AH
INT     21H

;------------------------------------------------

@Close:


        ; Read a key before program closing
        MOV      AH, 01H
        INT      21H



        ; Closing console
        MOV      AH, 4CH
        INT      21H


;------------------------------------------------

ZZN1 DB 0H, 0H, 0H, 7H
ZZN2 DB 0H, 5H

NUM1 DB 2H
NUM2 DB 9H