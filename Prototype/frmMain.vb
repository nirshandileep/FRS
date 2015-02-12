Public Class frmMain 

    Sub showform(ByVal frm As Form)
        frm.MdiParent = Me
        frm.Show()
        frm.BringToFront()

    End Sub

    Private Sub NewToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem7.Click
        showform(frmCustomer)

    End Sub

    Private Sub SearchToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem7.Click
        showform(frmCustomerSearch)


    End Sub

    Private Sub NewToolStripMenuItem_Clicok(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        showform(frmInstitution)
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        showform(frmInstitutionSearch)
    End Sub

    Private Sub NewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem1.Click
        showform(frmCouncil)
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem1.Click
        showform(frmCouncilSearch)
    End Sub
End Class