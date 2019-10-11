namespace Mobile_Shop
{
    partial class form_item
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textcompany = new System.Windows.Forms.TextBox();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.dgvitem = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 559);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 79);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(37, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 79);
            this.panel4.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(45, 59);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 3);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Item Master";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.closebtn);
            this.panel6.Controls.Add(this.removebtn);
            this.panel6.Controls.Add(this.editbtn);
            this.panel6.Controls.Add(this.savebtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(37, 513);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(588, 46);
            this.panel6.TabIndex = 4;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(513, 8);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(63, 30);
            this.closebtn.TabIndex = 8;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebtn.FlatAppearance.BorderSize = 0;
            this.removebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.Location = new System.Drawing.Point(427, 8);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(80, 30);
            this.removebtn.TabIndex = 7;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.Location = new System.Drawing.Point(358, 8);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(63, 30);
            this.editbtn.TabIndex = 6;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(281, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(71, 30);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copmany Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model No :";
            // 
            // textcompany
            // 
            this.textcompany.BackColor = System.Drawing.SystemColors.Control;
            this.textcompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textcompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcompany.Location = new System.Drawing.Point(233, 136);
            this.textcompany.Name = "textcompany";
            this.textcompany.Size = new System.Drawing.Size(295, 24);
            this.textcompany.TabIndex = 6;
            this.textcompany.TextChanged += new System.EventHandler(this.textcompany_TextChanged);
            // 
            // textmodel
            // 
            this.textmodel.BackColor = System.Drawing.SystemColors.Control;
            this.textmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmodel.Location = new System.Drawing.Point(233, 174);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(295, 24);
            this.textmodel.TabIndex = 7;
            // 
            // dgvitem
            // 
            this.dgvitem.AllowUserToAddRows = false;
            this.dgvitem.AllowUserToDeleteRows = false;
            this.dgvitem.AllowUserToResizeColumns = false;
            this.dgvitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvitem.Location = new System.Drawing.Point(37, 246);
            this.dgvitem.Name = "dgvitem";
            this.dgvitem.Size = new System.Drawing.Size(588, 267);
            this.dgvitem.TabIndex = 8;
            this.dgvitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitem_CellContentClick);
            // 
            // form_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 559);
            this.Controls.Add(this.dgvitem);
            this.Controls.Add(this.textmodel);
            this.Controls.Add(this.textcompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "form_item";
            this.Text = "form_item";
            this.Load += new System.EventHandler(this.form_item_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textcompany;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvitem;
    }
}