namespace Customer_Management_System
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdo = new System.Windows.Forms.GroupBox();
            this.rdoOthers = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoPremium = new System.Windows.Forms.RadioButton();
            this.rdoGeneral = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtName.Location = new System.Drawing.Point(196, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtPassword.Location = new System.Drawing.Point(196, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(78, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Tomato;
            this.textBox1.Location = new System.Drawing.Point(296, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Tomato;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(296, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rdo
            // 
            this.rdo.Controls.Add(this.rdoOthers);
            this.rdo.Controls.Add(this.rdoFemale);
            this.rdo.Controls.Add(this.rdoMale);
            this.rdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rdo.Location = new System.Drawing.Point(200, 151);
            this.rdo.Name = "rdo";
            this.rdo.Size = new System.Drawing.Size(360, 43);
            this.rdo.TabIndex = 5;
            this.rdo.TabStop = false;
            this.rdo.Text = "Gender";
            this.rdo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoOthers
            // 
            this.rdoOthers.AutoSize = true;
            this.rdoOthers.BackColor = System.Drawing.Color.Tan;
            this.rdoOthers.Location = new System.Drawing.Point(276, 0);
            this.rdoOthers.Name = "rdoOthers";
            this.rdoOthers.Size = new System.Drawing.Size(78, 24);
            this.rdoOthers.TabIndex = 8;
            this.rdoOthers.TabStop = true;
            this.rdoOthers.Text = "Others";
            this.rdoOthers.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Tan;
            this.rdoFemale.Location = new System.Drawing.Point(169, 0);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(83, 24);
            this.rdoFemale.TabIndex = 7;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Tan;
            this.rdoMale.Location = new System.Drawing.Point(81, 0);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(64, 24);
            this.rdoMale.TabIndex = 6;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPremium);
            this.groupBox3.Controls.Add(this.rdoGeneral);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox3.Location = new System.Drawing.Point(200, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 37);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category";
            // 
            // rdoPremium
            // 
            this.rdoPremium.AutoSize = true;
            this.rdoPremium.BackColor = System.Drawing.Color.Tan;
            this.rdoPremium.Location = new System.Drawing.Point(227, 0);
            this.rdoPremium.Name = "rdoPremium";
            this.rdoPremium.Size = new System.Drawing.Size(92, 24);
            this.rdoPremium.TabIndex = 1;
            this.rdoPremium.TabStop = true;
            this.rdoPremium.Text = "Premium";
            this.rdoPremium.UseVisualStyleBackColor = false;
            // 
            // rdoGeneral
            // 
            this.rdoGeneral.AutoSize = true;
            this.rdoGeneral.BackColor = System.Drawing.Color.Tan;
            this.rdoGeneral.Location = new System.Drawing.Point(96, 0);
            this.rdoGeneral.Name = "rdoGeneral";
            this.rdoGeneral.Size = new System.Drawing.Size(87, 24);
            this.rdoGeneral.TabIndex = 0;
            this.rdoGeneral.TabStop = true;
            this.rdoGeneral.Text = "General";
            this.rdoGeneral.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(21, 320);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(151, 47);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnSearch.Location = new System.Drawing.Point(187, 318);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 50);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnUpdate.Location = new System.Drawing.Point(334, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 47);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnDelete.Location = new System.Drawing.Point(476, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 47);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnClear.Location = new System.Drawing.Point(633, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 47);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.rdo.ResumeLayout(false);
            this.rdo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox rdo;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoOthers;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoGeneral;
        private System.Windows.Forms.RadioButton rdoPremium;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

