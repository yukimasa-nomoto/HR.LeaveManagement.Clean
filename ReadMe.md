DB�ڑ��K�{

2023/06/08
	65����݂Ă��v���o���Ȃ��B63���猩����
		token�́A�S����Claims���쐬���Ă���̂����̂��C��������
	���I������B===>����
	Blazored.LocalStorage��blazor�ɃC���X�g�[��
	��66
		App.razor������������
		blazor�A�v�����N�����Ȃ� ===> net6�ɖ߂����瓮�����B�����������̂�6�ɂ��Ă���
		�������
	��69����

2023/05/25

section9�J�n securing api
HR.LeaveManagement.Identity �쐬
Application
	contracts��Indentity IAuthService�����\�z
aspnetcore.identity��deprecated ���̂����Ă݂�  identity.ui
identity�ɂ�Models���
Jwt�֌W�����Bdeprecated���Ȃ�Ƃ��N���A
Db���쐬
	�܂�add-migration������
		add-migration InitialIdentityMigration -Context HrLeaveManagementIdentityDbContext
		Update-Database -Context HrLeaveManagementIdentityDbContext
section64�܂ŏI��
	jwt.io�Ŋm�FOK

---------------------------------------------------------------
NSwagStudio�C���X�g�[��
Blazor�Ȃ���ViewModel��p�ӂ���
LeaveTypeDto�́AAPI�ƘA�g�����ɁA�g�p����BNSwaggerStudio�Ŏ����Ă��Ă�
CreateLeaveTypeCommand��NSwaggerStudio�ŗp�ӂ���Ă���
��
section8�I��
	DB�q���ŁuLeaveTypes�v�܂ŕ\�������̂͊m�F


2023/05/18
HR.LeaveManagement.Persistence.IntegrationTests ���쐬
	EntityFrameworkInMemory��nuget����

section7�I��

2023/05/17

test
	xUnit������
		Moq,Shouldly��nuget

	section53�Bcreated�̂Ƃ�����R�����g�A�E�g�ɂ�����e�X�g�͓�����
	section54����

api
	appsettings.json�ɐڑ������L��
	EntityFramework.core.tools�������
		�p�b�P�[�W�}�l�[�W���[
			add-migration InitialMigration
			Update-Database
				�����AFKKEY�Ƃ����������������̂ŒZ������
	addcores
	validator
		include�ł���
section6�I�� ===> commit



InfrastructureProject = 3rd Party
	options.extensions��getsection����option<EmailSettings>�ɂ�������ۂ�
	Logging��

section6��39�܂ŏI��


2023/05/10
start

finished section5��32�܂ŏI��