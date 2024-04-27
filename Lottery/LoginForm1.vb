Public Class LoginForm1

    ' TODO: 指定されたユーザー名およびパスワードを使用して、カスタム認証を実行するコードを挿入します 
    ' (https://go.microsoft.com/fwlink/?LinkId=35339 を参照)。  
    ' カスタム プリンシパルは、以下のように現在のスレッドのプリンシパルにアタッチできます:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' この場合 CustomPrincipal は、認証を実行するのに使われる IPrincipal 実装です。
    ' これにより My.User は、ユーザー名および表示名などの CustomPrincipal オブジェクトに要約された ID 情報を
    ' 返します。

    'ユーザー名とパスワードが格納された読み取り専用のフィールド
    Public ReadOnly loginUser() = {"terakoya", "1111"}

    'OKボタンのイベントハンドラー
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'ユーザー名とパスワードをチェックする
        If UsernameTextBox.Text = loginUser(0) AndAlso
                PasswordTextBox.Text = loginUser(1) Then
            '認証出来たらメッセージを表示し、ログインフォームを閉じる
            MessageBox.Show("ログイン成功")
            Me.Close()
        Else
            '認証できない場合はメッセージを表示し
            'ユーザー名、パスワードをクリアしてフォーカスをユーザー名テキストボックスに
            MessageBox.Show("ユーザー名：" & UsernameTextBox.Text & vbCrLf &
                            "パスワード：" & PasswordTextBox.Text & vbCrLf &
                            "は間違っています")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    'キャンセルボタンのイベントハンドラー
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'プログラム終了する
        Application.Exit()
    End Sub


End Class
