FORMAT MZ
ORG 0100


JMP	@Close









;-----------------------------------------------
; End of program
;-----------------------------------------------
@Close:

	MOV	SI, str1
	CALL	PrintStr

	; Read a key before program closing
	MOV	AH, 01H
	INT	21H



	; Closing console
	MOV	AH, 4CH
	INT	21H







;-----------------------------------------------
; Procedures
;-----------------------------------------------


; Output string in console
; String adress have to be in SI
PrintStr:

	MOV	AH, 09H
	MOV	DX, SI
	INT	21H

	RET




; Output string in console by chars
; String adress have to be in SI
PrintStrByChars:


	MOV	AH, 02H
	MOV	DX, 0
	MOV	DL, BYTE [SI]
	INT	21H

	INC	WORD SI

	CMP	BYTE [SI], '$'
	JNE	PrintStrByChars

	RET




;-----------------------------------------------
; Variables
;-----------------------------------------------


str1 DB 'Hello!$'
