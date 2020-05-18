Public Class FormLotere

    Private Sub tombolBangkitkan_Click(sender As Object, e As EventArgs) Handles tombolBangkitkan.Click
        'menciptakan sebuah array untuk menampung lima angka lotere
        Const intSUBSKRIPT_MAKS As Integer = 4     'subskript maksimum
        Dim intAngka(intSUBSKRIPT_MAKS) As Integer 'deklarasi array
        Dim intHitung As Integer 'pencacah loop

        'menciptakan sebuah objek Random
        Dim rand As New Random

        'mengisi array dengan nilai-nilai acak
        'setiap nilai berada dalam rentang 0-99.
        For intHitung = 0 To intSUBSKRIPT_MAKS
            intAngka(intHitung) = rand.Next(100)
        Next

        'menampilkan elemen-elemen array pada label-label
        labelPertama.Text = intAngka(0).ToString()
        labelKedua.Text = intAngka(1).ToString()
        labelKetiga.Text = intAngka(2).ToString()
        labelKeempat.Text = intAngka(3).ToString()
        labelKelima.Text = intAngka(4).ToString()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
