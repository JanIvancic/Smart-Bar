﻿using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBar
{
    public partial class FrmReceipts : Form
    {
        public ReceiptService Service { get; set; }
        public FrmReceipts()
        {
            InitializeComponent();
            Service = new ReceiptService();
        }

        private void FrmReceipts_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvReceipts.SelectedCells[0].RowIndex;
                Receipt receipt = dgvReceipts.Rows[selectedRowIndex].DataBoundItem as Receipt;
                Service.DeleteReceipt(receipt);
                RefreshGUI();
            }
            else
            {
                MessageBox.Show("Morate odabrati račun!");
            }
            
        }

        private void RefreshGUI() 
        {
            dgvReceipts.DataSource = Service.GetAllReceipts();
            dgvReceipts.Columns["User"].Visible = false;
            dgvReceipts.Columns["ReceiptItems"].Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvReceipts.SelectedCells[0].RowIndex;
                Receipt receipt = dgvReceipts.Rows[selectedRowIndex].DataBoundItem as Receipt;
                var frmDetails = new FrmReceiptDetails(receipt);
                Hide();
                frmDetails.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Morate odabrati račun!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();
            int role = loginService.CheckUserRole();

            if (role == 1)
            {
                var frmUser = new FrmUser();
                Hide();
                frmUser.ShowDialog();
                Close();
            }
            else
            {
                var frmAdmin = new FrmAdmin();
                Hide();
                frmAdmin.ShowDialog();
                Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var frmCreateReceipt = new FrmCreateReceipt();
            Hide();
            frmCreateReceipt.ShowDialog();
            Close();
        }
    }
}
