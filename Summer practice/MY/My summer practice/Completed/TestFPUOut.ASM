FORMAT	MZ
ORG 100H


FILD	[X]
FISTP	[R]

MOV	AX, WORD [R]


MOV AH, 01H
INT 21H

MOV AH, 4CH
INT 21H

; Q - ����������
; ��� ������� �����
Q DD ?

; ���������� ��� ���������� ����������
R DQ ?
X DW 4




