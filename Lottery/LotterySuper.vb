''' <summary>
''' 宝くじAppスーパークラス
''' </summary>
Public MustInherit Class LotterySuper
    'ランダムな番号を取得するメソッドをMustOverrideで定義
    '戻り値は全ての数値を連結して文字列型で返す
    Public MustOverride Function BaseLotteryGame() As String
    '取得したランダムな数字を判定するメソッドをMustOverrideで定義
    Public MustOverride Function JudgeNumber(lotteryNumber As String) As String

End Class
