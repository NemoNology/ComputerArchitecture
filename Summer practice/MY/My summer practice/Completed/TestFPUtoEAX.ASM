FORMAT	MZ
ORG 100H

MOV EAX, 0


FLDPI

FISTP	DWORD [Per]

MOV	EAX, [Per]




mov ebx, 25

; „тение нажати€ перед закрытием
MOV AH, 01H
INT 21H



; «акрытие консоли
MOV AH, 4CH
INT 21H



Per DD 9922

; q - переменна€
; дл€ очистки стека
q DQ ?





