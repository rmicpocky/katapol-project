using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace katapol_project
{
    public partial class FrmBingoGame : System.Web.UI.Page
    {
        ArrayList InputBingo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InputBingo = new ArrayList();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;

                if (Int32.TryParse(txtInput.Text, out x))
                {
                    InputBingo.Add(Int32.Parse(txtInput.Text));
                    txtInput.Text = "";
                }
                else
                {
                    Response.Write("cannot add number");
                }
                Display();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        private void Display()
        {
            try
            {
                string result = "";
                for (int i = 0; i < InputBingo.Count; i++)
                {
                    if (result != ""){
                        result = result + ",";
                    }
                    result = InputBingo[i].ToString();
                }

                lblInputBingo.Text = result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBingo();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        private void CheckBingo()
        {
            List<int> c1 = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            List<int> c2 = new List<int>(new int[] { 6, 7, 8, 9, 10 });
            List<int> c3 = new List<int>(new int[] { 11, 12, 13, 14, 15 });
            List<int> c4 = new List<int>(new int[] { 16, 17, 18, 19, 20 });
            List<int> c5 = new List<int>(new int[] { 21, 22, 23, 24, 25 });

            List<int> c6 = new List<int>(new int[] { 1, 6, 11, 16, 21 });
            try
            {
                bool resultBingo = false;



                //bool sub = false;
                //for (int i = 0; i < InputBingo.Count; i++)
                //{
                //    for (int j = 0; j < c1.Count; j++)
                //    {
                //        if (InputBingo[i] == c1[j])
                //        {
                //            sub = true;
                //        }
                //    }
                //}

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
