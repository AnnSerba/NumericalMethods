using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЧисленныеМетодыLib;

namespace ЧисленныеМетодыWindowsForms
{
    public partial class ГлавноеМеню : Form
    {
        public ГлавноеМеню()
        {
            InitializeComponent();
            dataGridViewAij.Columns.Add("Ai" + dataGridViewAij.Columns.Count, "A[i][" + dataGridViewAij.Columns.Count + "]");
            dataGridViewAij.Rows.Add();
            dataGridViewAij.Rows.Add();
            dataGridViewAij.Rows.Add();

            dataGridViewBi.Rows.Add();
            dataGridViewBi.Rows.Add();
            dataGridViewBi.Rows.Add();

            dataGridViewAij.Rows[0].Cells[0].Value = 7;
            dataGridViewAij.Rows[0].Cells[1].Value = 0.09;
            dataGridViewAij.Rows[0].Cells[2].Value = -0.03;
            dataGridViewBi.Rows[0].Cells[0].Value = 6.7;
            dataGridViewAij.Rows[1].Cells[0].Value = 0.09;
            dataGridViewAij.Rows[1].Cells[1].Value = 4;
            dataGridViewAij.Rows[1].Cells[2].Value = -0.15;
            dataGridViewBi.Rows[1].Cells[0].Value = 8.7;
            dataGridViewAij.Rows[2].Cells[0].Value = 0.04;
            dataGridViewAij.Rows[2].Cells[1].Value = -0.08;
            dataGridViewAij.Rows[2].Cells[2].Value = 6;
            dataGridViewBi.Rows[2].Cells[0].Value = 15.3;
            checkedListBoxПрямые.SetItemChecked(0, true);
            checkedListBoxПрямые.SetItemChecked(1, true);
            checkedListBoxПрямые.SetItemChecked(2, true);
            checkedListBoxИтерационные.SetItemChecked(0, true);
            checkedListBoxИтерационные.SetItemChecked(1, true);
        }

        private void buttonВыход_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonУверичитьРазмерМатрицы_Click(object sender, EventArgs e)
        {
            dataGridViewAij.Columns.Add("Ai" + dataGridViewAij.Columns.Count, "A[i][" + dataGridViewAij.Columns.Count + "]");
            dataGridViewAij.Rows.Add();
            dataGridViewBi.Rows.Add();
        }

        private void buttonУменьшитьРазмерМатрицы_Click(object sender, EventArgs e)
        {
            if (dataGridViewAij.Columns.Count > 2)
            {
                dataGridViewAij.Columns.RemoveAt(dataGridViewAij.Columns.Count - 1);
                dataGridViewAij.Rows.RemoveAt(dataGridViewAij.Rows.Count - 1);
                dataGridViewBi.Rows.RemoveAt(dataGridViewBi.Rows.Count - 1);
            }
            else
            {
                MessageBox.Show("Минимальная матрица 2x2");
            }
        }

        private void buttonРешить_Click(object sender, EventArgs e)
        {
            try
            {
                РасширеннаяМатрица расширеннаяМатрица = СчитываниеМатрицы(dataGridViewAij, dataGridViewBi);
                if (расширеннаяМатрица.Aij != null)
                {
                    double resultsТочность = 0;
                    if (double.TryParse(textBoxТочность.Text, out resultsТочность) == true)
                    {
                        if (checkedListBoxПрямые.CheckedItems.Contains("Метод Гаусса") == true)
                        {
                            МетодГаусаИЖорданаГаусаWindowsForm МГWF = new МетодГаусаИЖорданаГаусаWindowsForm(
                                расширеннаяМатрица, МетодГаусаИЖорданаГаусаWindowsForm.Метод.Гауса, resultsТочность);
                            МГWF.Visible = true;
                            МГWF.Text += "Метод Гауса";
                        }
                        if (checkedListBoxПрямые.CheckedItems.Contains("Метод Гаусса — Жордана") == true)
                        {
                            МетодГаусаИЖорданаГаусаWindowsForm МГЖWF = new МетодГаусаИЖорданаГаусаWindowsForm(
                                расширеннаяМатрица, МетодГаусаИЖорданаГаусаWindowsForm.Метод.ГаусаЖордана, resultsТочность);
                            МГЖWF.Visible = true;
                            МГЖWF.Text = "Метод Гаусса — Жордана";
                        }
                        if (checkedListBoxПрямые.CheckedItems.Contains("Компактный метод Гусса. Схема Холецкого") == true)
                        {
                            МетодХолецкогоWindowsForm МЧWF = new МетодХолецкогоWindowsForm(расширеннаяМатрица);
                            МЧWF.Visible = true;
                            МЧWF.Text = "Компактный метод Гусса. Схема Холецкого";
                        }
                        if (checkedListBoxПрямые.CheckedItems.Contains("Метод прогонки") == true)
                        {
                            МетодПрогонкиWindowsForm МПWF = new МетодПрогонкиWindowsForm(расширеннаяМатрица);
                            МПWF.Visible = true;
                            МПWF.Text = "Метод прогонки";
                        }
                        if (checkedListBoxИтерационные.CheckedItems.Contains("Метод простой итерации") == true)
                        {
                            МетодыПростойИтерацииИЗейделяWindowsForm МПИWF = new МетодыПростойИтерацииИЗейделяWindowsForm(
                                расширеннаяМатрица, МетодыПростойИтерацииИЗейделяWindowsForm.Метод.ПростойИтерации, resultsТочность);
                            МПИWF.Visible = true;
                            МПИWF.Text = "Метод простой итерации";
                        }
                        if (checkedListBoxИтерационные.CheckedItems.Contains("Метод Зейделя") == true)
                        {
                            МетодыПростойИтерацииИЗейделяWindowsForm МЗWF = new МетодыПростойИтерацииИЗейделяWindowsForm(
                                расширеннаяМатрица, МетодыПростойИтерацииИЗейделяWindowsForm.Метод.Зейделя, resultsТочность);
                            МЗWF.Visible = true;
                            МЗWF.Text = "Метод Зейделя";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Чтото не так с точностью");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static РасширеннаяМатрица СчитываниеМатрицы(DataGridView dataGridViewAij, DataGridView dataGridViewBi)
        {
            РасширеннаяМатрица расширеннаяМатрица = new РасширеннаяМатрица();
            double result = 0;
            расширеннаяМатрица.Aij = new List<List<double>>();
            расширеннаяМатрица.Bi = new List<double>();
            for (int i = 0; i < dataGridViewAij.Rows.Count; i++)
            {
                расширеннаяМатрица.Aij.Add(new List<double>());
                for (int j = 0; j < dataGridViewAij.Rows[i].Cells.Count; j++)
                {
                    if (double.TryParse(dataGridViewAij.Rows[i].Cells[j].Value + "", out result) == true)
                    {
                        расширеннаяМатрица.Aij[i].Add(result);
                    }
                    else
                    {
                        throw new Exception("Ошибка чтения [" + i + "][" + j + "] элемента матрицы");
                    }
                }
                if (double.TryParse(dataGridViewBi.Rows[i].Cells[0].Value + "", out result) == true)
                {
                    расширеннаяМатрица.Bi.Add(result);
                }
                else
                {
                    throw new Exception("Ошибка чтения [" + i + "] элементе столбца свободных членов");
                }
            }
            return расширеннаяМатрица;
        }
        public static void Заполнение(List<List<double>> матрица, DataGridView dataGridView, string text)
        {
            dataGridView.Columns.Clear();
            for (int j = 0; j < матрица.Count; j++)
            {
                dataGridView.Columns.Add(text + "i" + j, text + "[i][" + j + "]");
            }
            dataGridView.Rows.Clear();
            for (int i = 0; i < матрица.Count; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < матрица[i].Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = матрица[i][j];
                }
            }
        }

        public static void ЗаполнениеСтолбца(List<double> вектор, DataGridView dataGridView, string text)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(text + "i", text + "[i]");
            dataGridView.Rows.Clear();
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = вектор[i];
            }
        }
        public static void ЗаполнениеСтроки(List<double> вектор, DataGridView dataGridView, string text)
        {
            dataGridView.Columns.Clear();

            dataGridView.Rows.Clear();
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGridView.Columns.Add(text + "j", text + "[j]");
            }
            dataGridView.Rows.Add();
            for (int j = 0; j < вектор.Count; j++)
            {
                dataGridView.Rows[0].Cells[j].Value = вектор[j];
            }
        }

        public static void ДобавлениеСтолбца(List<double> вектор, DataGridView dataGridView, int j)
        {
            if (dataGridView.Rows.Count == 0)
            {
                for (int i = 0; i < вектор.Count; i++)
                {
                    dataGridView.Rows.Add();
                }
            }
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGridView.Rows[i].Cells[j].Value = вектор[i];
            }
        }

       
    }
}
