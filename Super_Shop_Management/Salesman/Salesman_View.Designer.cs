namespace Super_Shop_Management
{
    partial class Salesman_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salesman_View));
            this.salesman_P_ID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.transactionTotalAmount = new System.Windows.Forms.Button();
            this.salesman_gridview = new System.Windows.Forms.DataGridView();
            this.salesman_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.member_bttn = new System.Windows.Forms.Button();
            this.transactionDelete = new System.Windows.Forms.Button();
            this.transactionSave = new System.Windows.Forms.Button();
            this.transactionPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesman_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesman_P_ID
            // 
            this.salesman_P_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.salesman_P_ID.Location = new System.Drawing.Point(258, 118);
            this.salesman_P_ID.Name = "salesman_P_ID";
            this.salesman_P_ID.Size = new System.Drawing.Size(190, 20);
            this.salesman_P_ID.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 30;
            // 
            // transactionTotalAmount
            // 
            this.transactionTotalAmount.BackColor = System.Drawing.Color.Gray;
            this.transactionTotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionTotalAmount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTotalAmount.ForeColor = System.Drawing.Color.White;
            this.transactionTotalAmount.Location = new System.Drawing.Point(192, 449);
            this.transactionTotalAmount.Name = "transactionTotalAmount";
            this.transactionTotalAmount.Size = new System.Drawing.Size(235, 33);
            this.transactionTotalAmount.TabIndex = 29;
            this.transactionTotalAmount.Text = "Total Amount";
            this.transactionTotalAmount.UseVisualStyleBackColor = false;
            // 
            // salesman_gridview
            // 
            this.salesman_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesman_gridview.Location = new System.Drawing.Point(163, 158);
            this.salesman_gridview.Name = "salesman_gridview";
            this.salesman_gridview.Size = new System.Drawing.Size(586, 277);
            this.salesman_gridview.TabIndex = 28;
            // 
            // salesman_quantity
            // 
            this.salesman_quantity.Location = new System.Drawing.Point(529, 115);
            this.salesman_quantity.Name = "salesman_quantity";
            this.salesman_quantity.Size = new System.Drawing.Size(192, 20);
            this.salesman_quantity.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantity :";
            // 
            // transactionAdd
            // 
            this.transactionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.transactionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionAdd.ForeColor = System.Drawing.Color.White;
            this.transactionAdd.Location = new System.Drawing.Point(15, 81);
            this.transactionAdd.Name = "transactionAdd";
            this.transactionAdd.Size = new System.Drawing.Size(124, 39);
            this.transactionAdd.TabIndex = 25;
            this.transactionAdd.Text = "Add";
            this.transactionAdd.UseVisualStyleBackColor = false;
            this.transactionAdd.Click += new System.EventHandler(this.transactionAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Product ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 74);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.member_bttn);
            this.panel2.Controls.Add(this.transactionDelete);
            this.panel2.Controls.Add(this.transactionSave);
            this.panel2.Controls.Add(this.transactionPrint);
            this.panel2.Controls.Add(this.transactionAdd);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 509);
            this.panel2.TabIndex = 36;
            // 
            // member_bttn
            // 
            this.member_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.member_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member_bttn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_bttn.ForeColor = System.Drawing.Color.White;
            this.member_bttn.Location = new System.Drawing.Point(16, 348);
            this.member_bttn.Name = "member_bttn";
            this.member_bttn.Size = new System.Drawing.Size(129, 39);
            this.member_bttn.TabIndex = 26;
            this.member_bttn.Text = "Member";
            this.member_bttn.UseVisualStyleBackColor = false;
            this.member_bttn.Click += new System.EventHandler(this.member_bttn_Click);
            // 
            // transactionDelete
            // 
            this.transactionDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.transactionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDelete.ForeColor = System.Drawing.Color.White;
            this.transactionDelete.Location = new System.Drawing.Point(13, 159);
            this.transactionDelete.Name = "transactionDelete";
            this.transactionDelete.Size = new System.Drawing.Size(132, 39);
            this.transactionDelete.TabIndex = 17;
            this.transactionDelete.Text = "Delete";
            this.transactionDelete.UseVisualStyleBackColor = false;
            // 
            // transactionSave
            // 
            this.transactionSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.transactionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionSave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionSave.ForeColor = System.Drawing.Color.White;
            this.transactionSave.Location = new System.Drawing.Point(12, 216);
            this.transactionSave.Name = "transactionSave";
            this.transactionSave.Size = new System.Drawing.Size(132, 39);
            this.transactionSave.TabIndex = 10;
            this.transactionSave.Text = "Save";
            this.transactionSave.UseVisualStyleBackColor = false;
            // 
            // transactionPrint
            // 
            this.transactionPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(128)))));
            this.transactionPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionPrint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionPrint.ForeColor = System.Drawing.Color.White;
            this.transactionPrint.Location = new System.Drawing.Point(12, 440);
            this.transactionPrint.Name = "transactionPrint";
            this.transactionPrint.Size = new System.Drawing.Size(132, 39);
            this.transactionPrint.TabIndex = 12;
            this.transactionPrint.Text = "Print";
            this.transactionPrint.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 53);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(707, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(21, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sellsman View";
            // 
            // Salesman_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(748, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.salesman_P_ID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.transactionTotalAmount);
            this.Controls.Add(this.salesman_gridview);
            this.Controls.Add(this.salesman_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salesman_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman_View";
            ((System.ComponentModel.ISupportInitialize)(this.salesman_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox salesman_P_ID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button transactionTotalAmount;
        private System.Windows.Forms.DataGridView salesman_gridview;
        private System.Windows.Forms.TextBox salesman_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button transactionAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button transactionDelete;
        private System.Windows.Forms.Button transactionSave;
        private System.Windows.Forms.Button transactionPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button member_bttn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}