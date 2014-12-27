namespace ЧисленныеМетодыWindowsForms
{
    partial class ГлавноеМеню
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxМатрица = new System.Windows.Forms.GroupBox();
            this.dataGridViewAij = new System.Windows.Forms.DataGridView();
            this.Ai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ai2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBi = new System.Windows.Forms.DataGridView();
            this.Bi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxTochnost = new System.Windows.Forms.GroupBox();
            this.textBoxТочность = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonУменьшитьРазмерМатрицы = new System.Windows.Forms.Button();
            this.buttonУверичитьРазмерМатрицы = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxМетоды = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxПрямые = new System.Windows.Forms.GroupBox();
            this.checkedListBoxПрямые = new System.Windows.Forms.CheckedListBox();
            this.groupBoxИтерационные = new System.Windows.Forms.GroupBox();
            this.checkedListBoxИтерационные = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonРешить = new System.Windows.Forms.Button();
            this.buttonВыход = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxМатрица.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAij)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBi)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBoxTochnost.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxМетоды.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxПрямые.SuspendLayout();
            this.groupBoxИтерационные.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.21505F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.67742F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxМатрица, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 204);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxМатрица
            // 
            this.groupBoxМатрица.Controls.Add(this.dataGridViewAij);
            this.groupBoxМатрица.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxМатрица.Location = new System.Drawing.Point(3, 3);
            this.groupBoxМатрица.Name = "groupBoxМатрица";
            this.groupBoxМатрица.Size = new System.Drawing.Size(554, 198);
            this.groupBoxМатрица.TabIndex = 0;
            this.groupBoxМатрица.TabStop = false;
            this.groupBoxМатрица.Text = "Матрицу Aij";
            // 
            // dataGridViewAij
            // 
            this.dataGridViewAij.AllowUserToAddRows = false;
            this.dataGridViewAij.AllowUserToDeleteRows = false;
            this.dataGridViewAij.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAij.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAij.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ai1,
            this.Ai2});
            this.dataGridViewAij.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAij.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAij.Name = "dataGridViewAij";
            this.dataGridViewAij.RowHeadersVisible = false;
            this.dataGridViewAij.Size = new System.Drawing.Size(548, 179);
            this.dataGridViewAij.TabIndex = 0;
            // 
            // Ai1
            // 
            this.Ai1.HeaderText = "A[i][1]";
            this.Ai1.Name = "Ai1";
            // 
            // Ai2
            // 
            this.Ai2.HeaderText = "A[i][2]";
            this.Ai2.Name = "Ai2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewBi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(563, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Столбец свободных членов  Bi";
            // 
            // dataGridViewBi
            // 
            this.dataGridViewBi.AllowUserToAddRows = false;
            this.dataGridViewBi.AllowUserToDeleteRows = false;
            this.dataGridViewBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bi});
            this.dataGridViewBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBi.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewBi.Name = "dataGridViewBi";
            this.dataGridViewBi.ReadOnly = true;
            this.dataGridViewBi.RowHeadersVisible = false;
            this.dataGridViewBi.Size = new System.Drawing.Size(171, 179);
            this.dataGridViewBi.TabIndex = 0;
            // 
            // Bi
            // 
            this.Bi.HeaderText = "B[i]";
            this.Bi.Name = "Bi";
            this.Bi.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBoxTochnost, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(746, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(181, 198);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // groupBoxTochnost
            // 
            this.groupBoxTochnost.Controls.Add(this.textBoxТочность);
            this.groupBoxTochnost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTochnost.Location = new System.Drawing.Point(3, 156);
            this.groupBoxTochnost.Name = "groupBoxTochnost";
            this.groupBoxTochnost.Size = new System.Drawing.Size(175, 39);
            this.groupBoxTochnost.TabIndex = 3;
            this.groupBoxTochnost.TabStop = false;
            this.groupBoxTochnost.Text = "Точность";
            // 
            // textBoxТочность
            // 
            this.textBoxТочность.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxТочность.Location = new System.Drawing.Point(3, 16);
            this.textBoxТочность.Name = "textBoxТочность";
            this.textBoxТочность.Size = new System.Drawing.Size(169, 20);
            this.textBoxТочность.TabIndex = 0;
            this.textBoxТочность.Text = "0,001";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonУменьшитьРазмерМатрицы);
            this.groupBox2.Controls.Add(this.buttonУверичитьРазмерМатрицы);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение размеров матрицы";
            // 
            // buttonУменьшитьРазмерМатрицы
            // 
            this.buttonУменьшитьРазмерМатрицы.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУменьшитьРазмерМатрицы.Location = new System.Drawing.Point(3, 65);
            this.buttonУменьшитьРазмерМатрицы.Name = "buttonУменьшитьРазмерМатрицы";
            this.buttonУменьшитьРазмерМатрицы.Size = new System.Drawing.Size(169, 54);
            this.buttonУменьшитьРазмерМатрицы.TabIndex = 1;
            this.buttonУменьшитьРазмерМатрицы.Text = "Уменьшить размер матрицы";
            this.buttonУменьшитьРазмерМатрицы.UseVisualStyleBackColor = true;
            this.buttonУменьшитьРазмерМатрицы.Click += new System.EventHandler(this.buttonУменьшитьРазмерМатрицы_Click);
            // 
            // buttonУверичитьРазмерМатрицы
            // 
            this.buttonУверичитьРазмерМатрицы.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonУверичитьРазмерМатрицы.Location = new System.Drawing.Point(3, 16);
            this.buttonУверичитьРазмерМатрицы.Name = "buttonУверичитьРазмерМатрицы";
            this.buttonУверичитьРазмерМатрицы.Size = new System.Drawing.Size(169, 49);
            this.buttonУверичитьРазмерМатрицы.TabIndex = 0;
            this.buttonУверичитьРазмерМатрицы.Text = "Увеличить размер матрицы";
            this.buttonУверичитьРазмерМатрицы.UseVisualStyleBackColor = true;
            this.buttonУверичитьРазмерМатрицы.Click += new System.EventHandler(this.buttonУверичитьРазмерМатрицы_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxМетоды, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxМетоды
            // 
            this.groupBoxМетоды.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxМетоды.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxМетоды.Location = new System.Drawing.Point(3, 243);
            this.groupBoxМетоды.Name = "groupBoxМетоды";
            this.groupBoxМетоды.Size = new System.Drawing.Size(930, 166);
            this.groupBoxМетоды.TabIndex = 1;
            this.groupBoxМетоды.TabStop = false;
            this.groupBoxМетоды.Text = "Методы решения СЛАУ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.groupBoxПрямые, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxИтерационные, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(924, 147);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBoxПрямые
            // 
            this.groupBoxПрямые.Controls.Add(this.checkedListBoxПрямые);
            this.groupBoxПрямые.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxПрямые.Location = new System.Drawing.Point(3, 3);
            this.groupBoxПрямые.Name = "groupBoxПрямые";
            this.groupBoxПрямые.Size = new System.Drawing.Size(456, 141);
            this.groupBoxПрямые.TabIndex = 0;
            this.groupBoxПрямые.TabStop = false;
            this.groupBoxПрямые.Text = "Прямые";
            // 
            // checkedListBoxПрямые
            // 
            this.checkedListBoxПрямые.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxПрямые.FormattingEnabled = true;
            this.checkedListBoxПрямые.Items.AddRange(new object[] {
            "Метод Гаусса",
            "Метод Гаусса — Жордана",
            "Компактный метод Гусса. Схема Холецкого",
            "Метод прогонки"});
            this.checkedListBoxПрямые.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxПрямые.Name = "checkedListBoxПрямые";
            this.checkedListBoxПрямые.Size = new System.Drawing.Size(450, 122);
            this.checkedListBoxПрямые.TabIndex = 0;
            // 
            // groupBoxИтерационные
            // 
            this.groupBoxИтерационные.Controls.Add(this.checkedListBoxИтерационные);
            this.groupBoxИтерационные.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxИтерационные.Location = new System.Drawing.Point(465, 3);
            this.groupBoxИтерационные.Name = "groupBoxИтерационные";
            this.groupBoxИтерационные.Size = new System.Drawing.Size(456, 141);
            this.groupBoxИтерационные.TabIndex = 1;
            this.groupBoxИтерационные.TabStop = false;
            this.groupBoxИтерационные.Text = "Итерационные";
            // 
            // checkedListBoxИтерационные
            // 
            this.checkedListBoxИтерационные.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxИтерационные.FormattingEnabled = true;
            this.checkedListBoxИтерационные.Items.AddRange(new object[] {
            "Метод простой итерации",
            "Метод Зейделя"});
            this.checkedListBoxИтерационные.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxИтерационные.Name = "checkedListBoxИтерационные";
            this.checkedListBoxИтерационные.Size = new System.Drawing.Size(450, 122);
            this.checkedListBoxИтерационные.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.buttonРешить, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonВыход, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(930, 36);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonРешить
            // 
            this.buttonРешить.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonРешить.Location = new System.Drawing.Point(3, 3);
            this.buttonРешить.Name = "buttonРешить";
            this.buttonРешить.Size = new System.Drawing.Size(779, 30);
            this.buttonРешить.TabIndex = 0;
            this.buttonРешить.Text = "Решить";
            this.buttonРешить.UseVisualStyleBackColor = true;
            this.buttonРешить.Click += new System.EventHandler(this.buttonРешить_Click);
            // 
            // buttonВыход
            // 
            this.buttonВыход.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonВыход.Location = new System.Drawing.Point(788, 3);
            this.buttonВыход.Name = "buttonВыход";
            this.buttonВыход.Size = new System.Drawing.Size(139, 30);
            this.buttonВыход.TabIndex = 1;
            this.buttonВыход.Text = "Выход";
            this.buttonВыход.UseVisualStyleBackColor = true;
            this.buttonВыход.Click += new System.EventHandler(this.buttonВыход_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Решение систем линейных алгебраических уравнений";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Серба А.В., Малиновкий А.А. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(930, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Версия 1.1. В данной версии могут содержаться ошибки. ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(930, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "В случае их обнаружения, пожалуйста, сделайте скриншорт и отправте нам мыло:annse" +
    "rba94@gmail.com или ixus.van.axel@gmail.com";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ГлавноеМеню
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ГлавноеМеню";
            this.Text = "Главное меню";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxМатрица.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAij)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBi)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBoxTochnost.ResumeLayout(false);
            this.groupBoxTochnost.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxМетоды.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBoxПрямые.ResumeLayout(false);
            this.groupBoxИтерационные.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxМатрица;
        private System.Windows.Forms.DataGridView dataGridViewAij;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxМетоды;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxПрямые;
        private System.Windows.Forms.CheckedListBox checkedListBoxПрямые;
        private System.Windows.Forms.GroupBox groupBoxИтерационные;
        private System.Windows.Forms.CheckedListBox checkedListBoxИтерационные;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonРешить;
        private System.Windows.Forms.Button buttonВыход;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ai1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ai2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBoxTochnost;
        private System.Windows.Forms.TextBox textBoxТочность;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonУменьшитьРазмерМатрицы;
        private System.Windows.Forms.Button buttonУверичитьРазмерМатрицы;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

