namespace ЧисленныеМетодыWindowsForms
{
    partial class МетодыПростойИтерацииИЗейделяWindowsForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewXkj = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewАльфа = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewБетта = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBi = new System.Windows.Forms.GroupBox();
            this.dataGridViewBi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAij = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTochnost = new System.Windows.Forms.GroupBox();
            this.textBoxТочность = new System.Windows.Forms.TextBox();
            this.buttonЗакрыть = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonПеререшать = new System.Windows.Forms.Button();
            this.buttonУменьшитьРазмерМатрицы = new System.Windows.Forms.Button();
            this.buttonУвеличитьРазмерМатрицы = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXkj)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewАльфа)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewБетта)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAij)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxTochnost.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 452);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.83857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.3722F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.56502F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(591, 446);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewXkj);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Решение[k][j]";
            // 
            // dataGridViewXkj
            // 
            this.dataGridViewXkj.AllowUserToAddRows = false;
            this.dataGridViewXkj.AllowUserToDeleteRows = false;
            this.dataGridViewXkj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXkj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXkj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXkj.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewXkj.Name = "dataGridViewXkj";
            this.dataGridViewXkj.ReadOnly = true;
            this.dataGridViewXkj.RowHeadersVisible = false;
            this.dataGridViewXkj.Size = new System.Drawing.Size(579, 148);
            this.dataGridViewXkj.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.41026F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58974F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(585, 125);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewАльфа);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Альфа[i][j]";
            // 
            // dataGridViewАльфа
            // 
            this.dataGridViewАльфа.AllowUserToAddRows = false;
            this.dataGridViewАльфа.AllowUserToDeleteRows = false;
            this.dataGridViewАльфа.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewАльфа.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewАльфа.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewАльфа.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewАльфа.Name = "dataGridViewАльфа";
            this.dataGridViewАльфа.ReadOnly = true;
            this.dataGridViewАльфа.RowHeadersVisible = false;
            this.dataGridViewАльфа.Size = new System.Drawing.Size(435, 100);
            this.dataGridViewАльфа.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewБетта);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(450, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 119);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Бетта[i]";
            // 
            // dataGridViewБетта
            // 
            this.dataGridViewБетта.AllowUserToAddRows = false;
            this.dataGridViewБетта.AllowUserToDeleteRows = false;
            this.dataGridViewБетта.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewБетта.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewБетта.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewБетта.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewБетта.Name = "dataGridViewБетта";
            this.dataGridViewБетта.ReadOnly = true;
            this.dataGridViewБетта.RowHeadersVisible = false;
            this.dataGridViewБетта.Size = new System.Drawing.Size(126, 100);
            this.dataGridViewБетта.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.23932F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.76068F));
            this.tableLayoutPanel5.Controls.Add(this.groupBoxBi, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(585, 136);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // groupBoxBi
            // 
            this.groupBoxBi.Controls.Add(this.dataGridViewBi);
            this.groupBoxBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBi.Location = new System.Drawing.Point(449, 3);
            this.groupBoxBi.Name = "groupBoxBi";
            this.groupBoxBi.Size = new System.Drawing.Size(133, 130);
            this.groupBoxBi.TabIndex = 2;
            this.groupBoxBi.TabStop = false;
            this.groupBoxBi.Text = "Столбец свободных членов B[i]";
            // 
            // dataGridViewBi
            // 
            this.dataGridViewBi.AllowUserToAddRows = false;
            this.dataGridViewBi.AllowUserToDeleteRows = false;
            this.dataGridViewBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBi.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewBi.Name = "dataGridViewBi";
            this.dataGridViewBi.RowHeadersVisible = false;
            this.dataGridViewBi.Size = new System.Drawing.Size(127, 111);
            this.dataGridViewBi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAij);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица A[i][j]";
            // 
            // dataGridViewAij
            // 
            this.dataGridViewAij.AllowUserToAddRows = false;
            this.dataGridViewAij.AllowUserToDeleteRows = false;
            this.dataGridViewAij.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAij.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAij.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAij.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAij.Name = "dataGridViewAij";
            this.dataGridViewAij.RowHeadersVisible = false;
            this.dataGridViewAij.Size = new System.Drawing.Size(434, 111);
            this.dataGridViewAij.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxTochnost, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonЗакрыть, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelError, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(600, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.31783F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.68217F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(143, 446);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBoxTochnost
            // 
            this.groupBoxTochnost.Controls.Add(this.textBoxТочность);
            this.groupBoxTochnost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTochnost.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTochnost.Name = "groupBoxTochnost";
            this.groupBoxTochnost.Size = new System.Drawing.Size(137, 64);
            this.groupBoxTochnost.TabIndex = 0;
            this.groupBoxTochnost.TabStop = false;
            this.groupBoxTochnost.Text = "Точность";
            // 
            // textBoxТочность
            // 
            this.textBoxТочность.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxТочность.Location = new System.Drawing.Point(3, 16);
            this.textBoxТочность.Name = "textBoxТочность";
            this.textBoxТочность.Size = new System.Drawing.Size(131, 20);
            this.textBoxТочность.TabIndex = 0;
            this.textBoxТочность.Text = "0,001";
            // 
            // buttonЗакрыть
            // 
            this.buttonЗакрыть.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonЗакрыть.Location = new System.Drawing.Point(3, 402);
            this.buttonЗакрыть.Name = "buttonЗакрыть";
            this.buttonЗакрыть.Size = new System.Drawing.Size(137, 41);
            this.buttonЗакрыть.TabIndex = 2;
            this.buttonЗакрыть.Text = "Закрыть";
            this.buttonЗакрыть.UseVisualStyleBackColor = true;
            this.buttonЗакрыть.Click += new System.EventHandler(this.buttonЗакрыть_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonПеререшать);
            this.groupBox4.Controls.Add(this.buttonУменьшитьРазмерМатрицы);
            this.groupBox4.Controls.Add(this.buttonУвеличитьРазмерМатрицы);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 254);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // buttonПеререшать
            // 
            this.buttonПеререшать.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonПеререшать.Location = new System.Drawing.Point(3, 108);
            this.buttonПеререшать.Name = "buttonПеререшать";
            this.buttonПеререшать.Size = new System.Drawing.Size(131, 43);
            this.buttonПеререшать.TabIndex = 2;
            this.buttonПеререшать.Text = "Перерешать";
            this.buttonПеререшать.UseVisualStyleBackColor = true;
            this.buttonПеререшать.Click += new System.EventHandler(this.buttonПеререшать_Click);
            // 
            // buttonУменьшитьРазмерМатрицы
            // 
            this.buttonУменьшитьРазмерМатрицы.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУменьшитьРазмерМатрицы.Location = new System.Drawing.Point(3, 63);
            this.buttonУменьшитьРазмерМатрицы.Name = "buttonУменьшитьРазмерМатрицы";
            this.buttonУменьшитьРазмерМатрицы.Size = new System.Drawing.Size(131, 45);
            this.buttonУменьшитьРазмерМатрицы.TabIndex = 1;
            this.buttonУменьшитьРазмерМатрицы.Text = "Уменьшить размер матрицы";
            this.buttonУменьшитьРазмерМатрицы.UseVisualStyleBackColor = true;
            this.buttonУменьшитьРазмерМатрицы.Click += new System.EventHandler(this.buttonУменьшитьРазмерМатрицы_Click);
            // 
            // buttonУвеличитьРазмерМатрицы
            // 
            this.buttonУвеличитьРазмерМатрицы.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУвеличитьРазмерМатрицы.Location = new System.Drawing.Point(3, 16);
            this.buttonУвеличитьРазмерМатрицы.Name = "buttonУвеличитьРазмерМатрицы";
            this.buttonУвеличитьРазмерМатрицы.Size = new System.Drawing.Size(131, 47);
            this.buttonУвеличитьРазмерМатрицы.TabIndex = 0;
            this.buttonУвеличитьРазмерМатрицы.Text = "Увеличить размер матрицы";
            this.buttonУвеличитьРазмерМатрицы.UseVisualStyleBackColor = true;
            this.buttonУвеличитьРазмерМатрицы.Click += new System.EventHandler(this.buttonУвеличитьРазмерМатрицы_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.Location = new System.Drawing.Point(3, 330);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(137, 69);
            this.labelError.TabIndex = 4;
            // 
            // МетодыПростойИтерацииИЗейделяWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "МетодыПростойИтерацииИЗейделяWindowsForm";
            this.Text = "МетодыПростойИтерацииИЗейделяWindowsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXkj)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewАльфа)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewБетта)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAij)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxTochnost.ResumeLayout(false);
            this.groupBoxTochnost.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewXkj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxTochnost;
        private System.Windows.Forms.TextBox textBoxТочность;
        private System.Windows.Forms.Button buttonЗакрыть;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonПеререшать;
        private System.Windows.Forms.Button buttonУменьшитьРазмерМатрицы;
        private System.Windows.Forms.Button buttonУвеличитьРазмерМатрицы;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewАльфа;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewБетта;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBoxBi;
        private System.Windows.Forms.DataGridView dataGridViewBi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAij;
    }
}