using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class ViewShop : Form
    {

        private readonly MainFormViewModel _viewModel;

        public ViewShop()
        {
            InitializeComponent();
            _viewModel = new MainFormViewModel();
        }

        private void ViewShop_Load(object sender, EventArgs e)
        {
            //dgvViewShop.DataSource = _viewModel.Shops;
            dgvViewShop.DataSource = _viewModel.Employees;

            textBox1.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.Name));
            textBox2.DataBindings.Add("Text", _viewModel, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", _viewModel, "Location");
            textBox4.DataBindings.Add("Text", _viewModel, "Phone");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //_viewModel.AddShop();
            _viewModel.AddEmployee();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvViewShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
