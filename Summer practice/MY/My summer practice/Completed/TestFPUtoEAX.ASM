FORMAT	MZ
ORG 100H

MOV EAX, 0


FLDPI

FISTP	DWORD [Per]

MOV	EAX, [Per]




mov ebx, 25

; ������ ������� ����� ���������
MOV AH, 01H
INT 21H



; �������� �������
MOV AH, 4CH
INT 21H



Per DD 9922

; q - ����������
; ��� ������� �����
q DQ ?





