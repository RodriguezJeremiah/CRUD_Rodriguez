
namespace CRUD_Rodriguez
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SearchClick = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.ContactName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxIsActive = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.EditContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(204, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show/Load ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 247);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(654, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Goto AddContact Form";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(284, 406);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(12, 130);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(44, 13);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search:";
            // 
            // SearchClick
            // 
            this.SearchClick.Location = new System.Drawing.Point(248, 124);
            this.SearchClick.Name = "SearchClick";
            this.SearchClick.Size = new System.Drawing.Size(75, 23);
            this.SearchClick.TabIndex = 11;
            this.SearchClick.Text = "Search";
            this.SearchClick.UseVisualStyleBackColor = true;
            this.SearchClick.Click += new System.EventHandler(this.SearchClick_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(522, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 38);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Edit Contact Information";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label69.Location = new System.Drawing.Point(523, 156);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(78, 13);
            this.label69.TabIndex = 20;
            this.label69.Text = "Contact Name:";
            // 
            // ContactName
            // 
            this.ContactName.Location = new System.Drawing.Point(607, 153);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(100, 20);
            this.ContactName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(523, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tel No:";
            // 
            // TelNo
            // 
            this.TelNo.Location = new System.Drawing.Point(607, 185);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(100, 20);
            this.TelNo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Location = new System.Drawing.Point(523, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mobile No:";
            // 
            // MobileNo
            // 
            this.MobileNo.Location = new System.Drawing.Point(607, 219);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(100, 20);
            this.MobileNo.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Location = new System.Drawing.Point(608, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 20);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.BackColor = System.Drawing.Color.DarkTurquoise;
            this.checkBoxIsActive.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.checkBoxIsActive.Location = new System.Drawing.Point(607, 257);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(55, 17);
            this.checkBoxIsActive.TabIndex = 38;
            this.checkBoxIsActive.TabStop = true;
            this.checkBoxIsActive.Text = "Active";
            this.checkBoxIsActive.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label9.Location = new System.Drawing.Point(523, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Status:";
            // 
            // EditContact
            // 
            this.EditContact.BackColor = System.Drawing.Color.Blue;
            this.EditContact.ForeColor = System.Drawing.Color.White;
            this.EditContact.Location = new System.Drawing.Point(93, 406);
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(108, 23);
            this.EditContact.TabIndex = 41;
            this.EditContact.Text = "Edit";
            this.EditContact.UseVisualStyleBackColor = false;
            this.EditContact.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "List of Contacts";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(551, 50);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(509, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(279, 289);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mark if it is Active";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditContact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ContactName);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchClick);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button SearchClick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox ContactName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TelNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton checkBoxIsActive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EditContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}

