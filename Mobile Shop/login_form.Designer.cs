namespace Mobile_Shop
{
    partial class login_form
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
            this.uname_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_Pass = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uname_text
            // 
            this.uname_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_text.Location = new System.Drawing.Point(215, 188);
            this.uname_text.Name = "uname_text";
            this.uname_text.Size = new System.Drawing.Size(237, 23);
            this.uname_text.TabIndex = 2;
            this.uname_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_text
            // 
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(215, 257);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(237, 23);
            this.password_text.TabIndex = 3;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SteelBlue;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(215, 325);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(237, 33);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(215, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 20);
            this.button3.TabIndex = 6;
            this.button3.Text = "Forgot Password";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 79);
            this.panel4.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(247, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(168, 3);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login";
            // 
            // Show_Pass
            // 
            this.Show_Pass.AutoSize = true;
            this.Show_Pass.Location = new System.Drawing.Point(215, 292);
            this.Show_Pass.Name = "Show_Pass";
            this.Show_Pass.Size = new System.Drawing.Size(102, 17);
            this.Show_Pass.TabIndex = 9;
            this.Show_Pass.Text = "Show Password";
            this.Show_Pass.UseVisualStyleBackColor = true;
            this.Show_Pass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 570);
            this.Controls.Add(this.Show_Pass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.uname_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login_form";
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uname_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Show_Pass;
    }
}