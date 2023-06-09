﻿namespace Project
{
    partial class CreateShop
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbShopName = new System.Windows.Forms.TextBox();
            this.tbShopId = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter shop details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shop Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shop Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // tbShopName
            // 
            this.tbShopName.Location = new System.Drawing.Point(223, 154);
            this.tbShopName.Name = "tbShopName";
            this.tbShopName.Size = new System.Drawing.Size(191, 22);
            this.tbShopName.TabIndex = 5;
            this.tbShopName.TextChanged += new System.EventHandler(this.tbShopName_TextChanged);
            this.tbShopName.Validating += new System.ComponentModel.CancelEventHandler(this.tbShopName_Validating);
            this.tbShopName.Validated += new System.EventHandler(this.tbShopName_Validated);
            // 
            // tbShopId
            // 
            this.tbShopId.Location = new System.Drawing.Point(223, 221);
            this.tbShopId.Name = "tbShopId";
            this.tbShopId.Size = new System.Drawing.Size(191, 22);
            this.tbShopId.TabIndex = 6;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(223, 282);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(191, 22);
            this.tbLocation.TabIndex = 7;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(223, 339);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(191, 22);
            this.tbPhoneNumber.TabIndex = 8;
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Validating);
            this.tbPhoneNumber.Validated += new System.EventHandler(this.tbPhoneNumber_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(283, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Shop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvShop
            // 
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Location = new System.Drawing.Point(454, 154);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.RowHeadersWidth = 51;
            this.dgvShop.RowTemplate.Height = 24;
            this.dgvShop.Size = new System.Drawing.Size(554, 336);
            this.dgvShop.TabIndex = 11;
            this.dgvShop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShop_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(454, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Delete shop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvShop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbShopId);
            this.Controls.Add(this.tbShopName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateShop";
            this.Text = "CreateShop";
            this.Load += new System.EventHandler(this.CreateShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void CreateShop_Load(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbShopName;
        private System.Windows.Forms.TextBox tbShopId;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
    }
}