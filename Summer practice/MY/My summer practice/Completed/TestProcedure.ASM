FORMAT	MZ
ORG 100H

JMP Start


CALL WaitPressKey


; Закрытие программы
CloseProgram:

	MOV AH, 4CH
	INT 21H

	RET


; Чтение нажатия клавиши перед закрытием
WaitPressKey:

	MOV AH, 01H
	INT 21H

	RET


Start:

	CALL WaitPressKey
	CALL CloseProgram