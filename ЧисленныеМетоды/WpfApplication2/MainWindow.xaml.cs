using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ЧисленныеМетодыLib;

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonРешитьClick(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                РасширеннаяМатрица расширеннаяМатрица = new РасширеннаяМатрица() ;
                    //= СчитываниеМатрицы(dataGridViewAij, dataGridViewBi);
                //if (расширеннаяМатрица.Aij != null)
                {
                    double resultsТочность = 0;
                    if (double.TryParse(textBoxТочность.Text, out resultsТочность) == true)
                    {
                        if (checkBoxМетодГаусса.IsChecked == true)
                        {
                            //МетодГаусаИЖорданаГаусаWindowsForm МГWF = new МетодГаусаИЖорданаГаусаWindowsForm(
                           //     расширеннаяМатрица, МетодГаусаИЖорданаГаусаWindowsForm.Метод.Гауса, resultsТочность);
                           // МГWF.Visible = true;
                           // МГWF.Text += "Метод Гауса";
                        }
                        if (checkBoxМетодГауссаЖордана.IsChecked == true)
                        {
                           // МетодГаусаИЖорданаГаусаWindowsForm МГЖWF = new МетодГаусаИЖорданаГаусаWindowsForm(
                           //     расширеннаяМатрица, МетодГаусаИЖорданаГаусаWindowsForm.Метод.ГаусаЖордана, resultsТочность);
                           // МГЖWF.Visible = true;
                           // МГЖWF.Text = "Метод Гаусса — Жордана";
                        }
                        if (checkBoxСхемаХолецкого.IsChecked == true)
                        {
                          //  МетодХолецкогоWindowsForm МЧWF = new МетодХолецкогоWindowsForm(расширеннаяМатрица);
                           // МЧWF.Visible = true;
                           // МЧWF.Text = "Компактный метод Гусса. Схема Холецкого";
                        }
                        if (checkBoxМетодПрогонки.IsChecked == true)
                        {
                           // МетодПрогонкиWindowsForm МПWF = new МетодПрогонкиWindowsForm(расширеннаяМатрица);
                           // МПWF.Visible = true;
                           //МПWF.Text = "Метод прогонки";
                        }
                        if (checkBoxМетодПростойИтерации.IsChecked == true)
                        {
                            Итерационные итерационные = new Итерационные();
							итерационные.Show();
                        }
                        if (checkBoxМетодЗейделя.IsChecked == true)
                        {
                            Итерационные итерационные = new Итерационные();
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

        private void buttonУвеличить_размер_матрицыClick(object sender, System.Windows.RoutedEventArgs e)
        {
            DataGridComboBoxColumn MyDataGridComboBoxColumn = new DataGridComboBoxColumn();
            MyDataGridComboBoxColumn.Header = "A[i]["+dataGridViewAij.Columns.Count+"]";
            dataGridViewAij.Columns.Add(MyDataGridComboBoxColumn);
            dataGridViewAij.Items.Add(new TabItem());
            dataGridViewBi.Items.Add(new TabItem());
        }
        private void buttonУменьшить_размер_матрицыClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if (dataGridViewAij.Columns.Count > 2)
            {
                dataGridViewAij.Columns.RemoveAt(dataGridViewAij.Columns.Count - 1);
                dataGridViewAij.Items.RemoveAt(dataGridViewAij.Items.Count - 1);
                dataGridViewBi.Items.RemoveAt(dataGridViewBi.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Минимальная матрица 2x2");
            }
        }
        public static РасширеннаяМатрица СчитываниеМатрицы(DataGrid dataGridAij, DataGrid dataGridBi)
        {
            РасширеннаяМатрица расширеннаяМатрица = new РасширеннаяМатрица();
            double result = 0;
            расширеннаяМатрица.Aij = new List<List<double>>();
            расширеннаяМатрица.Bi = new List<double>();
            for (int i = 0; i < dataGridAij.Items.Count; i++)
            {
                расширеннаяМатрица.Aij.Add(new List<double>());
                for (int j = 0; j < dataGridAij.Items.Count; j++)
                {
                    if (double.TryParse(dataGridAij.Items[i] + "", out result) == true)
                    {
                        расширеннаяМатрица.Aij[i].Add(result);
                    }
                    else
                    {
                        throw new Exception("Ошибка чтения [" + i + "][" + j + "] элемента матрицы");
                    }
                }
                if (double.TryParse(dataGridBi.Items[i] + "", out result) == true)
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
        public static void Заполнение(List<List<double>> матрица, DataGrid dataGrid, string text)
        {
            dataGrid.Columns.Clear();
            for (int j = 0; j < матрица.Count; j++)
            {
                DataGridComboBoxColumn MyDataGridComboBoxColumn = new DataGridComboBoxColumn();
                MyDataGridComboBoxColumn.Header = text + "[i][" + j + "]";
                dataGrid.Columns.Add(MyDataGridComboBoxColumn);
            }
            dataGrid.Items.Clear();
            for (int i = 0; i < матрица.Count; i++)
            {
                dataGrid.Items.Add(new TabItem());
                for (int j = 0; j < матрица[i].Count; j++)
                {
                    dataGrid.Items[i] = матрица[i][j];
                }
            }
        }

        public static void ЗаполнениеСтолбца(List<double> вектор, DataGrid dataGrid, string text)
        {
            dataGrid.Columns.Clear();
            DataGridComboBoxColumn MyDataGridComboBoxColumn = new DataGridComboBoxColumn();
            MyDataGridComboBoxColumn.Header = text + "[i]";
            dataGrid.Columns.Add(MyDataGridComboBoxColumn);
            dataGrid.Items.Clear();
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGrid.Items.Add(new TabItem());
                dataGrid.Items[i] = вектор[i];
            }
        }
        public static void ЗаполнениеСтроки(List<double> вектор, DataGrid dataGridView, string text)
        {
            dataGridView.Columns.Clear();

            dataGridView.Items.Clear();
            for (int i = 0; i < вектор.Count; i++)
            {
                DataGridComboBoxColumn MyDataGridComboBoxColumn = new DataGridComboBoxColumn();
                MyDataGridComboBoxColumn.Header =  text + "[j]";
                dataGridView.Columns.Add(MyDataGridComboBoxColumn);
            }
            dataGridView.Items.Add(new TabItem());
            for (int j = 0; j < вектор.Count; j++)
            {
                dataGridView.Items[0] = вектор[j];
            }
        }

        public static void ДобавлениеСтолбца(List<double> вектор, DataGrid dataGrid, int j)
        {
            if (dataGrid.Items.Count == 0)
            {
                for (int i = 0; i < вектор.Count; i++)
                {
                    dataGrid.Items.Add(new TabItem());
                }
            }
            for (int i = 0; i < вектор.Count; i++)
            {
                dataGrid.Items[i] = вектор[i];
            }
        }

        private void dataGridViewAij_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
