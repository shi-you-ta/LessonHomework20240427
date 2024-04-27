Imports System.Text

''' <summary>
''' 宝くじAPPスーパークラスを継承したサブクラス(8桁）
''' </summary>
Public Class LotterySub8
    'LotterySuperクラスを継承
    Inherits LotterySuper

    '8桁のランダムな数字を取得する
    Public Overrides Function BaseLotteryGame() As String
        'ランダムクラスのインスタンスを生成
        Dim rnd As New Random()
        Dim number(8) As String
        'StringBuilderクラスのインスタンスを生成
        Dim builder As New StringBuilder()

        '8回分ランダム値を取得する
        For i = 0 To 7
            number(i) = rnd.Next(0, 10)
            'StringBuilderに追加し数値を連結
            builder.Append(number(i))
        Next
        Return builder.ToString()
    End Function

    Public Overrides Function JudgeNumber(lotteryNumber As String) As String
        Select Case lotteryNumber
            Case 98298231.ToString()
                Return "1等当選"
            Case 21464312.ToString()
                Return "2等当選"
            Case 87645352.ToString()
                Return "3等当選"
            Case 32452676.ToString()
                Return "4等当選"
            Case 12314356.ToString()
                Return "5等当選"
            Case Else
                Return "はずれ"
        End Select
    End Function
End Class
