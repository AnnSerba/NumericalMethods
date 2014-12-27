namespace ЧисленныеМетодыWindowsForms
{
    partial class МетодПрогонкиWindowsForm
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
            this.buttonЗакрыть = new System.Windows.Forms.Button();
            this.buttonПеререшать = new System.Windows.Forms.Button();
            this.buttonУменьшитьРазмерМатрицы = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBi = new System.Windows.Forms.GroupBox();
            this.dataGridViewBi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAij = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewОтвет = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Betta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gamma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonУвеличитьРазмерМатрицы = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAij)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewОтвет)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonЗакрыть
            // 
            this.buttonЗакрыть.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonЗакрыть.Location = new System.Drawing.Point(527, 315);
            this.buttonЗакрыть.Name = "buttonЗакрыть";
            this.buttonЗакрыть.Size = new System.Drawing.Size(125, 23);
            this.buttonЗакрыть.TabIndex = 3;
            this.buttonЗакрыть.Text = "Закрыть";
            this.buttonЗакрыть.UseVisualStyleBackColor = true;
            this.buttonЗакрыть.Click += new System.EventHandler(this.buttonЗакрыть_Click);
            // 
            // buttonПеререшать
            // 
            this.buttonПеререшать.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonПеререшать.Location = new System.Drawing.Point(3, 96);
            this.buttonПеререшать.Name = "buttonПеререшать";
            this.buttonПеререшать.Size = new System.Drawing.Size(119, 23);
            this.buttonПеререшать.TabIndex = 2;
            this.buttonПеререшать.Text = "Перерешать";
            this.buttonПеререшать.UseVisualStyleBackColor = true;
            this.buttonПеререшать.Click += new System.EventHandler(this.buttonПеререшать_Click);
            // 
            // buttonУменьшитьРазмерМатрицы
            // 
            this.buttonУменьшитьРазмерМатрицы.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУменьшитьРазмерМатрицы.Location = new System.Drawing.Point(3, 56);
            this.buttonУменьшитьРазмерМатрицы.Name = "buttonУменьшитьРазмерМатрицы";
            this.buttonУменьшитьРазмерМатрицы.Size = new System.Drawing.Size(119, 40);
            this.buttonУменьшитьРазмерМатрицы.TabIndex = 1;
            this.buttonУменьшитьРазмерМатрицы.Text = "Уменьшить размер матрицы";
            this.buttonУменьшитьРазмерМатрицы.UseVisualStyleBackColor = true;
            this.buttonУменьшитьРазмерМатрицы.Click += new System.EventHandler(this.buttonУменьшитьРазмерМатрицы_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.03767F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.96234F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonЗакрыть, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 341);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(518, 164);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // groupBoxBi
            // 
            this.groupBoxBi.Controls.Add(this.dataGridViewBi);
            this.groupBoxBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBi.Location = new System.Drawing.Point(397, 3);
            this.groupBoxBi.Name = "groupBoxBi";
            this.groupBoxBi.Size = new System.Drawing.Size(118, 158);
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
            this.dataGridViewBi.Size = new System.Drawing.Size(112, 139);
            this.dataGridViewBi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAij);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 158);
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
            this.dataGridViewAij.Size = new System.Drawing.Size(382, 139);
            this.dataGridViewAij.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewОтвет);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 165);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение";
            // 
            // dataGridViewОтвет
            // 
            this.dataGridViewОтвет.AllowUserToAddRows = false;
            this.dataGridViewОтвет.AllowUserToDeleteRows = false;
            this.dataGridViewОтвет.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewОтвет.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewОтвет.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Alpha,
            this.Betta,
            this.Gamma,
            this.Delta,
            this.P,
            this.Q,
            this.X});
            this.dataGridViewОтвет.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewОтвет.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewОтвет.Name = "dataGridViewОтвет";
            this.dataGridViewОтвет.ReadOnly = true;
            this.dataGridViewОтвет.RowHeadersVisible = false;
            this.dataGridViewОтвет.Size = new System.Drawing.Size(512, 146);
            this.dataGridViewОтвет.TabIndex = 0;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // Alpha
            // 
            this.Alpha.HeaderText = "Alpha[i]";
            this.Alpha.Name = "Alpha";
            this.Alpha.ReadOnly = true;
            // 
            // Betta
            // 
            this.Betta.HeaderText = "Betta[i]";
            this.Betta.Name = "Betta";
            this.Betta.ReadOnly = true;
            // 
            // Gamma
            // 
            this.Gamma.HeaderText = "Gamma[i]";
            this.Gamma.Name = "Gamma";
            this.Gamma.ReadOnly = true;
            // 
            // Delta
            // 
            this.Delta.HeaderText = "Delta[i]";
            this.Delta.Name = "Delta";
            this.Delta.ReadOnly = true;
            // 
            // P
            // 
            this.P.HeaderText = "P[i]";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            // 
            // Q
            // 
            this.Q.HeaderText = "Q[i]";
            this.Q.Name = "Q";
            this.Q.ReadOnly = true;
            // 
            // X
            // 
            this.X.HeaderText = "X[i]";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonПеререшать);
            this.groupBox3.Controls.Add(this.buttonУменьшитьРазмерМатрицы);
            this.groupBox3.Controls.Add(this.buttonУвеличитьРазмерМатрицы);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(527, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // buttonУвеличитьРазмерМатрицы
            // 
            this.buttonУвеличитьРазмерМатрицы.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУвеличитьРазмерМатрицы.Location = new System.Drawing.Point(3, 16);
            this.buttonУвеличитьРазмерМатрицы.Name = "buttonУвеличитьРазмерМатрицы";
            this.buttonУвеличитьРазмерМатрицы.Size = new System.Drawing.Size(119, 40);
            this.buttonУвеличитьРазмерМатрицы.TabIndex = 0;
            this.buttonУвеличитьРазмерМатрицы.Text = "Увеличить размер матрицы";
            this.buttonУвеличитьРазмерМатрицы.UseVisualStyleBackColor = true;
            this.buttonУвеличитьРазмерМатрицы.Click += new System.EventHandler(this.buttonУвеличитьРазмерМатрицы_Click);
            // 
            // МетодПрогонкиWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "МетодПрогонкиWindowsForm";
            this.Text = "МетодПрогонкиWindowsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAij)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewОтвет)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonЗакрыть;
        private System.Windows.Forms.Button buttonПеререшать;
        private System.Windows.Forms.Button buttonУменьшитьРазмерМатрицы;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonУвеличитьРазмерМатрицы;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBoxBi;
        private System.Windows.Forms.DataGridView dataGridViewBi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAij;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewОтвет;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Betta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gamma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delta;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;

    }
}