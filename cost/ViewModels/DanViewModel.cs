
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cost.Helper;
using cost.Models;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace cost.ViewModels
{
    public class DanViewModel : ObservableObject
    {
        public List<table_dan> table_Dans = new List<table_dan>();
        table_dan table_Dan = new table_dan();
        table_optical table_Optical = new table_optical();
        public DanViewModel( string products)
        {
            NewDbHelper sugar = new NewDbHelper();
           
            using (var db = sugar.db)
            {
                try
                {
                    //table_Dans = db.Queryable<table_dan>().Where(A => A.products_code == products).Includes(x => x.optical_code).ToList();
                    table_Dans = db.Queryable<table_dan>().Includes(x => x.optical_code).ToList();
                    List<string> fieldList = table_Dans.AsEnumerable().Select(t => t.products_code).ToList<string>();
                    Dropproducts = fieldList;
                    //Droptext = products;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        private List<string> _Dropproducts;

        public List<string> Dropproducts
        {
            get { return _Dropproducts; }

            set
            {
                SetProperty<List<string>>(ref _Dropproducts, value);
            }
        }
        private string _Droptext;

        public string Droptext
        {
            get { return _Droptext; }

            set
            {
                SetProperty<string>(ref _Droptext, value);
                table_Dan = table_Dans.Find(t => t.products_code == value);
                Gbcost = table_Dan.毛细管;
                Jjrgcost = table_Dan.计件人工成本;
                Gtcost = table_Dan.费用公摊;
                Bzrgcost = table_Dan.包装人工;
                Bccost = table_Dan.包材;
                Bzjtcost = table_Dan.包装均摊;
                Gxslcost = table_Dan.带纤数量;
                List<string> fieldList = table_Dan.optical_code.AsEnumerable().Select(t => t.optical_name).ToList<string>();
                DropXp = fieldList;
            }
        }

        private List<string> _DropXp;

        public List<string> DropXp
        {
            get { return _DropXp; }
            set
            {
                SetProperty<List<string>>(ref _DropXp, value);
            }
        }
        private string _DropListtext;

        public string DropListtext
        {
            get { return _DropListtext; }
            set
            {
                SetProperty<string>(ref _DropListtext, value);
                if (!string.IsNullOrEmpty(value))
                {
                    Gxcost = table_Dan.optical_code.Find(t => t.optical_name == _DropListtext).price_no_tax;
                }
                else
                {
                    Gxcost = "0";
                }

            }
        }

        private string _Gxcost="0";

        public string Gxcost
        {
            get { return _Gxcost; }
            set
            { 
                SetProperty<string>(ref _Gxcost, value);
                CostYcl();
            }
        }

        private string _Gbcost="0";

        public string Gbcost
        {
            get { return _Gbcost; }
            set 
            { 
                SetProperty<string>(ref _Gbcost, value);
                CostYcl();
            }
        }

        private string _Jjrgcost="0";
        public string Jjrgcost
        {
            get { return _Jjrgcost; }
            set
            {
                SetProperty<string>(ref _Jjrgcost, value);
                CostYcl();
            }
        }

        private string _Gtcost="0";
        public string Gtcost
        {
            get { return _Gtcost; }
            set
            { 
                SetProperty<string>(ref _Gtcost, value);
                CostYcl();
            }
        }
        private string _Gxcdcost="1";
        public string Gxcdcost
        {
            get { return _Gxcdcost; }
            set
            { 
                SetProperty<string>(ref _Gxcdcost, value);
                CostYcl();
            }
        }
        private string _Gxslcost="1";
        public string Gxslcost
        {
            get { return _Gxslcost; }
            set 
            { 
                bool b=SetProperty<string>(ref _Gxslcost, value);
                CostYcl();
            }
        }

        private string _Flcost = "0.1";
        public string Flcost
        {
            get { return _Flcost; }
            set
            {
                bool b = SetProperty<string>(ref _Flcost, value);
                CostYcl();
            }
        }

        private string _Yclcost;
        public string Yclcost
        {
            get 
            { 
                return _Yclcost; 
            }
            set 
            {
                
                SetProperty<string>(ref _Yclcost, value);
            }
        }

        private string _Zzcost;
        public string Zzcost
        {
            get
            {
                return _Zzcost;
            }
            set
            {

                SetProperty<string>(ref _Zzcost, value);
            }
        }
        private string _Lltext = "100";
        public string Lltext
        {
            get
            {
                return _Lltext;
            }
            set
            {

                SetProperty<string>(ref _Lltext, value);
                CostYcl();
            }

        }

        private string _Bzrgcost = "0";
        public string Bzrgcost
        {
            get { return _Bzrgcost; }
            set
            {
                bool b = SetProperty<string>(ref _Bzrgcost, value);
               // CostYcl();
            }
        }
        private string _Bccost = "0";
        public string Bccost
        {
            get { return _Bccost; }
            set
            {
                bool b = SetProperty<string>(ref _Bccost, value);
              //  CostYcl();
            }
        }
        private string _Bzjtcost = "0";
        public string Bzjtcost
        {
            get { return _Bzjtcost; }
            set
            {
                bool b = SetProperty<string>(ref _Bzjtcost, value);
                //CostYcl();
            }
        }
        private string _Chcost = "0";
        public string Chcost
        {
            get { return _Chcost; }
            set
            {
                bool b = SetProperty<string>(ref _Chcost, value);
            }
        }

        public void CostYcl()
        {
            //原材料=光纤价格*光纤数量*光纤长度+盖板+辅料
            double a = double.Parse(Gxcost) * double.Parse(Gxslcost) * double.Parse(Gxcdcost) + double.Parse(Gbcost)+ double.Parse(Flcost);
            Yclcost = a.ToString(Properties.Settings.Default.Num);//a.ToString(NewDbHelper.GetSettings("MathNum:Num"));
            //制造成本=原材料+计件人工+水电制造
            double b = (a + double.Parse(Jjrgcost) + double.Parse(Gtcost)) * 100 / double.Parse(Lltext);
            Zzcost = b.ToString(Properties.Settings.Default.Num);
            //出货成本=制造成本+包装人工+包材+包装均摊
            double c = b + double.Parse(Bzrgcost) + double.Parse(Bccost) +double.Parse(Bzjtcost);
            Chcost = c.ToString(Properties.Settings.Default.Num);
            WeakReferenceMessenger.Default.Send<string, string>(Zzcost,"DanViewModel");
        }



    }

}
