Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '宝くじフォームを表示する前にログイン画面を表示しユーザー名、パスワードを要求
        LoginForm1.ShowDialog()
    End Sub

    'ログイン成功しフォームが表示されたら現在時刻をフォーム上に表示しておく
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '現在の時間を取得してlabel8に表示する
        Label8.Text = DateAndTime.Now.ToString("yyyy/MM/dd(ddd)  HH:mm:ss")
    End Sub

    '4桁宝くじのスタートボタンがクリックされた場合
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '4桁用のサブクラスのインスタンスを生成
        Dim lotteryGame As New LotterySub4()
        'BaseLotteryGameメソッドの戻り値を格納する変数を用意
        Dim strNumber As String
        '取得した4桁の数字を文字列型変数に格納
        strNumber = lotteryGame.BaseLotteryGame()
        Try
            'メインフォームのラベルに数字を表示させる為
            '文字列型で取得した4桁整数を文字の配列へ変換
            Dim digits() As Char = strNumber.ToCharArray

            '各文字を整数に変換して個別の変数に格納
            Dim digit1 As Integer = Integer.Parse(digits(0).ToString())
            Dim digit2 As Integer = Integer.Parse(digits(1).ToString())
            Dim digit3 As Integer = Integer.Parse(digits(2).ToString())
            Dim digit4 As Integer = Integer.Parse(digits(3).ToString())
            '取得した個別の数字をラベルに表示する
            Label1.Text = digit1.ToString()
            Label2.Text = digit2.ToString()
            Label3.Text = digit3.ToString()
            Label4.Text = digit4.ToString()
        Catch ex As Exception
            MessageBox.Show("エラーが発生しました", "エラー画面")
        End Try

        '表示した数字を全て連結して再度文字列型へ
        Dim linkNumber As String = (Label1.Text & Label2.Text & Label3.Text & Label4.Text)
        'JudgeNumberメソッドの戻り値を格納する変数を用意し、
        '取得した4桁数字を判定した結果を格納する
        Dim result As String = lotteryGame.JudgeNumber(linkNumber)
        '結果を表示する
        Label6.Text = result

    End Sub

    '8桁宝くじのスタートボタンがクリックされた場合
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '8桁用のサブクラスのインスタンスを生成
        Dim lotteryGame As New LotterySub8()
        'BaseLotteryGameメソッドの戻り値を格納する変数を用意
        Dim strNumber As String
        '取得した8桁の数字を文字列型変数に格納
        strNumber = lotteryGame.BaseLotteryGame()
        Try
            'メインフォームのラベルに数字を表示させる為
            '文字列型で取得した4桁整数を文字の配列へ変換
            Dim digits() As Char = strNumber.ToCharArray

            '各文字を整数に変換して個別の変数に格納
            Dim digit1 As Integer = Integer.Parse(digits(0).ToString())
            Dim digit2 As Integer = Integer.Parse(digits(1).ToString())
            Dim digit3 As Integer = Integer.Parse(digits(2).ToString())
            Dim digit4 As Integer = Integer.Parse(digits(3).ToString())
            Dim digit5 As Integer = Integer.Parse(digits(4).ToString())
            Dim digit6 As Integer = Integer.Parse(digits(5).ToString())
            Dim digit7 As Integer = Integer.Parse(digits(6).ToString())
            Dim digit8 As Integer = Integer.Parse(digits(7).ToString())
            '取得した個別の数字をラベルに表示する
            Label9.Text = digit1.ToString()
            Label10.Text = digit2.ToString()
            Label11.Text = digit3.ToString()
            Label12.Text = digit4.ToString()
            Label13.Text = digit5.ToString()
            Label14.Text = digit6.ToString()
            Label15.Text = digit7.ToString()
            Label16.Text = digit8.ToString()
        Catch ex As Exception
            MessageBox.Show("エラーが発生しました", "エラー画面")
        End Try

        '表示した数字を全て連結して再度文字列型へ
        Dim linkNumber As String = (Label9.Text & Label10.Text & Label11.Text &
                                    Label12.Text & Label13.Text & Label14.Text &
                                    Label15.Text & Label16.Text)
        'JudgeNumberメソッドの戻り値を格納する変数を用意し、
        '取得した8桁数字を判定した結果を格納する
        Dim result As String = lotteryGame.JudgeNumber(linkNumber)
        '結果を表示する
        Label18.Text = result
    End Sub
End Class
