Public Class LoginForm1

    ' TODO: �w�肳�ꂽ���[�U�[������уp�X���[�h���g�p���āA�J�X�^���F�؂����s����R�[�h��}�����܂� 
    ' (https://go.microsoft.com/fwlink/?LinkId=35339 ���Q��)�B  
    ' �J�X�^�� �v�����V�p���́A�ȉ��̂悤�Ɍ��݂̃X���b�h�̃v�����V�p���ɃA�^�b�`�ł��܂�:
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' ���̏ꍇ CustomPrincipal �́A�F�؂����s����̂Ɏg���� IPrincipal �����ł��B
    ' ����ɂ�� My.User �́A���[�U�[������ѕ\�����Ȃǂ� CustomPrincipal �I�u�W�F�N�g�ɗv�񂳂ꂽ ID ����
    ' �Ԃ��܂��B

    '���[�U�[���ƃp�X���[�h���i�[���ꂽ�ǂݎ���p�̃t�B�[���h
    Public ReadOnly loginUser() = {"terakoya", "1111"}

    'OK�{�^���̃C�x���g�n���h���[
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        '���[�U�[���ƃp�X���[�h���`�F�b�N����
        If UsernameTextBox.Text = loginUser(0) AndAlso
                PasswordTextBox.Text = loginUser(1) Then
            '�F�؏o�����烁�b�Z�[�W��\�����A���O�C���t�H�[�������
            MessageBox.Show("���O�C������")
            Me.Close()
        Else
            '�F�؂ł��Ȃ��ꍇ�̓��b�Z�[�W��\����
            '���[�U�[���A�p�X���[�h���N���A���ăt�H�[�J�X�����[�U�[���e�L�X�g�{�b�N�X��
            MessageBox.Show("���[�U�[���F" & UsernameTextBox.Text & vbCrLf &
                            "�p�X���[�h�F" & PasswordTextBox.Text & vbCrLf &
                            "�͊Ԉ���Ă��܂�")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    '�L�����Z���{�^���̃C�x���g�n���h���[
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        '�v���O�����I������
        Application.Exit()
    End Sub


End Class
