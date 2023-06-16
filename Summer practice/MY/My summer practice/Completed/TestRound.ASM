FORMAT	MZ
ORG 100H



FLD	[X2]
FLD	[X1]
FDIV	ST0, ST1
FLDPI
FDIV	ST0, ST1
FIST	[R]

MOV	BX, WORD [R]

FRNDINT
FISTP	[R]

MOV	AX, WORD [R]



; Чтение нажатия перед закрытием
MOV AH, 01H
INT 21H

; Закрытие консоли
MOV AH, 4CH
INT 21H

Q DD ?


R DD ?

X1 DD 5
X2 DD 4