namespace DB_CRUD_Example
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
            this.dgv_user_info = new System.Windows.Forms.DataGridView();
            this.lb_id = new System.Windows.Forms.Label();
            this.tex_address = new System.Windows.Forms.TextBox();
            this.but_cleare = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_userID = new System.Windows.Forms.TextBox();
            this.tex_Password = new System.Windows.Forms.TextBox();
            this.pnl_controls = new System.Windows.Forms.Panel();
            this.tex_RePassword = new System.Windows.Forms.TextBox();
            this.tex_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_info)).BeginInit();
            this.pnl_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_user_info
            // 
            this.dgv_user_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_info.Location = new System.Drawing.Point(6, 222);
            this.dgv_user_info.Name = "dgv_user_info";
            this.dgv_user_info.Size = new System.Drawing.Size(537, 198);
            this.dgv_user_info.TabIndex = 9;
            this.dgv_user_info.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_user_info_RowHeaderMouseClick);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(9, 4);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(23, 13);
            this.lb_id.TabIndex = 12;
            this.lb_id.Text = "null";
            // 
            // tex_address
            // 
            this.tex_address.Location = new System.Drawing.Point(12, 123);
            this.tex_address.Name = "tex_address";
            this.tex_address.Size = new System.Drawing.Size(315, 20);
            this.tex_address.TabIndex = 4;
            // 
            // but_cleare
            // 
            this.but_cleare.Location = new System.Drawing.Point(463, 163);
            this.but_cleare.Name = "but_cleare";
            this.but_cleare.Size = new System.Drawing.Size(75, 23);
            this.but_cleare.TabIndex = 8;
            this.but_cleare.Text = "Cleare";
            this.but_cleare.UseVisualStyleBackColor = true;
            this.but_cleare.Click += new System.EventHandler(this.But_cleare_Click);
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(463, 134);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 23);
            this.but_delete.TabIndex = 7;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click_1);
            // 
            // but_update
            // 
            this.but_update.Location = new System.Drawing.Point(463, 103);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(75, 23);
            this.but_update.TabIndex = 6;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click_1);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(463, 75);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 5;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "User ID";
            // 
            // tex_userID
            // 
            this.tex_userID.Location = new System.Drawing.Point(12, 20);
            this.tex_userID.Name = "tex_userID";
            this.tex_userID.Size = new System.Drawing.Size(315, 20);
            this.tex_userID.TabIndex = 0;
            // 
            // tex_Password
            // 
            this.tex_Password.Location = new System.Drawing.Point(12, 48);
            this.tex_Password.Name = "tex_Password";
            this.tex_Password.PasswordChar = '*';
            this.tex_Password.Size = new System.Drawing.Size(315, 20);
            this.tex_Password.TabIndex = 1;
            // 
            // pnl_controls
            // 
            this.pnl_controls.Controls.Add(this.lb_id);
            this.pnl_controls.Controls.Add(this.tex_userID);
            this.pnl_controls.Controls.Add(this.tex_Password);
            this.pnl_controls.Controls.Add(this.tex_RePassword);
            this.pnl_controls.Controls.Add(this.tex_Email);
            this.pnl_controls.Controls.Add(this.tex_address);
            this.pnl_controls.Location = new System.Drawing.Point(110, 70);
            this.pnl_controls.Name = "pnl_controls";
            this.pnl_controls.Size = new System.Drawing.Size(352, 146);
            this.pnl_controls.TabIndex = 26;
            // 
            // tex_RePassword
            // 
            this.tex_RePassword.Location = new System.Drawing.Point(12, 74);
            this.tex_RePassword.Name = "tex_RePassword";
            this.tex_RePassword.PasswordChar = '*';
            this.tex_RePassword.Size = new System.Drawing.Size(315, 20);
            this.tex_RePassword.TabIndex = 2;
            // 
            // tex_Email
            // 
            this.tex_Email.Location = new System.Drawing.Point(12, 97);
            this.tex_Email.Name = "tex_Email";
            this.tex_Email.Size = new System.Drawing.Size(315, 20);
            this.tex_Email.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Re_Enter Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Empolyee Info";
            // 
            // Form1
            // 
            this.AcceptButton = this.but_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 424);
            this.Controls.Add(this.dgv_user_info);
            this.Controls.Add(this.but_cleare);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnl_controls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee_info";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_info)).EndInit();
            this.pnl_controls.ResumeLayout(false);
            this.pnl_controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user_info;
        private System.Windows.Forms.TextBox tex_address;
        private System.Windows.Forms.Button but_cleare;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tex_userID;
        private System.Windows.Forms.TextBox tex_Password;
        private System.Windows.Forms.Panel pnl_controls;
        private System.Windows.Forms.TextBox tex_RePassword;
        private System.Windows.Forms.TextBox tex_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_id;
    }
}

