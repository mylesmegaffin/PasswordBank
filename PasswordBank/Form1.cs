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
        string[] SavePasswords = new string[2];
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
            SavePasswords[1] = SavePasswords[0];
            SavePasswords[0] = tb_Password.Text;
        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Password: " + SavePasswords[0] + "\nOld Password: " + SavePasswords[1]);
        }
    }
}
