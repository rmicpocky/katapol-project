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
        private int[] c1 = new int[] { 1, 2, 3, 4, 5 };
        private int[] c2 = new int[] { 6, 7, 8, 9, 10 };
        private int[] c3 = new int[] { 11, 12, 13, 14, 15 };
        private int[] c4 = new int[] { 16, 17, 18, 19, 20 };
        private int[] c5 = new int[] { 21, 22, 23, 24, 25 };

        private int[] c6 = new int[] { 1, 6, 11, 16, 21 };
        private int[] c7 = new int[] { 2, 7, 12, 17, 22 };
        private int[] c8 = new int[] { 3, 8, 13, 18, 23 };
        private int[] c9 = new int[] { 4, 9, 14, 19, 24 };
        private int[] c10 = new int[] { 5, 10, 15, 20, 25 };

        private int[] c11 = new int[] { 1, 7, 13, 19, 25 };
        private int[] c12 = new int[] { 5, 9, 13, 17, 21 };

        //List<int> c1 = new List<int>(new int[] { 1, 2, 3, 4, 5 });
        //List<int> c2 = new List<int>(new int[] { 6, 7, 8, 9, 10 });
        //List<int> c3 = new List<int>(new int[] { 11, 12, 13, 14, 15 });
        //List<int> c4 = new List<int>(new int[] { 16, 17, 18, 19, 20 });
        //List<int> c5 = new List<int>(new int[] { 21, 22, 23, 24, 25 });
        //List<int> c6 = new List<int>(new int[] { 1, 6, 11, 16, 21 });

        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputBingoArr = SpliteInput(txtInput.Text.Trim());
                bool result = CheckBingo(inputBingoArr);

                if (result)
                {
                    lblResult.Text = "Bingo!!!";
                }
                else
                {
                    lblResult.Text = "NotBingo!!!";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        private string[] SpliteInput(string input)
        {
            try
            {
                string[] inputBingoArr = input.Split(',');

                return inputBingoArr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CheckBingo(string[] inputBingoArr)
        {
            bool result = false;
            try
            {
                if (CheckMainResult(inputBingoArr, c1)
                    || CheckMainResult(inputBingoArr, c2)
                    || CheckMainResult(inputBingoArr, c3)
                    || CheckMainResult(inputBingoArr, c4)
                    || CheckMainResult(inputBingoArr, c5)
                    || CheckMainResult(inputBingoArr, c6)
                    || CheckMainResult(inputBingoArr, c7)
                    || CheckMainResult(inputBingoArr, c8)
                    || CheckMainResult(inputBingoArr, c9)
                    || CheckMainResult(inputBingoArr, c10)
                    || CheckMainResult(inputBingoArr, c11)
                    || CheckMainResult(inputBingoArr, c12))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CheckMainResult(string[] inputBingoArr, int[] inputArrCheck)
        {
            bool result = false;
            try
            {
                for (int i = 0; i < inputBingoArr.Length; i++)
                {
                    int valueInt = Int32.Parse(inputBingoArr[i]);
                    if (CheckSubResult(valueInt, inputArrCheck))
                    {
                        result = true; //ตัวนั้น มีอยู่ใน bingo
                        break;
                    }
                    else
                    {
                        result = false; //ไม่อยู่ใน bingo
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CheckSubResult(int value, int[] inputArrCheck)
        {
            bool result = false;
            try
            {
                for (int i = 0; i < inputArrCheck.Length; i++)
                {
                    if (value == inputArrCheck[i])
                    {
                        result = true; //ถ้าตัวใดตัวนึงถูก
                        break;
                    }
                }

                //true มี
                //false ไม่มี
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
