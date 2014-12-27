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
    public partial class МетодыПростойИтерацииИЗейделяWindowsForm : Form
    {
        public enum Метод
        {
            ПростойИтерации,
            Зейделя
        }
        public Метод метод;
        public МетодыПростойИтерацииИЗейделяWindowsForm(РасширеннаяМатрица расширеннаяМатрица, Метод метод, double точность)
        {
            InitializeComponent();
            this.метод = метод;
            labelError.Text= Решение(расширеннаяМатрица,метод,точность);
        }
        public string Решение(РасширеннаяМатрица расширеннаяМатрица, Метод метод, double точность)
        {
            ИтерационныйРезультат результат=new ИтерационныйРезультат();
            textBoxТочность.Text = точность + "";
            if (метод == Метод.ПростойИтерации)
            {
                результат = Методы.ПростойИтерации(расширеннаяМатрица, точность);
            }
            else if (метод == Метод.Зейделя)
            {
                результат = Методы.Зейделя(расширеннаяМатрица, точность);
            }
           ГлавноеМеню.Заполнение(расширеннаяМатрица.Aij, dataGridViewAij, "A");
           ГлавноеМеню.ЗаполнениеСтолбца(расширеннаяМатрица.Bi, dataGridViewBi, "B");
            if (результат.УдаченЛиРезультат == true)
            {
                ГлавноеМеню.Заполнение(результат.Альфаij, dataGridViewАльфа, "Альфа");
                ГлавноеМеню.ЗаполнениеСтолбца(результат.Беттаi, dataGridViewБетта, "Бетта");
                ГлавноеМеню.Заполнение(результат.Xkj, dataGridViewXkj, "X[k]");
                return "Решение найдено";
            }
            else
            {
                return результат.Error;
            }
        }

        private void buttonПеререшать_Click(object sender, EventArgs e)
        {
            try
            {
                double results = 0;
                if (double.TryParse(textBoxТочность.Text, out results) == true)
                {
                    labelError.Text = Решение(ГлавноеМеню.СчитываниеМатрицы(dataGridViewAij, dataGridViewBi), метод, results);
                }
                else
                {
                    MessageBox.Show("Чтото не так с точностью");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
