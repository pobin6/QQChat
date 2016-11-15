using QQChat.Manager;
using QQChat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQChat.UI
{
    public partial class FormLogin : Form
    {
        /// <summary>
        /// 
        /// </summary>
        int left, top;
        bool mov;
        UserManager userManager = new UserManager(new Context.QQChatContext());
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗口最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.Left = this.Left - left + MousePosition.X; ;
                this.Top = this.Top - top + MousePosition.Y;
                left = MousePosition.X;
                top = MousePosition.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("账号或密码不能为空");
            }
            else
            {
                USER user = userManager.findUser(comboBox1.Text, textBox1.Text);
                if (user == null) 
                {
                    MessageBox.Show("用户不存在");
                }
                else
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            left = MousePosition.X;
            top = MousePosition.Y;
            mov = true;
        }
    }
}
