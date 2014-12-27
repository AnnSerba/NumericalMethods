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
    public partial class МетодХолецкогоWindowsForm : Form
    {
        РасширеннаяМатрица расширеннаяМатрица;
        public МетодХолецкогоWindowsForm(РасширеннаяМатрица расширеннаяМатрица)
        {
            InitializeComponent();
            ГлавноеМеню.Заполнение(расширеннаяМатрица.Aij,dataGridViewAij,"A");
            ГлавноеМеню.ЗаполнениеСтолбца(расширеннаяМатрица.Bi, dataGridViewBi, "B");
            this.расширеннаяМатрица = расширеннаяМатрица;
            Решение(расширеннаяМатрица);
        }
        public string Решение(РасширеннаяМатрица расширеннаяМатрица)
        {
            РезультатХолецкого результатХолецкого = Методы.Холецкого(расширеннаяМатрица);
            ГлавноеМеню.Заполнение(результатХолецкого.B, dataGridViewBij, "B");
            ГлавноеМеню.Заполнение(результатХолецкого.C, dataGridViewCij, "C");
            ГлавноеМеню.ЗаполнениеСтроки(результатХолецкого.y, dataGridViewYj, "y");
            ГлавноеМеню.ЗаполнениеСтроки(результатХолецкого.x, dataGridViewXj, "x");
            if (результатХолецкого.УдаченЛиРезультат == true)
            {
                return "Решение найдено";
            }
            else
            {
                return результатХолецкого.Error;
            }
        }

        private void buttonУвеличитьРазмерМатрицы_Click(object sender, EventArgs e)
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

        private void buttonПеререшать_Click(object sender, EventArgs e)
        {
            try
            {
                расширеннаяМатрица = ГлавноеМеню.СчитываниеМатрицы(dataGridViewAij, dataGridViewBi);
                Решение(расширеннаяМатрица);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
