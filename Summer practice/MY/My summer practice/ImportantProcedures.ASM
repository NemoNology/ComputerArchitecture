; �������� ��������� � ���������
; ������� ����� ������ ����� ����
Close:
	; �������� ������� ������
	MOV AH, 01H
	INT 21H

	; �������� �������
	MOV AH, 4CH
	INT 21H

	RET


; ����� ������ �����������
; ����� 1-��� ������� ������ ���������� � �������� SI
PrintStrByChars:


	MOV	AH, 02H
	MOV	DX, 0
	MOV	DL, BYTE [SI]
	INT	21H

	INC	WORD SI

	CMP	BYTE [SI], '$'
	JNE	PrintStrByChars

	RET