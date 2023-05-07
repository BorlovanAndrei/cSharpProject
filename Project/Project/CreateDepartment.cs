using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project
{
    public partial class CreateDepartment : Form
    {
        private List<Department> _department;
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
        private void button1_Click(object sender, EventArgs e)
        {
            string depName = tbDepartmentName.Text;
            int depId = int.Parse(tbDepartmentId.Text);
            int shopIdDep = int.Parse(tbShopIdDep.Text);

            Department department = new Department(depName,depId,shopIdDep);
            _department.Add(department);
            displayDepartment();
        }

        private void lvDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Department>));

            using (FileStream stream = File.Create("serialized.xml"))
            {
                serializer.Serialize(stream, _department);
            }
        }
        private void CreateDepartment_Load(object sender, EventArgs e)
        {
            if (File.Exists("serialized.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Department>));

                using (FileStream stream = File.OpenRead("serialized.xml"))
                {
                    _department = (List<Department>)serializer.Deserialize(stream);
                    displayDepartment(); ;
                }
            }
        }
    }
}
