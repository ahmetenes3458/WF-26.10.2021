using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_26._10._2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                if (maskedTextBox1.MaskFull)
                {
                    if (textBox2.Text != "")
                    {
                        if (numericUpDown1.Value != 0)
                        {
                            if (comboBox1.SelectedItem.ToString() != "")
                            {
                                string chklist = "";
                                foreach (var item in checkedListBox1.CheckedItems)
                                {
                                    chklist += item.ToString();
                                }
                                listBox1.Items.Add(textBox1.Text + " " + maskedTextBox1.Text + " " + textBox2.Text + " " + numericUpDown1.Value + " " + comboBox1.SelectedItem.ToString() + " " + chklist);
                            }
                            else
                            {
                                errorProvider1.SetError(comboBox1, "İçecek Seç");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(numericUpDown1, "Pizza Adedi Seç");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox2, "Adres Gir");
                    }
                }
                else
                {
                    errorProvider1.SetError(maskedTextBox1, "Telefon Numarası Ekisk ");
                }

            }
            else
            {
                errorProvider1.SetError(textBox1, "Ad Soyad Boş Geçilemez");
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Clear();
            textBox2.Text = string.Empty;
            numericUpDown1.Value = 0;
            comboBox1.SelectedItem = null;
            comboBox1.SelectedText = "";

            for (int i = 0; i < checkedListBox1.Items.Count ; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
