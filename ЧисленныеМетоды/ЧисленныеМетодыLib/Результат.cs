using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧисленныеМетодыLib
{
    public class Результат
    {
        public List<double> Xj=new List<double>();
        public List<РасширеннаяМатрица> ПромежуточныеРезультаты=new List<РасширеннаяМатрица>();
        public string Error="";
        public bool УдаченЛиРезультат=false;
    }
    public class ИтерационныйРезультат
    {
        public List<List<double>> Xkj=new List<List<double>>();
        public List<List<double>> Альфаij=new List<List<double>>();
        public List<double> Беттаi=new List<double>();
        public string Error = "";
        public bool УдаченЛиРезультат = false;
    }
    public class РезультатПрогонки
    {
       public List<double> Xi = new List<double>();
       public List<double> Alphai = new List<double>();
       public List<double> Bettai = new List<double>();
       public List<double> Gammai = new List<double>();
       public List<double> Deltai = new List<double>();
       public List<double> Pi = new List<double>();
       public List<double> Qi = new List<double>();
        public string Error = "";
        public bool УдаченЛиРезультат = false;
    }
    public class РезультатХолецкого
    {
        public List<List<double>> B=new List<List<double>>();
        public List<List<double>> C=new List<List<double>>();
        public List<double> y=new List<double>();
        public List<double> x=new List<double>();
        public string Error = "";
        public bool УдаченЛиРезультат = false;
    }
    public class РасширеннаяМатрица
    {
        public List<List<double>> Aij=new List<List<double>>();
        public List<double> Bi=new List<double>();
    }
}
