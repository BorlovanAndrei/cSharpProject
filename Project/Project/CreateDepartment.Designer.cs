﻿namespace Project
{
    partial class CreateDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.tbDepartmentId = new System.Windows.Forms.TextBox();
            this.tbShopIdDep = new System.Windows.Forms.TextBox();
            this.lvDepartment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter department details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shop Id";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(198, 164);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(207, 22);
            this.tbDepartmentName.TabIndex = 6;
            // 
            // tbDepartmentId
            // 
            this.tbDepartmentId.Location = new System.Drawing.Point(198, 220);
            this.tbDepartmentId.Name = "tbDepartmentId";
            this.tbDepartmentId.Size = new System.Drawing.Size(207, 22);
            this.tbDepartmentId.TabIndex = 7;
            // 
            // tbShopIdDep
            // 
            this.tbShopIdDep.Location = new System.Drawing.Point(198, 283);
            this.tbShopIdDep.Name = "tbShopIdDep";
            this.tbShopIdDep.Size = new System.Drawing.Size(207, 22);
            this.tbShopIdDep.TabIndex = 8;
            // 
            // lvDepartment
            // 
            this.lvDepartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDepartment.HideSelection = false;
            this.lvDepartment.Location = new System.Drawing.Point(441, 134);
            this.lvDepartment.Name = "lvDepartment";
            this.lvDepartment.Size = new System.Drawing.Size(401, 324);
            this.lvDepartment.TabIndex = 9;
            this.lvDepartment.UseCompatibleStateImageBehavior = false;
            this.lvDepartment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Department Name";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Department Id";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Shop Id";
            this.columnHeader3.Width = 133;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(143, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Department";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvDepartment);
            this.Controls.Add(this.tbShopIdDep);
            this.Controls.Add(this.tbDepartmentId);
            this.Controls.Add(this.tbDepartmentName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateDepartment";
            this.Text = "CreateDepartment";
            this.Load += new System.EventHandler(this.CreateDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.TextBox tbDepartmentId;
        private System.Windows.Forms.TextBox tbShopIdDep;
        private System.Windows.Forms.ListView lvDepartment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
    }
}