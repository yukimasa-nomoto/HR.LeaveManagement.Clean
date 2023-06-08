DB接続必須

2023/06/08
	65からみても思い出せない。63から見直す
		tokenは、全部のClaimsを作成しているのが何故か気持ち悪い
	見終わった。===>続き
	Blazored.LocalStorageをblazorにインストール
	次66
		App.razorも書き換える
		blazorアプリが起動しない ===> net6に戻したら動いた。ここだけ何故か6にしていた
		おわった
	次69から

2023/05/25

section9開始 securing api
HR.LeaveManagement.Identity 作成
Application
	contractsにIndentity IAuthService等を構築
aspnetcore.identityがdeprecated 他のを入れてみる  identity.ui
identityにもModels作る
Jwt関係を作る。deprecatedをなんとかクリア
Dbを作成
	またadd-migrationをする
		add-migration InitialIdentityMigration -Context HrLeaveManagementIdentityDbContext
		Update-Database -Context HrLeaveManagementIdentityDbContext
section64まで終了
	jwt.ioで確認OK

---------------------------------------------------------------
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