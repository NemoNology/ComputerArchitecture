FORMAT	MZ
ORG 100H

JMP Start


CALL WaitPressKey


; �������� ���������
CloseProgram:

	MOV AH, 4CH
	INT 21H

	RET


; ������ ������� ������� ����� ���������
WaitPressKey:

	MOV AH, 01H
	INT 21H

	RET


Start:

	CALL WaitPressKey
	CALL CloseProgram