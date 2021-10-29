using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_26._10._2021__1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form1 yeniform = new Form1();
                yeniform.Show();
               
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            button1.TabIndex = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("Caps Lock Açık","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
