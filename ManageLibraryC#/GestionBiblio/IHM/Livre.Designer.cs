namespace GestionBiblio.IHM
{
    partial class Livre
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodl = new System.Windows.Forms.TextBox();
            this.txtnol = new System.Windows.Forms.TextBox();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.btnanul = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            this.dtpdatl = new System.Windows.Forms.DateTimePicker();
            this.cbcodth = new System.Windows.Forms.ComboBox();
            this.cbcoded = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codeth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codeedit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtcodl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnol, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnmod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnsup, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnanul, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnajout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpdatl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbcodth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbcoded, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code livre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom livre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date apparition:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code theme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code editeur:";
            // 
            // txtcodl
            // 
            this.txtcodl.Location = new System.Drawing.Point(218, 3);
            this.txtcodl.Name = "txtcodl";
            this.txtcodl.Size = new System.Drawing.Size(100, 20);
            this.txtcodl.TabIndex = 5;
            // 
            // txtnol
            // 
            this.txtnol.Location = new System.Drawing.Point(218, 23);
            this.txtnol.Name = "txtnol";
            this.txtnol.Size = new System.Drawing.Size(100, 20);
            this.txtnol.TabIndex = 6;
            // 
            // btnmod
            // 
            this.btnmod.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmod.Location = new System.Drawing.Point(567, 23);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 14);
            this.btnmod.TabIndex = 11;
            this.btnmod.Text = "button2";
            this.btnmod.UseVisualStyleBackColor = true;
            // 
            // btnsup
            // 
            this.btnsup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsup.Location = new System.Drawing.Point(567, 43);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(75, 14);
            this.btnsup.TabIndex = 12;
            this.btnsup.Text = "button3";
            this.btnsup.UseVisualStyleBackColor = true;
            // 
            // btnanul
            // 
            this.btnanul.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnanul.Location = new System.Drawing.Point(567, 63);
            this.btnanul.Name = "btnanul";
            this.btnanul.Size = new System.Drawing.Size(75, 14);
            this.btnanul.TabIndex = 13;
            this.btnanul.Text = "button4";
            this.btnanul.UseVisualStyleBackColor = true;
            // 
            // btnajout
            // 
            this.btnajout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnajout.Location = new System.Drawing.Point(567, 3);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(75, 14);
            this.btnajout.TabIndex = 10;
            this.btnajout.Text = "button1";
            this.btnajout.UseVisualStyleBackColor = true;
            // 
            // dtpdatl
            // 
            this.dtpdatl.Location = new System.Drawing.Point(218, 43);
            this.dtpdatl.Name = "dtpdatl";
            this.dtpdatl.Size = new System.Drawing.Size(200, 20);
            this.dtpdatl.TabIndex = 14;
            // 
            // cbcodth
            // 
            this.cbcodth.FormattingEnabled = true;
            this.cbcodth.Location = new System.Drawing.Point(218, 63);
            this.cbcodth.Name = "cbcodth";
            this.cbcodth.Size = new System.Drawing.Size(121, 21);
            this.cbcodth.TabIndex = 15;
            // 
            // cbcoded
            // 
            this.cbcoded.FormattingEnabled = true;
            this.cbcoded.Location = new System.Drawing.Point(218, 83);
            this.cbcoded.Name = "cbcoded";
            this.cbcoded.Size = new System.Drawing.Size(121, 21);
            this.cbcoded.TabIndex = 16;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(645, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des livres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nom,
            this.Date,
            this.Codeth,
            this.Codeedit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 78);
            this.dataGridView1.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code livre";
            this.Code.Name = "Code";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom livre";
            this.Nom.Name = "Nom";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date apparition";
            this.Date.Name = "Date";
            // 
            // Codeth
            // 
            this.Codeth.HeaderText = "Code theme";
            this.Codeth.Name = "Codeth";
            // 
            // Codeedit
            // 
            this.Codeedit.HeaderText = "Code editeur";
            this.Codeedit.Name = "Codeedit";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 203);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(645, 3);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Livre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Livre";
            this.Text = "Livre";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodl;
        private System.Windows.Forms.TextBox txtnol;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button btnanul;
        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DateTimePicker dtpdatl;
        private System.Windows.Forms.ComboBox cbcodth;
        private System.Windows.Forms.ComboBox cbcoded;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codeth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codeedit;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}