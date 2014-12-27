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
    public partial class МетодПрогонкиWindowsForm : Form
    {
        РасширеннаяМатрица расширеннаяМатрица;
        public МетодПрогонкиWindowsForm(РасширеннаяМатрица расширеннаяМатрица)
        {
            InitializeComponent();
            ГлавноеМеню.Заполнение(расширеннаяМатрица.Aij, dataGridViewAij, "A");
            ГлавноеМеню.ЗаполнениеСтолбца(расширеннаяМатрица.Bi, dataGridViewBi, "B");
            this.расширеннаяМатрица = расширеннаяМатрица;
            Решение(расширеннаяМатрица);
        }
        public string Решение(РасширеннаяМатрица расширеннаяМатрица)
        {
            РезультатПрогонки результат = new РезультатПрогонки();
            результат = Методы.Прогонки(расширеннаяМатрица);
            if (результат.УдаченЛиРезультат == true)
            {
                List<double> inti = new List<double>();
                for (int i = 0; i < результат.Alphai.Count; i++)
                {
                    inti.Add(i);
                }
                ГлавноеМеню.ДобавлениеСтолбца(inti, dataGridViewОтвет, 0);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Alphai, dataGridViewОтвет, 1);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Bettai, dataGridViewОтвет, 2);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Gammai, dataGridViewОтвет, 3);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Deltai, dataGridViewОтвет, 4);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Pi, dataGridViewОтвет, 5);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Qi, dataGridViewОтвет, 6);
                ГлавноеМеню.ДобавлениеСтолбца(результат.Xi, dataGridViewОтвет, 7);
                return "Решение найдено";
            }
            else
            {
                return результат.Error;
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
        private void buttonЗакрыть_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void buttonПеререшать_Click(object sender, EventArgs e)
        {
            try
            {
                расширеннаяМатрица= ГлавноеМеню.СчитываниеМатрицы(dataGridViewAij, dataGridViewBi);
                Решение(расширеннаяМатрица);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
