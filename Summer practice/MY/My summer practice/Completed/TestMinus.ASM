FORMAT MZ
ORG 100H




MOV     BX, NUM1
MOV     DI, NUM2
MOV     SI, [DI]


ADD     [BX], SI




@Close:


        ; Read a Enter before program closing
        ;MOV     DX, el
        ;MOV     AH, 0AH
        ;INT     21H

        ; Usual read a key before program closing
        MOV      AH, 01H
        INT      21H



        ; Closing console
        MOV      AH, 4CH
        INT      21H




NUM1 DB -27
NUM2 DB 0005