Imports System.IO

Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub UploadMultipleFiles(sender As Object, e As EventArgs)
        For Each postedFile As HttpPostedFile In FileUpload1.PostedFiles
            Dim fileName As String = Path.GetFileName(postedFile.FileName)
            postedFile.SaveAs(Server.MapPath("~/Uploads/") & fileName)
        Next
        lblSuccess.Text = String.Format("{0} files have been uploaded successfully.", FileUpload1.PostedFiles.Count)
    End Sub
End Class
