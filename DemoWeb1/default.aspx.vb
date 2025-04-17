Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = "Hello there " + TextBox1.Text + "!"

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Label2.Text = "Oh why did you click here " + TextBox1.Text + "?"

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label3.Text = "Yes you are " + TextBox1.Text + "!"

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Label4.Text = "Yes it is a new button " + TextBox1.Text + "!"

    End Sub
End Class