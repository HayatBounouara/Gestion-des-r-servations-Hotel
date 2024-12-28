namespace Solution1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Adresse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Tele = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.infoclient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pension = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AjouterRes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.Location = new System.Drawing.Point(38, 58);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(56, 25);
            this.Adresse.TabIndex = 0;
            this.Adresse.Text = "Nom";
            this.Adresse.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel.Location = new System.Drawing.Point(51, 149);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(43, 25);
            this.Tel.TabIndex = 2;
            this.Tel.Text = "Tel";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(141, 58);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(184, 26);
            this.Nom.TabIndex = 3;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(141, 108);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(184, 26);
            this.Adres.TabIndex = 4;
            // 
            // Tele
            // 
            this.Tele.Location = new System.Drawing.Point(141, 149);
            this.Tele.Name = "Tele";
            this.Tele.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tele.Size = new System.Drawing.Size(184, 26);
            this.Tele.TabIndex = 5;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(24, 195);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 45);
            this.add.TabIndex = 6;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(708, 198);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Location = new System.Drawing.Point(224, 195);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Supprimer.Size = new System.Drawing.Size(156, 45);
            this.Supprimer.TabIndex = 8;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Location = new System.Drawing.Point(24, 257);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(144, 45);
            this.Rechercher.TabIndex = 9;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = false;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(224, 257);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(156, 45);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(58, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion des clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 15;
            this.label3.UseMnemonic = false;
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(28, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gestion des réservations";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // infoclient
            // 
            this.infoclient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infoclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoclient.Location = new System.Drawing.Point(340, 342);
            this.infoclient.Name = "infoclient";
            this.infoclient.Size = new System.Drawing.Size(156, 43);
            this.infoclient.TabIndex = 15;
            this.infoclient.Text = "AfficherInfo";
            this.infoclient.UseVisualStyleBackColor = false;
            this.infoclient.Click += new System.EventHandler(this.infoclient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "IdClient";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(428, 526);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(668, 151);
            this.dataGridView2.TabIndex = 17;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(100, 526);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 26);
            this.date.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pension";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "IdClient";
            // 
            // Pension
            // 
            this.Pension.Location = new System.Drawing.Point(120, 574);
            this.Pension.Name = "Pension";
            this.Pension.Size = new System.Drawing.Size(121, 26);
            this.Pension.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 628);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 23;
            // 
            // AjouterRes
            // 
            this.AjouterRes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AjouterRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterRes.Location = new System.Drawing.Point(268, 628);
            this.AjouterRes.Name = "AjouterRes";
            this.AjouterRes.Size = new System.Drawing.Size(124, 49);
            this.AjouterRes.TabIndex = 24;
            this.AjouterRes.Text = "Ajouter reservation";
            this.AjouterRes.UseVisualStyleBackColor = false;
            this.AjouterRes.Click += new System.EventHandler(this.AjouterRes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 755);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Gestion des Séjours";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(442, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Premier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(578, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "Dernier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(724, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 38);
            this.button4.TabIndex = 28;
            this.button4.Text = "Suivant";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(914, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 38);
            this.button5.TabIndex = 29;
            this.button5.Text = "Précédent";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 838);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AjouterRes);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Pension);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoclient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Tele);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adresse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Tele;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button infoclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Pension;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button AjouterRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

