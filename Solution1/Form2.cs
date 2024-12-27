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
    public partial class Form2 : Form
    {   private void afficher2()
        {
            using (var model = new ExamModel())
            {
                var res = (from p in model.Reservations select p.CodeReservation);
                foreach (var p in res)
                {
                    listBox1.Items.Add(p);
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
            afficher2();
            comboBox1.Items.Add("journalier");
            comboBox1.Items.Add("Week");
            comboBox1.Items.Add("Semaine");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            duree.Text= string.Empty;
            comboBox1.Text = string.Empty;

            //listBox1.SetSelected(listBox1.SelectedIndex, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var model = new ExamModel()) {
                var sejour = new Sejour()
                {  CodeReservation = (int) listBox1.SelectedItem,
                    TypeSejour=comboBox1.SelectedItem.ToString(),
                    DureeSejour=duree.Text,
                    DateSejour=datesejour.Value,
                                    };
                model.Sejours.Add(sejour);

                try
                {
                    model.SaveChanges();
                    MessageBox.Show("ajoute avec succes");
                }
                catch (Exception ex) {
                    MessageBox.Show("erreur");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();  
            form4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
