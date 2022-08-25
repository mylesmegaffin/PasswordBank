using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordBank
{
    public partial class PasswordBank : Form
    {
        string[] SaveWebsites = new string[1000];
        string[] SaveEmails = new string[1000];
        string[] SavePasswords = new string[1000];
        int LoginCount = 0;
        public PasswordBank()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            tb_Password.Text = RandomString(12);
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            //The String of chars that will be selected from
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789!@#$%^&*";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_SavePassword_Click(object sender, EventArgs e)
        {
            if (tb_Website != null && tb_Email != null && tb_Password != null)
            {
                SaveWebsites[LoginCount] = tb_Website.Text;
                SaveEmails[LoginCount] = tb_Email.Text;
                SavePasswords[LoginCount] = tb_Password.Text;
                LoginCount++;
            }
            else
            {
                MessageBox.Show("Fill out all the fields");
            }
        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SaveWebsites[0] + " : " + SaveEmails[0] + " : " + SavePasswords[0] + "\n" + SaveWebsites[1] + " : " + SaveEmails[1] + " : " + SavePasswords[1]);
        }
    }
}
