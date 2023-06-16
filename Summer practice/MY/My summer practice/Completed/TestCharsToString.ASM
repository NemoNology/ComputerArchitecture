FORMAT MZ
ORG     100H



MOV     DI, STRING
MOV     BP, CHARS1

CALL    @LOOP

MOV     DI, STRING
MOV     BP, CHARS2

CALL    @LOOP



JMP     @CLOSE


@LOOP:

        MOV     AL, BYTE [BP]
        MOV     BYTE [DI], AL

        INC     BP
        INC     DI

        CMP     BYTE [BP], '$'
        JNE     @LOOP

        RET

@CLOSE:
; Read a Enter before program closing
MOV     DX, EMPSTR
MOV     AH, 0AH
INT     21H

; Closing console
MOV AH, 4CH
INT 21H


STRING DQ ?


CHARS1 DB 'Hello!', '$'
CHARS2 DB '-', 02H, 07H, 07H, '$$'

NL DB 0AH, '$'

EMPSTR DB 1, 2 DUP(?)