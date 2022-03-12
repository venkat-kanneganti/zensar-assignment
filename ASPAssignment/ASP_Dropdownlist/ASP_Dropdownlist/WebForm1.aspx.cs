using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Dropdownlist
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "Select", "Classic350", "Enfield", "Royal Enfield" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }



        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/pictures/" + str + ".JPG";
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Classic350")
            {
                TextBox1.Text = "200000";
            }
            else if (DropDownList1.SelectedValue == "Enfield")
            {
                TextBox1.Text = "275000";
            }
            else if (DropDownList1.SelectedValue == "Royal Enfield")
            {
                TextBox1.Text = "300000";
            }

        }
    }
}