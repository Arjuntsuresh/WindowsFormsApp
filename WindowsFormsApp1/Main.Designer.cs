namespace WindowsFormsApp1
{
    partial class Main
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
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.user_Grid_View = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(155, 34);
            this.txt_Firstname.Multiline = true;
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(179, 45);
            this.txt_Firstname.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_Grid_View
            // 
            this.user_Grid_View.BackgroundColor = System.Drawing.Color.White;
            this.user_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_Grid_View.Location = new System.Drawing.Point(0, 299);
            this.user_Grid_View.Name = "user_Grid_View";
            this.user_Grid_View.RowHeadersWidth = 51;
            this.user_Grid_View.RowTemplate.Height = 24;
            this.user_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_Grid_View.Size = new System.Drawing.Size(801, 150);
            this.user_Grid_View.TabIndex = 3;
            this.user_Grid_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_Grid_View_CellClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button2.Location = new System.Drawing.Point(175, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button3.Location = new System.Drawing.Point(338, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button4.Location = new System.Drawing.Point(501, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-mail :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(155, 111);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(179, 45);
            this.txt_email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lastname :";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(513, 34);
            this.txt_lastname.Multiline = true;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(179, 45);
            this.txt_lastname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(441, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone :";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(513, 111);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(179, 45);
            this.txt_phone.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(155, 193);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(179, 45);
            this.txt_address.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Addresss :";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_Exit.Location = new System.Drawing.Point(664, 267);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 28);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.user_Grid_View);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView user_Grid_View;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exit;
    }
}