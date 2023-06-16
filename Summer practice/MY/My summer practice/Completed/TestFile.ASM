FORMAT MZ
ORG 100H


MOV     DX, FilePath

CALL    @FileCreate


MOV     BX, [FDcp]
MOV     CX, 9
MOV     DX, InputS1

CALL    @FileWrite


MOV     DX, InputS2
CALL    @FileWrite


CALL    @FileClose


MOV     AH, 01H
INT     21H

MOV     AH, 4CH
INT     21H



; In DX have to be path to new file and 00H at the end
; [Path DB 'File.txt', 00H]
@FileCreate:

        MOV     AH, 3CH
        MOV     CX, 00H
        INT     21H

        MOV     [FDcp], AX

        RET



; In BX have to be file descriptor
; In CX - number of bytes that will be inputed
; In DX - string/data that will be inputed
@FileWrite:

        MOV     AH, 40H
        INT     21H

        RET



; In BX have to be file descriptor
@FileClose:

        MOV     AH, 3EH
        INT     21H

        RET




FilePath DB 'File.txt', 00H

FDcp DW ?
InputS1 DB 'Hello!$'
InputS2 DB 0AH, 'WORK?'