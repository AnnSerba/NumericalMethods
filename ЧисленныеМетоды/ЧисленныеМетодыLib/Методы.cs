using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ЧисленныеМетодыLib
{
    public class Методы
    {
        public static bool ПроверкаМатрицыНаПреобладаниеДиагональныхЭлементов(List<List<double>> Aij)
        {
            for (int i = 0; i < Aij.Count; i++)
            {
                double max = Math.Abs(Aij[i][0]);
                int maxj = 0;
                double kol = 1;
                for (int j = 1; j < Aij[i].Count - 1; j++)
                {
                    if (max < Math.Abs(Aij[i][j]))
                    {
                        max = Math.Abs(Aij[i][j]);
                        kol = 0;
                        maxj = j;
                    }
                    if (max == Math.Abs(Aij[i][j]))
                    {
                        kol++;
                    }
                }
                if (kol > 1)
                {
                    return false;
                }
                double summod = 0;
                for (int j = 0; j < Aij[i].Count - 1; j++)
                {
                    if (maxj != j)
                    {
                        summod += Math.Abs(Aij[i][j]);
                    }
                }
                if (summod > max)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ПроверкаМатрицыНаТрёхДиагональность(List<List<double>> Aij)
        {
            for (int i = 0; i < Aij.Count - 2; i++)
            {
                for (int j = i + 2; j < Aij[i].Count - 1; j++)
                {
                    if (Aij[i][j] != 0)
                    {
                        return false;
                    }
                }
            }
            for (int i = Aij.Count - 1; i >= 2; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (Aij[i][j] != 0)
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < Aij.Count; i++)
            {
                if (Aij[i][i] == 0)
                {
                    return false;
                }
            }
            for (int i = 1; i < Aij.Count - 1; i++)
            {
                if (Aij[i][i - 1] == 0)
                {
                    return false;
                }
                if (Aij[i - 1][i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static Результат Гауса(РасширеннаяМатрица расширеннаяМатрица)
        {
            Результат результат = new Результат();
            int n = расширеннаяМатрица.Aij.Count;
            int j = 0, i = 0, k = 0;
            double[,] a = new double[n, n + 1];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = расширеннаяМатрица.Aij[i][j];
                }
                a[i, n] = расширеннаяМатрица.Bi[i];
            }

            double m = 0, t = 0;

            for (j = 0; j < n; j++)
            {
                if (a[j, i] == 0)
                {
                    k = j;
                    while ((a[k + 1, j] == 0) && (k < n))
                        k++;
                    if (a[k + 1, j] != 0)
                        for (i = 0; i < m; i++)
                        {
                            t = a[j, i];
                            a[j, i] = a[k + 1, i];
                            a[k + 1, i] = t;
                        }
                    else
                    {
                        результат.Error = "СЛАУ имеет множество решений";
                    }
                }

            }

            for (k = 0; k < n - 1; k++)
            {
                for (j = k + 1; j < n; j++)
                {
                    if (a[k, k] != 0)
                    {
                        t = a[j, k] / a[k, k];
                        for (i = 0; i < n + 1; i++)
                            a[j, i] = a[k, i] * t - a[j, i];
                    }
                    else
                    {
                        результат.Error = "СЛАУ не имеет решений";
                    }
                }
                результат.ПромежуточныеРезультаты.Add(new РасширеннаяМатрица());
                результат.ПромежуточныеРезультаты[k].Aij = new List<List<double>>();
                for (int e = 0; e < n; e++)
                {
                    результат.ПромежуточныеРезультаты[k].Aij.Add(new List<double>());
                    for (int l = 0; l < n; l++)
                    {
                        результат.ПромежуточныеРезультаты[k].Aij[e].Add(a[e, l]);
                    }
                    результат.ПромежуточныеРезультаты[k].Bi.Add(a[e, n]);
                }
            }

            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n + 1; i++)
                    Console.Write(Math.Round(a[j, i], 6) + " ");
                Console.WriteLine();
            }

            double[] x = new double[n];
            for (j = n - 1; j >= 0; j--)
            {
                t = a[j, n];
                for (i = j + 1; i < n; i++)
                    t = t - a[j, i] * x[i];
                x[j] = t / a[j, j];
            }
            результат.Xj = new List<double>();
            for (i = 0; i < n; i++)
            {
                результат.Xj.Add(x[i]);
            }
            результат.УдаченЛиРезультат = true;
            return результат;
        }
        public static Результат ГаусаЖордана(РасширеннаяМатрица расширеннаяМатрица, double точность)
        {
            Результат результат = new Результат();
            
            int i, j, k;
            List<double> x = new List<double>();
            double max;
            int max_i;
            int n = расширеннаяМатрица.Aij.Count;
            double lead, a_div_lead;
            double[] b = new double[n];
            double[,] a = new double[n, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = расширеннаяМатрица.Aij[i][j];
                }
                b[i] = расширеннаяМатрица.Bi[i];
            }

            for (k = 0; k < n; k++)
            {

                max = 0;
                max_i = -1;

                for (i = k; i < n; i++)
                {
                    if (Math.Abs(a[i, k]) > max)
                    {
                        max = Math.Abs(a[i, k]);
                        max_i = i;
                    }
                }

                if (max_i == -1 || Math.Abs(a[max_i, k]) < точность)
                {
                    throw (new Exception("Ошибка: оприделитель матрицы =0"));
                }
                lead = a[k, k];

                for (j = k; j < n; j++)
                    a[k, j] /= lead;
                b[k] /= lead;

                for (i = 0; i < n; i++)
                {
                    a_div_lead = a[i, k] / a[k, k];

                    if (i != k)
                    {
                        for (j = k; j < n; j++)
                            a[i, j] -= a[k, j] * a_div_lead;
                        b[i] -= b[k] * a_div_lead;
                    }
                }
                результат.ПромежуточныеРезультаты.Add(new РасширеннаяМатрица());
                результат.ПромежуточныеРезультаты[k].Aij = new List<List<double>>();
                результат.ПромежуточныеРезультаты[k].Bi = new List<double>();
                for (i = 0; i < n; i++)
                {
                    результат.ПромежуточныеРезультаты[k].Aij.Add(new List<double>());
                    for (j = 0; j < n; j++)
                    {
                        результат.ПромежуточныеРезультаты[k].Aij[i].Add(a[i, j]);
                    }
                    результат.ПромежуточныеРезультаты[k].Bi.Add(b[i]);
                }
            }
            for (i = 0; i < n; i++)
            {
                результат.Xj.Add(b[i]);
            }
            результат.УдаченЛиРезультат = true;
            return результат;
        }
        public static РезультатХолецкого Холецкого(РасширеннаяМатрица расширеннаяМатрица)
        {
            РезультатХолецкого результат = new РезультатХолецкого();
           
            for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
            {
                результат.B.Add(new List<double>());
                результат.C.Add(new List<double>());
                результат.y.Add(0);
                результат.x.Add(0);
                for (int j = 0; j < расширеннаяМатрица.Aij[i].Count; j++)
                {
                    результат.B[i].Add(0);
                    результат.C[i].Add(0);
                }
            }

            for (int j = 0; j < расширеннаяМатрица.Aij.Count; j++)
            {
                for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
                {
                    результат.B[i][j] = расширеннаяМатрица.Aij[i][j];
                    for (int k = 0; k < j-1; k++)
                    {
                        if (0 < j && i >= j)
                        {
                            результат.B[i][j] -= результат.B[i][k] * результат.C[k][j];
                        }
                    }
                }
                for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
                {
                    результат.C[j][i] = расширеннаяМатрица.Aij[j][i];
                    for (int k = 0; k < j-1; k++)
                    {
                        if (0 < j && j < i)
                        {
                            результат.C[j][i] -= результат.B[j][k] * результат.C[k][i];
                        }
                    }
                    результат.C[j][i] /= результат.B[j][j];
                }
            }

            for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
            {
                результат.y[i] = расширеннаяМатрица.Bi[i];
                for (int k = 0; k < i - 1; k++)
                {
                    результат.y[i] -= результат.B[i][k] * результат.y[k];
                }
                результат.y[i] /= результат.B[i][i];
            }

            for (int i = расширеннаяМатрица.Aij.Count - 1; i >= 0; i--)
            {
                результат.x[i] = результат.y[i];
                for (int k = i + 1; k < расширеннаяМатрица.Aij.Count; k++)
                {
                    результат.x[i] -= результат.C[i][k] * результат.x[k];
                }
            }
            return результат;
        }
        public static РезультатПрогонки Прогонки(РасширеннаяМатрица расширеннаяМатрица)
        {
            РезультатПрогонки результат = new РезультатПрогонки();

            if (ПроверкаМатрицыНаТрёхДиагональность(расширеннаяМатрица.Aij) == false)
            {
                результат.УдаченЛиРезультат = false;
                throw new Exception("Матрица должна быть трёхдиагональная");
            }
            List<List<double>> Aij = new List<List<double>>();
            for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
            {
                Aij.Add(new List<double>());
                for (int j = 0; j < расширеннаяМатрица.Aij[i].Count; j++)
                {
                    Aij[i].Add(расширеннаяМатрица.Aij[i][j]);
                }
                Aij[i].Add(расширеннаяМатрица.Bi[i]);
            }
            for (int i = 0; i < Aij.Count; i++)
            {
                результат.Bettai.Add(-Aij[i][i]);
            }
            результат.Alphai.Add(0);
            for (int i = 1; i < Aij.Count; i++)
            {
                результат.Alphai.Add(Aij[i][i - 1]);
                результат.Gammai.Add(Aij[i - 1][i]);
            }
            результат.Gammai.Add(0);
            for (int i = 0; i < Aij.Count; i++)
            {
                результат.Deltai.Add(Aij[i][Aij.Count]);
            }
            результат.Pi.Add(результат.Gammai[0] / результат.Bettai[0]);
            for (int i = 1; i < Aij.Count - 1; i++)
            {
                результат.Pi.Add(результат.Gammai[i] / (результат.Bettai[i] - результат.Alphai[i] * результат.Pi[i - 1]));
            }
            результат.Pi.Add(0);
            результат.Qi.Add(-результат.Deltai[0] / результат.Bettai[0]);
            for (int i = 1; i < Aij.Count; i++)
            {
                результат.Qi.Add((результат.Alphai[i] * результат.Qi[i - 1] - результат.Deltai[i]) /
                    (результат.Bettai[i] - результат.Alphai[i] * результат.Pi[i - 1]));
            }
            for (int i = 0; i < Aij.Count; i++)
            {
                результат.Xi.Add(0);
            }
            результат.Xi[Aij.Count - 1] = результат.Qi[Aij.Count - 1];
            for (int i = Aij.Count - 2; i >= 0; i--)
            {
                результат.Xi[i] = результат.Pi[i] * результат.Xi[i + 1] + результат.Qi[i];
            }
            результат.УдаченЛиРезультат = true;
            return результат;
        }
        public static ИтерационныйРезультат Зейделя(РасширеннаяМатрица расширеннаяМатрица, double точность)
        {
            ИтерационныйРезультат результат = new ИтерационныйРезультат();
            if (ПроверкаМатрицыНаПреобладаниеДиагональныхЭлементов(расширеннаяМатрица.Aij) == false)
            {
                результат.УдаченЛиРезультат = false;
                throw new Exception("Проверте матрицу на преобладание диагональных элементов");
            }
            результат.Альфаij = new List<List<double>>();
            результат.Беттаi = new List<double>();
            List<List<double>> Погрешность = new List<List<double>>();
            for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
            {
                результат.Альфаij.Add(new List<double>());
                for (int j = 0; j < расширеннаяМатрица.Aij[i].Count; j++)
                {
                    if (i == j)
                    {
                        результат.Альфаij[i].Add(0);
                    }
                    else
                    {
                        результат.Альфаij[i].Add(
                            -расширеннаяМатрица.Aij[i][j] / расширеннаяМатрица.Aij[i][i]);
                    }
                }
                результат.Беттаi.Add(
                    расширеннаяМатрица.Bi[i] / расширеннаяМатрица.Aij[i][i]);
            }
            результат.Xkj.Add(new List<double>());
            for (int i = 0; i < расширеннаяМатрица.Aij[0].Count; i++)
            {
                результат.Xkj[0].Add(0);
            }
            результат.Xkj[0][0] = результат.Беттаi[0];
            int s = 0;
            Погрешность.Add(new List<double>());
            for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
            {
                Погрешность[s].Add(0);
            }
            do
            {
                s++;
                результат.Xkj.Add(new List<double>());
                for (int i = 0; i < результат.Xkj[s - 1].Count; i++)
                {
                    результат.Xkj[s].Add(0);
                }
                for (int i = 0; i < результат.Xkj[s - 1].Count; i++)
                {
                    for (int j = 0; j < результат.Xkj[s - 1].Count; j++)
                    {
                        if (j > i)
                        {
                            результат.Xkj[s][i] += результат.Альфаij[i][j] * результат.Xkj[s - 1][j];
                        }
                        else if (j < i)
                        {
                            результат.Xkj[s][i] += результат.Альфаij[i][j] * результат.Xkj[s][j];
                        }
                    }
                    результат.Xkj[s][i] += результат.Беттаi[i];
                }
                Погрешность.Add(new List<double>());
                for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
                {
                    Погрешность[s].Add(результат.Xkj[s][i] - результат.Xkj[s - 1][i]);
                }
            } while (Math.Abs(Погрешность[s].Max()) >= точность);
            результат.УдаченЛиРезультат = true;
            return результат;
        }
        public static ИтерационныйРезультат ПростойИтерации(РасширеннаяМатрица расширеннаяМатрица, double точность)
        {

            List<List<double>> Погрешность = new List<List<double>>();
            ИтерационныйРезультат результат = new ИтерационныйРезультат();
            if (ПроверкаМатрицыНаПреобладаниеДиагональныхЭлементов(расширеннаяМатрица.Aij) == false)
            {
                результат.УдаченЛиРезультат = false;
                throw new Exception("Проверте матрицу на преобладание диагональных элементов");
            }
            for (int i = 0; i < расширеннаяМатрица.Aij.Count; i++)
            {
                результат.Альфаij.Add(new List<double>());
                for (int j = 0; j < расширеннаяМатрица.Aij[i].Count; j++)
                {
                    if (i == j)
                    {
                        результат.Альфаij[i].Add(0);
                    }
                    else
                    {
                        результат.Альфаij[i].Add(-расширеннаяМатрица.Aij[i][j] / расширеннаяМатрица.Aij[i][i]);
                    }
                }
                результат.Беттаi.Add(расширеннаяМатрица.Bi[i] / расширеннаяМатрица.Aij[i][i]);
            }
            результат.Xkj.Add(new List<double>());
            for (int j = 0; j < расширеннаяМатрица.Aij[0].Count; j++)
            {
                результат.Xkj[0].Add(результат.Беттаi[j]);
            }
            int s = 0;
            Погрешность.Add(new List<double>());
            for (int j = 0; j < расширеннаяМатрица.Aij.Count; j++)
            {
                Погрешность[0].Add(0);
            }
            do
            {
                s++;
                результат.Xkj.Add(new List<double>());
                for (int i = 0; i < результат.Альфаij.Count; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < результат.Альфаij[i].Count; j++)
                    {
                        sum += результат.Альфаij[i][j] * результат.Xkj[s - 1][j];
                    }
                    результат.Xkj[s].Add(результат.Беттаi[i] + sum);
                }
                Погрешность.Add(new List<double>());
                for (int i = 0; i < результат.Xkj[s].Count; i++)
                {
                    Погрешность[s].Add(результат.Xkj[s][i] - результат.Xkj[s - 1][i]);
                }

            } while (Math.Abs(Погрешность[s].Max()) > точность);
            результат.УдаченЛиРезультат = true;
            return результат;
        }

    }
}
