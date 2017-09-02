using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class CS : System.Web.UI.Page
{
	protected void UploadMultipleFiles(object sender, EventArgs e)
	{
		foreach (HttpPostedFile postedFile in FileUpload1.PostedFiles)
		{
			string fileName = Path.GetFileName(postedFile.FileName);
			postedFile.SaveAs(Server.MapPath("~/Uploads/") + fileName);
		}
		lblSuccess.Text = string.Format("{0} files have been uploaded successfully.", FileUpload1.PostedFiles.Count);
	}
}