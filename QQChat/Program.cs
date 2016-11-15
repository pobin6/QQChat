using System;
using System.Windows.Forms;
using QQChat.UI;
namespace QQChat
{
    class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (new FormLogin().ShowDialog() == DialogResult.Yes)
            {
                Application.Run(new Form());
            }
        }
    }
}
