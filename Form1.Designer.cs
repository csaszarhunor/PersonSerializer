namespace Serializer
{
    partial class FormPersons
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.previousBttn = new System.Windows.Forms.Button();
            this.nextBttn = new System.Windows.Forms.Button();
            this.saveBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(35, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(35, 76);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 13);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Address";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(35, 130);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(38, 13);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = "Phone";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(38, 37);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(245, 20);
            this.nameTxtBox.TabIndex = 3;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(38, 92);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(245, 20);
            this.addressTxtBox.TabIndex = 4;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Location = new System.Drawing.Point(38, 146);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(245, 20);
            this.phoneTxtBox.TabIndex = 5;
            // 
            // previousBttn
            // 
            this.previousBttn.Location = new System.Drawing.Point(29, 198);
            this.previousBttn.Name = "previousBttn";
            this.previousBttn.Size = new System.Drawing.Size(83, 23);
            this.previousBttn.TabIndex = 6;
            this.previousBttn.Text = "Previous";
            this.previousBttn.UseVisualStyleBackColor = true;
            this.previousBttn.Click += new System.EventHandler(this.previousBttn_Click);
            // 
            // nextBttn
            // 
            this.nextBttn.Location = new System.Drawing.Point(118, 198);
            this.nextBttn.Name = "nextBttn";
            this.nextBttn.Size = new System.Drawing.Size(83, 23);
            this.nextBttn.TabIndex = 7;
            this.nextBttn.Text = "Next";
            this.nextBttn.UseVisualStyleBackColor = true;
            this.nextBttn.Click += new System.EventHandler(this.nextBttn_Click);
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(207, 198);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(83, 23);
            this.saveBttn.TabIndex = 8;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // FormPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.nextBttn);
            this.Controls.Add(this.previousBttn);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "FormPersons";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.FormPersons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox phoneTxtBox;
        private System.Windows.Forms.Button previousBttn;
        private System.Windows.Forms.Button nextBttn;
        private System.Windows.Forms.Button saveBttn;
    }
}

