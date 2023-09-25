using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txthoten.Clear();
            txtmssv.Clear();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if (rad1.Checked)
            {
                
            }
            else (rad2.Checked)
            {
              
            }
            if (rad3.Checked)
            {

            }
            else (rad4.Checked) 
            {
            
            }
            MessageBox.Show(txtmssv.Text+"\nSinh Viên: "+txthoten.Text+"\nLớp: "+cblop.Text+"\nNiên Khóa: "+cbnienkhoa.Text+
                "\nĐã đăng ký Học Kỳ "+" "+rad1.Text);
        }
    }
}
