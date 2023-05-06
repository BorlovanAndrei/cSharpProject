using Project.Classes;
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
    public partial class CreateDepartment : Form
    {
        private readonly List<Department> _department;
        public CreateDepartment()
        {
            InitializeComponent();
            _department= new List<Department>();
        }

        public void displayDepartment()
        {
            lvDepartment.Items.Clear();

            foreach(Department department in _department)
            {
                var listViewItem = new ListViewItem(department.departmentName);
                listViewItem.SubItems.Add($"{department.departmentId}");
                listViewItem.SubItems.Add($"{department.shopId}");

                lvDepartment.Items.Add(listViewItem);
            }
        }

        private void CreateDepartment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string depName = tbDepartmentName.Text;
            int depId = int.Parse(tbDepartmentId.Text);
            int shopIdDep = int.Parse(tbShopIdDep.Text);

            Department department = new Department(depName,depId,shopIdDep);
            _department.Add(department);
            displayDepartment();
        }
    }
}
