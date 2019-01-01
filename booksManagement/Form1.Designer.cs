namespace booksManagement
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
            this.txtResultPrint = new System.Windows.Forms.TextBox();
            this.txtDelPrint = new System.Windows.Forms.TextBox();
            this.txtInsertPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDel = new System.Windows.Forms.TextBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultPrint
            // 
            this.txtResultPrint.Location = new System.Drawing.Point(113, 324);
            this.txtResultPrint.Multiline = true;
            this.txtResultPrint.Name = "txtResultPrint";
            this.txtResultPrint.Size = new System.Drawing.Size(287, 190);
            this.txtResultPrint.TabIndex = 7;
            // 
            // txtDelPrint
            // 
            this.txtDelPrint.AllowDrop = true;
            this.txtDelPrint.Location = new System.Drawing.Point(1074, 179);
            this.txtDelPrint.Multiline = true;
            this.txtDelPrint.Name = "txtDelPrint";
            this.txtDelPrint.ReadOnly = true;
            this.txtDelPrint.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDelPrint.Size = new System.Drawing.Size(375, 522);
            this.txtDelPrint.TabIndex = 32;
            // 
            // txtInsertPrint
            // 
            this.txtInsertPrint.Location = new System.Drawing.Point(516, 179);
            this.txtInsertPrint.Multiline = true;
            this.txtInsertPrint.Name = "txtInsertPrint";
            this.txtInsertPrint.ReadOnly = true;
            this.txtInsertPrint.Size = new System.Drawing.Size(933, 522);
            this.txtInsertPrint.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "InsertResult";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1071, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "DelResult";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 266);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            this.txtSearch.TabIndex = 41;
            // 
            // txtDel
            // 
            this.txtDel.Location = new System.Drawing.Point(737, 88);
            this.txtDel.Name = "txtDel";
            this.txtDel.Size = new System.Drawing.Size(100, 25);
            this.txtDel.TabIndex = 40;
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(518, 90);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 25);
            this.txtInsert.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(221, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(843, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(627, 90);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 36;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 694);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtDel);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelPrint);
            this.Controls.Add(this.txtInsertPrint);
            this.Controls.Add(this.txtResultPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultPrint;
        private System.Windows.Forms.TextBox txtDelPrint;
        private System.Windows.Forms.TextBox txtInsertPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDel;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
    }
}

