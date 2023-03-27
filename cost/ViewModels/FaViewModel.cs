using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cost.Helper;
using cost.Models;
using CommunityToolkit.Mvvm.Messaging;
using cost.DataModels;

namespace cost.ViewModels
{
    public class FaViewModel : ObservableObject
    {
        public List<table_fa> table_Fas = new List<table_fa>();
        table_fa table_Fa=new table_fa() ;

        public FaViewModel(table_fa products)
        {
            //判断是否是第二次进入

            NewDbHelper sugar = new NewDbHelper();

            using (var db = sugar.db)
            {
                try
                {
                    //table_Tous.Find(t => t.products_code == value);
                    table_Fas = db.Queryable<table_fa>().Includes(x => x.optical_code).ToList();
                    List<string> fieldList = table_Fas.AsEnumerable().Select(t => t.products_code).ToList<string>();
                    Dropproducts = fieldList;
                    

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
                
                table_Fa = table_Fas.Find(t => t.products_code == value);
               
                myFa = table_Fa;
                Gbcost = table_Fa.盖板;
                Jjrgcost = table_Fa.计件人工成本;
                Gtcost = table_Fa.费用公摊;
                Bzrgcost = table_Fa.包装人工;
                Bccost = table_Fa.包材;
                Bzjtcost = table_Fa.包装均摊;
                Gxslcost = table_Fa.带纤数量;
                Flcost = table_Fa.头胶辅料;
                //Lltext = table_Fa.自用良率;
                //Gxcdcost = table_Fa.光纤长度;
                //Flcost = table_Fa.头胶;
                List<string> fieldList = table_Fa.optical_code.AsEnumerable().Select(t => t.optical_name).ToList<string>();
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
                    Gxcost = table_Fa.optical_code.Find(t => t.optical_name == _DropListtext).price_no_tax;
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
                table_Fa.光纤长度 = value;
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

        private string _Flcost = "0";
        public string Flcost
        {
            get { return _Flcost; }
            set
            {
                bool b = SetProperty<string>(ref _Flcost, value);
                //table_Fa.头胶 = value;
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
                table_Fa.自用良率=value;
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

        private table_fa _myFa;

        public table_fa myFa
        {
            get { return _myFa; }
            set 
            {
                _myFa = value;
                OnPropertyChanged("myFa");
            }
        }


        public void CostYcl()
        {
            //原材料=光纤价格*光纤数量*光纤长度+盖板+辅料
            double a = double.Parse(Gxcost) * double.Parse(Gxslcost) * double.Parse(Gxcdcost) + double.Parse(Gbcost) + double.Parse(Flcost);
            Yclcost = a.ToString(Properties.Settings.Default.Num);
            //制造成本=原材料+计件人工+水电制造
            double b = (a + double.Parse(Jjrgcost) + double.Parse(Gtcost)) * 100 / double.Parse(Lltext);
            Zzcost = b.ToString(Properties.Settings.Default.Num);
            double c = b + double.Parse(Bzrgcost) + double.Parse(Bccost) + double.Parse(Bzjtcost);
            Chcost = c.ToString(Properties.Settings.Default.Num);
           
            WeakReferenceMessenger.Default.Send<object, string>(new object[] { Zzcost,table_Fa }, "FaViewModel");
            //WeakReferenceMessenger.Default.Send<string,string>(Zzcost, "FaViewModel");
        }



    }

}
