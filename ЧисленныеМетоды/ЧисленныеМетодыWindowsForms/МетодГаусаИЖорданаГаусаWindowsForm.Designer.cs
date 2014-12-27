namespace ЧисленныеМетодыWindowsForms
{
    partial class МетодГаусаИЖорданаГаусаWindowsForm
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonЗакрыть = new System.Windows.Forms.Button();
            this.buttonПересчитать = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxПромежуточныеРезультаты = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonУменьшитьМатрицу = new System.Windows.Forms.Button();
            this.buttonУвеличитьМатрицу = new System.Windows.Forms.Button();
            this.groupBoxПромежуточныеРезультаты = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAkij = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBki = new System.Windows.Forms.DataGridView();
            this.groupBoxРешение = new System.Windows.Forms.GroupBox();
            this.dataGridViewXj = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxПромежуточныеРезультаты.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkij)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBki)).BeginInit();
            this.groupBoxРешение.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXj)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonЗакрыть, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonПересчитать, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 272);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(133, 69);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buttonЗакрыть
            // 
            this.buttonЗакрыть.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonЗакрыть.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonЗакрыть.Location = new System.Drawing.Point(3, 37);
            this.buttonЗакрыть.Name = "buttonЗакрыть";
            this.buttonЗакрыть.Size = new System.Drawing.Size(127, 29);
            this.buttonЗакрыть.TabIndex = 1;
            this.buttonЗакрыть.Text = "Закрыть";
            this.buttonЗакрыть.UseVisualStyleBackColor = true;
            this.buttonЗакрыть.Click += new System.EventHandler(this.buttonЗакрыть_Click);
            // 
            // buttonПересчитать
            // 
            this.buttonПересчитать.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonПересчитать.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonПересчитать.Location = new System.Drawing.Point(3, 3);
            this.buttonПересчитать.Name = "buttonПересчитать";
            this.buttonПересчитать.Size = new System.Drawing.Size(127, 28);
            this.buttonПересчитать.TabIndex = 0;
            this.buttonПересчитать.Text = "Пересчитать";
            this.buttonПересчитать.UseVisualStyleBackColor = true;
            this.buttonПересчитать.Click += new System.EventHandler(this.buttonПересчитать_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.65789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.3421F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxПромежуточныеРезультаты, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxРешение, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.25312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.74688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 344);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxПромежуточныеРезультаты, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.23194F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.76806F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(133, 263);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // listBoxПромежуточныеРезультаты
            // 
            this.listBoxПромежуточныеРезультаты.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxПромежуточныеРезультаты.FormattingEnabled = true;
            this.listBoxПромежуточныеРезультаты.Items.AddRange(new object[] {
            "Исходная матрица"});
            this.listBoxПромежуточныеРезультаты.Location = new System.Drawing.Point(3, 3);
            this.listBoxПромежуточныеРезультаты.Name = "listBoxПромежуточныеРезультаты";
            this.listBoxПромежуточныеРезультаты.Size = new System.Drawing.Size(127, 134);
            this.listBoxПромежуточныеРезультаты.TabIndex = 2;
            this.listBoxПромежуточныеРезультаты.Click += new System.EventHandler(this.listBoxПромежуточныеРезультаты_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonУменьшитьМатрицу, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.buttonУвеличитьМатрицу, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(127, 117);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // buttonУменьшитьМатрицу
            // 
            this.buttonУменьшитьМатрицу.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonУменьшитьМатрицу.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУменьшитьМатрицу.Location = new System.Drawing.Point(3, 61);
            this.buttonУменьшитьМатрицу.Name = "buttonУменьшитьМатрицу";
            this.buttonУменьшитьМатрицу.Size = new System.Drawing.Size(121, 53);
            this.buttonУменьшитьМатрицу.TabIndex = 2;
            this.buttonУменьшитьМатрицу.Text = "Уменьшить матрицу";
            this.buttonУменьшитьМатрицу.UseVisualStyleBackColor = true;
            this.buttonУменьшитьМатрицу.Click += new System.EventHandler(this.buttonУменьшитьМатрицу_Click);
            // 
            // buttonУвеличитьМатрицу
            // 
            this.buttonУвеличитьМатрицу.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonУвеличитьМатрицу.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУвеличитьМатрицу.Location = new System.Drawing.Point(3, 3);
            this.buttonУвеличитьМатрицу.Name = "buttonУвеличитьМатрицу";
            this.buttonУвеличитьМатрицу.Size = new System.Drawing.Size(121, 52);
            this.buttonУвеличитьМатрицу.TabIndex = 1;
            this.buttonУвеличитьМатрицу.Text = "Увеличить матрицу";
            this.buttonУвеличитьМатрицу.UseVisualStyleBackColor = true;
            this.buttonУвеличитьМатрицу.Click += new System.EventHandler(this.buttonУвеличитьМатрицу_Click);
            // 
            // groupBoxПромежуточныеРезультаты
            // 
            this.groupBoxПромежуточныеРезультаты.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxПромежуточныеРезультаты.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxПромежуточныеРезультаты.Location = new System.Drawing.Point(142, 3);
            this.groupBoxПромежуточныеРезультаты.Name = "groupBoxПромежуточныеРезультаты";
            this.groupBoxПромежуточныеРезультаты.Size = new System.Drawing.Size(528, 263);
            this.groupBoxПромежуточныеРезультаты.TabIndex = 10;
            this.groupBoxПромежуточныеРезультаты.TabStop = false;
            this.groupBoxПромежуточныеРезультаты.Text = "Промежуточные результаты";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.26437F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73563F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(522, 244);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAkij);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aij";
            // 
            // dataGridViewAkij
            // 
            this.dataGridViewAkij.AllowUserToAddRows = false;
            this.dataGridViewAkij.AllowUserToDeleteRows = false;
            this.dataGridViewAkij.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAkij.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkij.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAkij.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAkij.Name = "dataGridViewAkij";
            this.dataGridViewAkij.Size = new System.Drawing.Size(360, 219);
            this.dataGridViewAkij.TabIndex = 1;
            this.dataGridViewAkij.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewAkij_CellBeginEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewBki);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(375, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bi";
            // 
            // dataGridViewBki
            // 
            this.dataGridViewBki.AllowUserToAddRows = false;
            this.dataGridViewBki.AllowUserToDeleteRows = false;
            this.dataGridViewBki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBki.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewBki.Name = "dataGridViewBki";
            this.dataGridViewBki.Size = new System.Drawing.Size(138, 219);
            this.dataGridViewBki.TabIndex = 1;
            this.dataGridViewBki.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewAkij_CellBeginEdit);
            // 
            // groupBoxРешение
            // 
            this.groupBoxРешение.Controls.Add(this.dataGridViewXj);
            this.groupBoxРешение.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxРешение.Location = new System.Drawing.Point(142, 272);
            this.groupBoxРешение.Name = "groupBoxРешение";
            this.groupBoxРешение.Size = new System.Drawing.Size(528, 69);
            this.groupBoxРешение.TabIndex = 11;
            this.groupBoxРешение.TabStop = false;
            this.groupBoxРешение.Text = "Решение";
            // 
            // dataGridViewXj
            // 
            this.dataGridViewXj.AllowUserToAddRows = false;
            this.dataGridViewXj.AllowUserToDeleteRows = false;
            this.dataGridViewXj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXj.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewXj.Name = "dataGridViewXj";
            this.dataGridViewXj.ReadOnly = true;
            this.dataGridViewXj.Size = new System.Drawing.Size(522, 50);
            this.dataGridViewXj.TabIndex = 0;
            // 
            // МетодГаусаИЖорданаГаусаWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "МетодГаусаИЖорданаГаусаWindowsForm";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxПромежуточныеРезультаты.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkij)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBki)).EndInit();
            this.groupBoxРешение.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonЗакрыть;
        private System.Windows.Forms.Button buttonПересчитать;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxПромежуточныеРезультаты;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonУменьшитьМатрицу;
        private System.Windows.Forms.Button buttonУвеличитьМатрицу;
        private System.Windows.Forms.GroupBox groupBoxПромежуточныеРезультаты;
        private System.Windows.Forms.GroupBox groupBoxРешение;
        private System.Windows.Forms.DataGridView dataGridViewXj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAkij;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewBki;
    }
}