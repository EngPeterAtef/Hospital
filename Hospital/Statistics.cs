﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Statistics : Form
    {
        Controller ControllerObj;
        public Statistics(Controller Obj)
        {
            ControllerObj = Obj;
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void Expired_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetExpiredMedicines();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Empty_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetEmptyMedicines();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Valid_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetValidMedicines();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
