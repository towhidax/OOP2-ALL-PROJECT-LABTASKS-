namespace CafeOrderManagementSystem
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.RichTextBox();
            this.txtPhoneName = new System.Windows.Forms.RichTextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblMembership = new System.Windows.Forms.Label();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoSliver = new System.Windows.Forms.RadioButton();
            this.rdoOthers = new System.Windows.Forms.RadioButton();
            this.rdoGold = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstOrderItems = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(119, 73);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(127, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 16);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "phone Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(141, 177);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(247, 73);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(169, 33);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.Text = "";
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.Location = new System.Drawing.Point(247, 115);
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.Size = new System.Drawing.Size(169, 31);
            this.txtPhoneName.TabIndex = 4;
            this.txtPhoneName.Text = "";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(247, 173);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(342, 173);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(114, 221);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(117, 16);
            this.lblMembership.TabIndex = 7;
            this.lblMembership.Text = "Membership Type";
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(260, 221);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(76, 20);
            this.rdoRegular.TabIndex = 8;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoSliver
            // 
            this.rdoSliver.AutoSize = true;
            this.rdoSliver.Location = new System.Drawing.Point(373, 219);
            this.rdoSliver.Name = "rdoSliver";
            this.rdoSliver.Size = new System.Drawing.Size(62, 20);
            this.rdoSliver.TabIndex = 9;
            this.rdoSliver.TabStop = true;
            this.rdoSliver.Text = "Silver";
            this.rdoSliver.UseVisualStyleBackColor = true;
            // 
            // rdoOthers
            // 
            this.rdoOthers.AutoSize = true;
            this.rdoOthers.Location = new System.Drawing.Point(458, 173);
            this.rdoOthers.Name = "rdoOthers";
            this.rdoOthers.Size = new System.Drawing.Size(67, 20);
            this.rdoOthers.TabIndex = 10;
            this.rdoOthers.TabStop = true;
            this.rdoOthers.Text = "Others";
            this.rdoOthers.UseVisualStyleBackColor = true;
            // 
            // rdoGold
            // 
            this.rdoGold.AutoSize = true;
            this.rdoGold.Location = new System.Drawing.Point(458, 221);
            this.rdoGold.Name = "rdoGold";
            this.rdoGold.Size = new System.Drawing.Size(57, 20);
            this.rdoGold.TabIndex = 11;
            this.rdoGold.TabStop = true;
            this.rdoGold.Text = "Gold";
            this.rdoGold.UseVisualStyleBackColor = true;
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.AutoSize = true;
            this.lstOrderItems.Location = new System.Drawing.Point(127, 298);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(76, 16);
            this.lstOrderItems.TabIndex = 12;
            this.lstOrderItems.Text = "Order Items";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cold Coffee",
            "Sandwich",
            "Espresso"});
            this.checkedListBox1.Location = new System.Drawing.Point(247, 280);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(440, 261);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(249, 31);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(440, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(249, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(249, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(440, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(249, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(249, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lstOrderItems);
            this.Controls.Add(this.rdoGold);
            this.Controls.Add(this.rdoOthers);
            this.Controls.Add(this.rdoSliver);
            this.Controls.Add(this.rdoRegular);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtPhoneName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RichTextBox txtCustomerName;
        private System.Windows.Forms.RichTextBox txtPhoneName;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.RadioButton rdoSliver;
        private System.Windows.Forms.RadioButton rdoOthers;
        private System.Windows.Forms.RadioButton rdoGold;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lstOrderItems;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}

