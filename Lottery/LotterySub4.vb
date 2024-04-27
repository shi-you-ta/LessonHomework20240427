Imports System.Reflection.Emit
Imports System.Text

''' <summary>
''' 宝くじAPPスーパークラスを継承したサブクラス(4桁）
''' </summary>
Public Class LotterySub4
    'LotterySuperクラスを継承
    Inherits LotterySuper

    '4桁のランダムな数字を取得する
    Public Overrides Function BaseLotteryGame() As String
        'ランダムクラスのインスタンスを生成
        Dim rnd As New Random()
        Dim number(3) As Integer
        'StringBuilderのインスタンスを生成
        Dim builder As New StringBuilder()

        '4回分ランダム値を取得する
        For i = 0 To 3
            number(i) = rnd.Next(0, 10)
            'StringBuilderに追加し数値を連結
            builder.Append(number(i))
        Next
        Return builder.ToString()
    End Function

    '番号の判定する
    Public Overrides Function JudgeNumber(lotteryNumber As String) As String
        Select Case lotteryNumber
            Case 7777.ToString()
                Return "1等当選"
            Case 5555.ToString()
                Return "2等当選"
            Case 8392.ToString()
                Return "3等当選"
            Case 5972.ToString()
                Return "4等当選"
            Case 2917.ToString()
                Return "5等当選"
            Case Else
                Return "はずれ"
        End Select
    End Function
End Class
