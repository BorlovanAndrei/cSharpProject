using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project
{
    public partial class CreateDepartment : Form
    {
        private List<Department> _department;
        private string connectionStringCreateDept = "Data source = database.db";
        private int _currentDepartmentIndex;
        public CreateDepartment()
        {
            InitializeComponent();
            _department= new List<Department>();
        }


        private void LoadDepartment()
        {
            string query = "SELECT * FROM createdepartment";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateDept))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        long depid = (long)reader["deptId"];
                        string name = (string)reader["Name"];
                        long shopId = (long)reader["ShopId"];

                        Department dep = new Department(id,name,depid,shopId);
                        _department.Add(dep);
                    }
                }
            }

        }

        private void AddDepartment(Department department)
        {

            string query = "INSERT INTO createdepartment (Name, deptId, shopId) " + "VALUES (@name, @depId, @shoId); SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateDept))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", department.departmentName);
                command.Parameters.AddWithValue("@depId", department.departmentId);
                command.Parameters.AddWithValue("@shoId", department.shopId);
                connection.Open();

                long id = (long)command.ExecuteScalar();
                department.managerId = id;
                _department.Add(department);
            }
        }


    

        private void updateDepartment(Department department)
        {
            string query = "UPDATE createdepartment SET Name=@name, deptId=@depId, shopId = @shoId WHERE Id = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateDept))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("id", department.managerId);
                command.Parameters.AddWithValue("@name", department.departmentName);
                command.Parameters.AddWithValue("@depId", department.departmentId);
                
                command.Parameters.AddWithValue("@shoId", department.shopId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void deleteDepartment(Department department)
        {

            if (department != null)
            {
                string query = "DELETE FROM createdepartment WHERE Id=@id";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStringCreateDept))
                {
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@id", department.managerId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    _department.Remove(department);

                }
            }
           
        }

       


        public void displayDepartment()
        {
            lvDepartment.Items.Clear();

            foreach(Department department in _department)
            {
                var listViewItem = new ListViewItem(department.departmentName);
                listViewItem.SubItems.Add($"{department.departmentId}");
                listViewItem.SubItems.Add($"{department.shopId}");
                listViewItem.Tag = department;

                lvDepartment.Items.Add(listViewItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string depName = tbDepartmentName.Text;
            long depId = long.Parse(tbDepartmentId.Text);
            int shopIdDep = int.Parse(tbShopIdDep.Text);

            Department department = new Department(depName,depId,shopIdDep);
            //_department.Add(department);
            AddDepartment(department);
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

            LoadDepartment();


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
            //if(lvDepartment.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = lvDepartment.SelectedItems[0];
            //    //lvDepartment.Items.Remove(selectedItem);
            //    int index = lvDepartment.Items.IndexOf(selectedItem);
            //    if(index >=0 && index < _department.Count)
            //    {
            //        //_department.RemoveAt(index);

            //        lvDepartment.Items.Remove(selectedItem);
            //    }

            //}

            if (lvDepartment.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a participant!");

            }
            else if (MessageBox.Show("Are you sure?", "Delete Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem selected = lvDepartment.SelectedItems[0];
                Department department = (Department)selected.Tag;
                deleteDepartment(department);
                displayDepartment();
                //lvDepartment.Items.Remove(selected);
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
            //update();
            if(lvDepartment.SelectedItems.Count > 0)
            {
                Department department = (Department)lvDepartment.SelectedItems[0].Tag;
                department.departmentName = tbDepartmentName.Text;
                department.departmentId = long.Parse(tbDepartmentId.Text);
                department.shopId = long.Parse(tbShopIdDep.Text);
                updateDepartment(department);
                displayDepartment();
            }
            else
            {
                MessageBox.Show("Please choose one!");
            }
            

        }

        private void lvDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            //tbDepartmentName.Text = lvDepartment.SelectedItems[0].SubItems[0].Text;
            //tbDepartmentId.Text = lvDepartment.SelectedItems[0].SubItems[1].Text;
            //tbShopIdDep.Text = lvDepartment.SelectedItems[0].SubItems[2].Text;
        }

        private void tbDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 24);
            e.Graphics.DrawString("List of departments: ", font, Brushes.Orange, 10, 10);

            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;
            
            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_currentDepartmentIndex < _department.Count)
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                
                
                e.Graphics.DrawString(
                    _department[_currentDepartmentIndex].departmentName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _department[_currentDepartmentIndex].departmentId.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _department[_currentDepartmentIndex].shopId.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                _currentDepartmentIndex++;
                currentY += rowHeight;

                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentDepartmentIndex = 0;
        }


        private void ExportReportAsTxt()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT Files|*.txt";
            saveFileDialog.Title = "Export Report as TXT";
            saveFileDialog.FileName = "report.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Department department in _department)
                    {
                        writer.WriteLine($"Department Name: {department.departmentName}");
                        writer.WriteLine($"Department ID: {department.departmentId}");
                        writer.WriteLine($"Shop ID: {department.shopId}");
                        writer.WriteLine();
                    }
                }
                MessageBox.Show("Report exported successfully!");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExportReportAsTxt();
        }

        private void printPreviewDialog1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }catch(Exception )
            {
                MessageBox.Show("Error while trying to load the document!");
            }
        }
    }
}
