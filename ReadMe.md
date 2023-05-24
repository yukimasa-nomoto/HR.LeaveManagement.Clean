DB接続必須


2023/05/25

section9開始 securing api
HR.LeaveManagement.Identity 作成


NSwagStudioインストール
BlazorないでViewModelを用意する
LeaveTypeDtoは、APIと連携せずに、使用する。NSwaggerStudioで持ってきてる
CreateLeaveTypeCommandもNSwaggerStudioで用意されている
↓
section8終了
	DB繋いで「LeaveTypes」まで表示されるのは確認


2023/05/18
HR.LeaveManagement.Persistence.IntegrationTests も作成
	EntityFrameworkInMemoryもnugetから

section7終了

2023/05/17

test
	xUnitを実装
		Moq,Shouldlyをnuget

	section53。createdのところをコメントアウトにしたらテストは動いた
	section54から

api
	appsettings.jsonに接続文字記載
	EntityFramework.core.toolsをいれる
		パッケージマネージャー
			add-migration InitialMigration
			Update-Database
				成功、FKKEYとか命名が長かったので短くした
	addcores
	validator
		includeできる
section6終了 ===> commit



InfrastructureProject = 3rd Party
	options.extensionsでgetsectionからoption<EmailSettings>にいれれるっぽい
	Loggingも

section6の39まで終了


2023/05/10
start

finished section5の32まで終了