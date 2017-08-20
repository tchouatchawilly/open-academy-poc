namespace GestionBiblio.IHM
{
    partial class Exemplaire
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
            this.btnenreg = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.btnanul = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtlib = new System.Windows.Forms.TextBox();
            this.cbcod = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnenreg, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnmod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnsup, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnanul, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtnum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtlib, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbcod, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero exemplaire:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle exemplaire:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code livre:";
            // 
            // btnenreg
            // 
            this.btnenreg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnenreg.Location = new System.Drawing.Point(386, 3);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(75, 19);
            this.btnenreg.TabIndex = 3;
            this.btnenreg.Text = "Ajouter";
            this.btnenreg.UseVisualStyleBackColor = true;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // btnmod
            // 
            this.btnmod.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmod.Location = new System.Drawing.Point(386, 28);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 19);
            this.btnmod.TabIndex = 4;
            this.btnmod.Text = "Modifier";
            this.btnmod.UseVisualStyleBackColor = true;
            // 
            // btnsup
            // 
            this.btnsup.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsup.Location = new System.Drawing.Point(386, 53);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(75, 19);
            this.btnsup.TabIndex = 5;
            this.btnsup.Text = "Supprimer";
            this.btnsup.UseVisualStyleBackColor = true;
            // 
            // btnanul
            // 
            this.btnanul.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnanul.Location = new System.Drawing.Point(386, 78);
            this.btnanul.Name = "btnanul";
            this.btnanul.Size = new System.Drawing.Size(75, 19);
            this.btnanul.TabIndex = 6;
            this.btnanul.Text = "Annuler";
            this.btnanul.UseVisualStyleBackColor = true;
            // 
            // txtnum
            // 
            this.txtnum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtnum.Location = new System.Drawing.Point(157, 3);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(148, 20);
            this.txtnum.TabIndex = 7;
            // 
            // txtlib
            // 
            this.txtlib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtlib.Location = new System.Drawing.Point(157, 28);
            this.txtlib.Name = "txtlib";
            this.txtlib.Size = new System.Drawing.Size(148, 20);
            this.txtlib.TabIndex = 8;
            // 
            // cbcod
            // 
            this.cbcod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbcod.FormattingEnabled = true;
            this.cbcod.Location = new System.Drawing.Point(157, 53);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(148, 21);
            this.cbcod.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(464, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des exemplaires";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Libelle,
            this.Code});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero exemplaire";
            this.Numero.Name = "Numero";
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle exemplaire";
            this.Libelle.Name = "Libelle";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code livre";
            this.Code.Name = "Code";
            // 
            // Exemplaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Exemplaire";
            this.Text = "Exemplaire";
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
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button btnanul;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtlib;
        private System.Windows.Forms.ComboBox cbcod;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;


    }
}