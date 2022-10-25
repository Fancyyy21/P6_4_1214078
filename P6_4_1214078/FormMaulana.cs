using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_1214078
{
    public partial class FormMaulanaLatihan : Form
    {
        public FormMaulanaLatihan()
        {
            InitializeComponent();
        }

        private void Selesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                epCorrect.SetError(txtID, "");
                epWarning.SetError(txtID, "Textbox ID tidak boleh kosong");
                epWrong.SetError(txtID, "");
            }
            else
            {
                if ((txtID.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtID, "Betul");
                    epWarning.SetError(txtID, "");
                    epWrong.SetError(txtID, "");
                }
                else
                {
                    epCorrect.SetError(txtID, "");
                    epWarning.SetError(txtID, "");
                    epWrong.SetError(txtID, "Inputan hanya boleh angka!");
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                epWarning.SetError(txtName, "Textbox Name tidak boleh kosong");
                epWrong.SetError(txtName, "");
                epCorrect.SetError(txtName, "");
            }
            else
            {
                if ((txtName.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtName, "");
                    epWrong.SetError(txtName, "");
                    epCorrect.SetError(txtName, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtName, "Inputan hanya boleh huruf!");
                    epWrong.SetError(txtName, "");
                    epCorrect.SetError(txtName, "");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul");
                }
                else
                {
                    epWarning.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void Height_Leave(object sender, EventArgs e)
        {
            int thisHeight = int.Parse(Height.Text);
            int thisWeight = int.Parse(Weight.Text);
            if (Height.Text == "")
            {
                string input = String.Empty;
                epCorrect.SetError(Height, "");
                epWarning.SetError(Height, "Textbox Height tidak boleh kosong");
                epWrong.SetError(Height, "");
            }
            else
            {
                if ((Height.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(Height, "Betul");
                    epWarning.SetError(Height, "");
                    epWrong.SetError(Height, "");
                }
                else
                {
                    epCorrect.SetError(Height, "");
                    epWarning.SetError(Height, "");
                    epWrong.SetError(Height, "Inputan hanya boleh angka!");
                }
            }
            if (thisHeight > thisWeight)
            {
                epWarning.SetError(Height, "");
                epWrong.SetError(Height, "");
                epCorrect.SetError(Height, "Benar");

                epWarning.SetError(Weight, "");
                epWrong.SetError(Weight, "");
                epCorrect.SetError(Weight, "Benar");
            }
            else
            {
                epWarning.SetError(Height, "Salah");
                epWrong.SetError(Height, "");
                epCorrect.SetError(Height, "");

                epWarning.SetError(Weight, "Salah");
                epWrong.SetError(Weight, "");
                epCorrect.SetError(Weight, "");
            }
        }

        private void Weight_Leave(object sender, EventArgs e)
        {
            {
                int thisHeight = int.Parse(Height.Text);
                int thisWeight = int.Parse(Weight.Text);

                if (Weight.Text == "")
                {
                    string input = String.Empty;

                    epWarning.SetError(Weight, "TextBox Weight tidak boleh kosong!");
                    epWrong.SetError(Weight, "");
                    epCorrect.SetError(Weight, "");
                }
                else
                {
                    if ((Weight.Text).All(Char.IsNumber))
                    {
                        epWarning.SetError(Weight, "");
                        epWrong.SetError(Weight, "");
                        epCorrect.SetError(Weight, "Betul!");
                    }
                    else
                    {
                        epWarning.SetError(Weight, "");
                        epWrong.SetError(Weight, "Inputan hanya boleh angka!");
                        epCorrect.SetError(Weight, "");
                    }
                }
                if (thisHeight > thisWeight)
                {
                    epWarning.SetError(Height, "");
                    epWrong.SetError(Height, "");
                    epCorrect.SetError(Height, "Benar");

                    epWarning.SetError(Weight, "");
                    epWrong.SetError(Weight, "");
                    epCorrect.SetError(Weight, "Benar");
                }
                else
                {
                    epWarning.SetError(Height, "Salah");
                    epWrong.SetError(Height, "");
                    epCorrect.SetError(Height, "");

                    epWarning.SetError(Weight, "Salah");
                    epWrong.SetError(Weight, "");
                    epCorrect.SetError(Weight, "");
                }
            }
        }

        private void Uppercase_Leave(object sender, EventArgs e)
        {
            if (Uppercase.Text == "")
            {
                epWarning.SetError(Uppercase, "Textbox Hobi1 tidak boleh kosong");
                epWrong.SetError(Uppercase, "");
                epCorrect.SetError(Uppercase, "");
            }
            else
            {
                if ((Uppercase.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(Uppercase, "");
                    epWrong.SetError(Uppercase, "");
                    epCorrect.SetError(Uppercase, "Betul!");
                }
                else
                {
                    epWarning.SetError(Uppercase, "INPUTAN HANYA BOLEH HURUF KAPITAL!");
                    epWrong.SetError(Uppercase, "");
                    epCorrect.SetError(Uppercase, "");
                }
            }
        }

        private void Lowercase_Leave(object sender, EventArgs e)
        {
            if (Lowercase.Text == "")
            {
                epWarning.SetError(Lowercase, "Textbox Hobi2 tidak boleh kosong");
                epWrong.SetError(Lowercase, "");
                epCorrect.SetError(Lowercase, "");
            }
            else
            {
                if ((Lowercase.Text).All(Char.IsLower))
                {
                    epWarning.SetError(Lowercase, "");
                    epWrong.SetError(Lowercase, "");
                    epCorrect.SetError(Lowercase, "Betul!");
                }
                else
                {
                    epWarning.SetError(Lowercase, "inputan hanya boleh huruf kecil!");
                    epWrong.SetError(Lowercase, "");
                    epCorrect.SetError(Lowercase, "");
                }
            }
        }

        private void Words1_Leave(object sender, EventArgs e)
        {
            if (Words1.Text == "")
            {
                epWarning.SetError(Words1, "Textbox Words1 tidak boleh kosong");
                epWrong.SetError(Words1, "");
                epCorrect.SetError(Words1, "");
            }
            else
            {
                if (Words1.Text.Length <= 5 )
                {
                    epWarning.SetError(Words1, "");
                    epWrong.SetError(Words1, "");
                    epCorrect.SetError(Words1, "Betul!");
                }
                else
                {
                    epWarning.SetError(Words1, "Tidak Boleh Lebih dari 5!");
                    epWrong.SetError(Words1, "");
                    epCorrect.SetError(Words1, "");
                }
            }
        }
        
        private void Words2_Leave(object sender, EventArgs e)
        {
            if (Words2.Text == "")
            {
                epWarning.SetError(Words2, "Textbox Words2 tidak boleh kosong");
                epWrong.SetError(Words2, "");
                epCorrect.SetError(Words2, "");
            }
            else
            {
                if (Words2.Text.Length <= 8 )
                {
                    epWarning.SetError(Words2, "");
                    epWrong.SetError(Words2, "");
                    epCorrect.SetError(Words2, "Betul!");
                }
                else
                {
                    epWarning.SetError(Words2, "Tidak Boleh Lebih dari 8!");
                    epWrong.SetError(Words2, "");
                    epCorrect.SetError(Words2, "");
                }
            }
        }
        private void Tampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                    ("ID : " + txtID.Text +
                    "\nName : " + txtName.Text +
                    "\nEmail : " + txtEmail.Text +
                    "\nHeight : " + Height.Text +
                    "\nWeight : " + Weight.Text +
                    "\nHobi1 : " + Uppercase.Text +
                    "\nHobi2 : " + Lowercase.Text +
                    "\nWords1 : " + Words1.Text +
                    "\nWords2 : " + Words2.Text,
                    "Informasi Formulir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
