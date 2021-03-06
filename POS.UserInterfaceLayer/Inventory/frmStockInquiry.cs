﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BusinessLayer.Wrapper;
namespace POS.UserInterfaceLayer.Inventory
{
    public partial class frmStockInquiry : Form
    {
        INVProductStockWrapper _invProductStockWrapper;
        public frmStockInquiry()
        {
            InitializeComponent();
            _invProductStockWrapper = new INVProductStockWrapper();
        }

        private void frmStockInquiry_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgrid_stock.AutoGenerateColumns = false;
            string code = tbx_ProductCode.Text != "" ? tbx_ProductCode.Text : null;
            string name = tbx_ProductName.Text != "" ? tbx_ProductName.Text : null;
           dgrid_stock.DataSource =  _invProductStockWrapper.GetInventoryStock(null,code,name ,null,false );
        }

        private void dgrid_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgrid_stock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_stock.SelectedRows.Count>0)
            {
                int _productStockID = (int)dgrid_stock.SelectedRows[0].Cells["col_invProductStock"].Value;
                INVProductStockWrapper _iNVProductStockWrapper;
                _iNVProductStockWrapper = new INVProductStockWrapper();
                dgrid_batches.AutoGenerateColumns = false;
                dgrid_batches.DataSource = _iNVProductStockWrapper.GetInventoryStock(_productStockID, null, null, true, true);
                
            }
        }

       
    }
}
