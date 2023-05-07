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
            if(lvDepartment.SelectedItems.Count > 0)
            {

                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
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

        private void CreateDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbDepartmentName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode.ToString() == "X")
            //{
            //    //MessageBox.Show("yu pressed that");
            //    string mes = tbDepartmentName.Text;
            //    tbDepartmentName.Text = "";
            //    if (e.Control && e.KeyCode.ToString() == "V")
            //    {
            //        tbDepartmentName.Text = mes;
            //    }
            //}
           // string mes = tbDepartmentName.Text;
            if (e.Alt)
            {
                //MessageBox.Show("asda");
                
                tbDepartmentName.Text = "";
                
            }
            

        }

        private void tbDepartmentId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt)
            {
                tbDepartmentId.Text = "";
            }
        }

        private void tbShopIdDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                tbShopIdDep.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lvDepartment.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDepartment.SelectedItems[0];
                //lvDepartment.Items.Remove(selectedItem);
                int index = lvDepartment.Items.IndexOf(selectedItem);
                if(index >=0 && index < _department.Count)
                {
                    _department.RemoveAt(index);
                    lvDepartment.Items.Remove(selectedItem);
                }
                
            }
        }

        private void update()
        {
            lvDepartment.SelectedItems[0].SubItems[0].Text = tbDepartmentName.Text;
            lvDepartment.SelectedItems[0].SubItems[1].Text = tbDepartmentId.Text;
            lvDepartment.SelectedItems[0].SubItems[2].Text = tbShopIdDep.Text;

            tbDepartmentName.Text = "";
            tbDepartmentId.Text = "";
            tbShopIdDep.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update();
        }

        private void lvDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            tbDepartmentName.Text = lvDepartment.SelectedItems[0].SubItems[0].Text;
            tbDepartmentId.Text = lvDepartment.SelectedItems[0].SubItems[1].Text;
            tbShopIdDep.Text = lvDepartment.SelectedItems[0].SubItems[2].Text;
        }
    }
}
