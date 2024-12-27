﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            using (var model = new ExamModel())
            {

                var sejourweek = (from p in model.Sejours where p.TypeSejour == "Semaine" select p).ToList();
                dataGridView1.DataSource = sejourweek;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}