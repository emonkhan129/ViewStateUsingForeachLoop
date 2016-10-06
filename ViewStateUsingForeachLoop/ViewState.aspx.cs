using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateUsingForeachLoop
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
             string name = nameTextBox.Text;

            if (ViewState["student"] == null)
            {
                List<string> studentList = new List<string>();
                studentList.Add(name);
                ViewState["student"] = studentList;
            }
            else
            {
                List<string> studentList = (List<string>) ViewState["student"];
                studentList.Add(name);
                ViewState["student"] = studentList;
            }

            nameTextBox.Text = string.Empty;
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            List<string> studenList = (List<string>)ViewState["student"];
            foreach (string allStudents in studenList)
            {
                Response.Write(allStudents+"<br>");
            }
        }
    }
}