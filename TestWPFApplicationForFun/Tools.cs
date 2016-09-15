using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestWPFApplicationForFun
{
    public static class Tools
    {
        public static void ShowMessage(object obj)
        {
            try
            {
                string Caption = string.Empty;
                string Message = string.Empty;

                Type ObjType = obj.GetType();

                if (ObjType == typeof(Exception))
                {
                    Caption = "Error!";
                    Message = ((Exception)obj).Message;
                }
                else if (ObjType == typeof(string))
                {
                    Caption = "Message";
                    Message = (string)obj;
                }
                else
                {
                    Caption = "Message!";
                    Message = obj.ToString();
                }

                MessageBox.Show(Message, Caption);
            }
            catch (Exception ex)
            {
                //Yeap! dangerus recursion
                ShowMessage(ex);
            }         
            
        }
    }
}
