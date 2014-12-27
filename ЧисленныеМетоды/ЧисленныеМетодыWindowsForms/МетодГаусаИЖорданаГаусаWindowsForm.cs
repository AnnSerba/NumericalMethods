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
    public partial class МетодГаусаИЖорданаГаусаWindowsForm : Form
    {
        public enum Метод
        {
            Гауса,
            ГаусаЖордана
        }
        Метод метод;
        РасширеннаяМатрица расширеннаяМатрица;
        Результат результат;
        double точность;
        public МетодГаусаИЖорданаГаусаWindowsForm(РасширеннаяМатрица расширеннаяМатрица, Метод метод,double точность)
        {
            InitializeComponent();
            this.метод = метод;
            this.расширеннаяМатрица = расширеннаяМатрица;
            this.точность = точность;
            Решение(расширеннаяМатрица, метод,точность);
           ГлавноеМеню.Заполнение(расширеннаяМатрица.Aij, dataGridViewAkij, "A");
           ГлавноеМеню.ЗаполнениеСтолбца(расширеннаяМатрица.Bi, dataGridViewBki, "B");
        }
        public string Решение(РасширеннаяМатрица расширеннаяМатрица, Метод метод,double точность)
        {
            результат = new Результат();
            if (метод == Метод.Гауса)
            {
                результат = Методы.Гауса(расширеннаяМатрица);
            }
            else if (метод == Метод.ГаусаЖордана)
            {
                результат = Методы.ГаусаЖордана(расширеннаяМатрица,точность);
            }
            if (результат.УдаченЛиРезультат == true)
            {

                ГлавноеМеню.ЗаполнениеСтроки(результат.Xj, dataGridViewXj, "X");
                for (int i = 0; i < результат.ПромежуточныеРезультаты.Count; i++)
                {
                    listBoxПромежуточныеРезультаты.Items.Add((i + 1) + "-е преобразование");
                }
                return "Решение найдено";
            }
            else
            {
                return результат.Error;
            }
        }
        

        private void dataGridViewAkij_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            listBoxПромежуточныеРезультаты.ClearSelected();
            listBoxПромежуточныеРезультаты.SetSelected(0, true);
        }

        private void listBoxПромежуточныеРезультаты_Click(object sender, EventArgs e)
        {
            if (listBoxПромежуточныеРезультаты.GetSelected(0) == true)
            {
                ГлавноеМеню.Заполнение(расширеннаяМатрица.Aij, dataGridViewAkij, "A");
                ГлавноеМеню.ЗаполнениеСтолбца(расширеннаяМатрица.Bi, dataGridViewBki, "B");
            }
            else
            {
                for (int i = 1; i < listBoxПромежуточныеРезультаты.Items.Count; i++)
                {
                    if (listBoxПромежуточныеРезультаты.GetSelected(i) == true)
                    {
                        ГлавноеМеню.Заполнение(результат.ПромежуточныеРезультаты[i - 1].Aij, dataGridViewAkij, "A");
                        ГлавноеМеню.ЗаполнениеСтолбца(результат.ПромежуточныеРезультаты[i - 1].Bi, dataGridViewBki, "B");
                    }
                }
            }
        }

        private void buttonЗакрыть_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonПересчитать_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxПромежуточныеРезультаты.Items.Clear();
                listBoxПромежуточныеРезультаты.Items.Add("Исходная матрица");
                расширеннаяМатрица = ГлавноеМеню.СчитываниеМатрицы(dataGridViewAkij, dataGridViewBki);
                Решение(расширеннаяМатрица, метод, точность);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonУвеличитьМатрицу_Click(object sender, EventArgs e)
        {
            dataGridViewAkij.Columns.Add("Ai" + dataGridViewAkij.Columns.Count, "A[i][" + dataGridViewAkij.Columns.Count + "]");
            dataGridViewAkij.Rows.Add();
            dataGridViewBki.Rows.Add();
        }

        private void buttonУменьшитьМатрицу_Click(object sender, EventArgs e)
        {
            if (dataGridViewAkij.Columns.Count > 2)
            {
                dataGridViewAkij.Columns.RemoveAt(dataGridViewAkij.Columns.Count - 1);
                dataGridViewAkij.Rows.RemoveAt(dataGridViewAkij.Rows.Count - 1);
                dataGridViewBki.Rows.RemoveAt(dataGridViewBki.Rows.Count - 1);
            }
            else
            {
                MessageBox.Show("Минимальная матрица 2x2");
            }
        }

    }
}
