using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution1
{
    public partial class Form1 : Form
    {
        BindingSource bindingSourceClient = new BindingSource();

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingSourceClient.Current is Client client)
            {
                Nom.Text = client.NomClient;
                Adres.Text = client.AdresseClient;
                Tele.Text = client.TelClient;
            }
        }


        private void afficher()
        {
           

            using (var model = new ExamModel())
            { 

               var p = (from pers in model.Clients.Include("Reservations") select pers).ToList();

                bindingSourceClient.DataSource = p;
                dataGridView1.DataSource = bindingSourceClient;

                dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
                var reser = (from res in model.Reservations.Include("Sejours") select res).ToList();
                dataGridView2.DataSource = reser;



            }

        }
        public Form1()
        {
            InitializeComponent();
            afficher();
            label3.Text = "Infos du client";
            this.Size = new System.Drawing.Size(900, 900);

            using (var model = new ExamModel())
            {
                var id = (from pers in model.Clients select pers.IdClient);
                foreach (var idclient in id)
                {
                    comboBox1.Items.Add(idclient);
                    comboBox2.Items.Add(idclient);
                }

                comboBox1.Refresh();



            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            using (var model = new ExamModel())
            {
                if (string.IsNullOrWhiteSpace(Nom.Text) || string.IsNullOrWhiteSpace(Nom.Text) || string.IsNullOrWhiteSpace(Nom.Text))
                {
                    MessageBox.Show("Champs vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var client = new Client()
                    {
                        NomClient = Nom.Text,
                        AdresseClient = Adres.Text,
                        TelClient = Tele.Text,
                    };

                    model.Clients.Add(client);

                    try
                    {
                        model.SaveChanges();

                        afficher();
                        MessageBox.Show("Element  ajoute avec succes","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

               




            
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            using(var model = new ExamModel()) {
                var person=model.Clients.FirstOrDefault(p=>p.NomClient==Nom.Text && p.AdresseClient==Adres.Text && p.TelClient==Tele.Text);

                if (person!=null) {
                    model.Clients.Remove(person);
                    try
                    {
                        model.SaveChanges();
                        afficher();
                        MessageBox.Show("Element supprimé avec succes", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch {
                        MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
            }
                else
                {
                    MessageBox.Show("Aucun element avec ces informations");
                }
        }
    }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            using (var model = new ExamModel())
            {
                var person = model.Clients.FirstOrDefault(p => p.NomClient == Nom.Text && p.AdresseClient == Adres.Text && p.TelClient == Tele.Text);

                if (person != null)
                {    MessageBox.Show("Existe dans la Base de donnne", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("Aucun element avec ces informations");
                }
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

            using (var model = new ExamModel())
            {
                var person =  (from  p in model.Clients where p.NomClient == Nom.Text && p.AdresseClient == Adres.Text select p).FirstOrDefault();


                if (person != null)
                {
                    person.TelClient = Tele.Text;
                   
                    try
                    {
                        model.SaveChanges();
                        afficher();
                        MessageBox.Show("Element modifie avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun element avec ces informations");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void infoclient_Click(object sender, EventArgs e)
        {  using( var model = new  ExamModel()) { 
            int id = (int) comboBox1.SelectedItem;

            var infos = (from p in model.Clients where p.IdClient== id select p).FirstOrDefault();
            label3.Text=$"Le nom : {infos.NomClient} Adresse {infos.AdresseClient} Tel {infos.TelClient}";
            
        }
        }

        private void AjouterRes_Click(object sender, EventArgs e)
        {
            using (var model = new ExamModel())
            {
                int IdClient2 = (int)comboBox2.SelectedItem;
                if (string.IsNullOrWhiteSpace(date.Text) || string.IsNullOrWhiteSpace(comboBox2.SelectedItem.ToString()) || string.IsNullOrWhiteSpace(Pension.Text))
                {
                    MessageBox.Show("Champs vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var reservation = new Reservation()
                    {
                       Date = date.Value,
                       Pensioncomplete=Pension.Text,
                       IdClient= IdClient2
                    };

                    model.Reservations.Add(reservation);
                    var peronne = (from p in model.Clients where p.IdClient == IdClient2 select p).FirstOrDefault();
                    //peronne.Reservations = reservation;

                    try
                    {
                        model.SaveChanges();

                        afficher();
                        MessageBox.Show("Element  ajoute avec succes", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSourceClient.Position > 0)
            {
                bindingSourceClient.Position = 0;
            }
            else
            {
                MessageBox.Show("Vous êtes déjà sur le premier enregistrement.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bindingSourceClient.Position < bindingSourceClient.Count)
            {
                bindingSourceClient.Position = bindingSourceClient.Count;
            }
            else
            {
                MessageBox.Show("Vous êtes déjà sur le premier enregistrement.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bindingSourceClient.Position < bindingSourceClient.Count)
            {
                bindingSourceClient.Position = bindingSourceClient.Position + 1;
            }
            else
            {
                MessageBox.Show("Vous êtes déjà sur le premier enregistrement.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bindingSourceClient.Position >0)
            {
                bindingSourceClient.Position = bindingSourceClient.Position -1;
            }
            else
            {
                MessageBox.Show("Vous êtes déjà sur le premier enregistrement.");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
            
        

 
 


