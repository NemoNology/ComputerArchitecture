; Закрытие программы с ожиданием
; нажатия любой кнопки перед этим
Close:
	; Ожидание нажатия кнопки
	MOV AH, 01H
	INT 21H

	; Закрытие консоли
	MOV AH, 4CH
	INT 21H

	RET


; Вывод строки посимвольно
; Адрес 1-ого символа должен находиться в регистре SI
PrintStrByChars:


	MOV	AH, 02H
	MOV	DX, 0
	MOV	DL, BYTE [SI]
	INT	21H

	INC	WORD SI

	CMP	BYTE [SI], '$'
	JNE	PrintStrByChars

	RET