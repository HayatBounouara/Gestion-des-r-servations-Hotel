using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
             using(var model =new ExamModel()) {

                var sejourweek= (from p in model.Sejours where p.TypeSejour== "Week" select p).ToList();
                dataGridView1.DataSource = sejourweek;
        }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
