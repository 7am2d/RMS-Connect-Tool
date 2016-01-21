namespace ConnectTool
{
    partial class Connection
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
            this.Server = new System.Windows.Forms.TextBox();
            this.DB = new System.Windows.Forms.TextBox();
            this.UN = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BW = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Server.Location = new System.Drawing.Point(93, 18);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(166, 24);
            this.Server.TabIndex = 0;
            // 
            // DB
            // 
            this.DB.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DB.Location = new System.Drawing.Point(93, 44);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(166, 24);
            this.DB.TabIndex = 1;
            // 
            // UN
            // 
            this.UN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.UN.Location = new System.Drawing.Point(93, 70);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(166, 24);
            this.UN.TabIndex = 2;
            // 
            // PW
            // 
            this.PW.Font = new System.Drawing.Font("Tahoma", 10F);
            this.PW.Location = new System.Drawing.Point(93, 96);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '$';
            this.PW.Size = new System.Drawing.Size(166, 24);
            this.PW.TabIndex = 3;
            this.PW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserName";
            // 
            // BW
            // 
            this.BW.AutoSize = true;
            this.BW.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BW.Location = new System.Drawing.Point(9, 102);
            this.BW.Name = "BW";
            this.BW.Size = new System.Drawing.Size(66, 17);
            this.BW.TabIndex = 7;
            this.BW.Text = "Password";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Save.Location = new System.Drawing.Point(29, 169);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(96, 30);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Cancel.Location = new System.Drawing.Point(145, 169);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 30);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cansel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.DB);
            this.Controls.Add(this.Server);
            this.Name = "Connection";
            this.Text = "توصيلة قاعدة البيانات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BW;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.TextBox UN;
        private System.Windows.Forms.TextBox DB;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Button button1;
    }
}