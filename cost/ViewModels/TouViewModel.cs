using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cost.Helper;
using cost.Models;
using CommunityToolkit.Mvvm.Messaging;

namespace cost.ViewModels
{
    public class TouViewModel : ObservableObject
    {
        public List<table_tou> table_Tous = new List<table_tou>();
        table_tou table_Tou = new table_tou();
        public TouViewModel(string num,string Tounum)
        {
            NewDbHelper sugar = new NewDbHelper();
           
            using (var db = sugar.db)
            {
                try
                {
                    table_Tous = DataRepository.GetBySql<table_tou>("select * from `table_tou`");
                    List<string> fieldList = table_Tous.AsEnumerable().Select(t => t.products_code).ToList<string>();
                    Dropproducts = fieldList;
                    Sltext = num;
                    Tstext = Tounum;
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
                table_Tou = table_Tous.Find(t => t.products_code == value);
                Sjcost = table_Tou.散件;
                Cxcost = table_Tou.插芯;
                Flcost = table_Tou.辅料;
                Rgcost = table_Tou.人工;
                Cscost = table_Tou.测试;
                Gtcost = table_Tou.公摊;
               
                CostYcl();
            }
        }


        private string _Sjcost = "0";

        public string Sjcost
        {
            get { return _Sjcost; }
            set
            { 
                SetProperty<string>(ref _Sjcost, value);
                
            }
        }

        private string _Cxcost = "0";

        public string Cxcost
        {
            get { return _Cxcost; }
            set 
            { 
                SetProperty<string>(ref _Cxcost, value);
               // CostYcl();
            }
        }


        private string _Flcost = "0";
        public string Flcost
        {
            get 
            { 
                return _Flcost; 
            }
            set 
            {
                
                SetProperty<string>(ref _Flcost, value);
               // CostYcl();
            }
        }

        
        private string _Rgcost = "0";
        public string Rgcost
        {
            get
            {
                return _Rgcost;
            }
            set
            {

                SetProperty<string>(ref _Rgcost, value);
              //  CostYcl();
            }

        }
        private string _Cscost = "0";
        public string Cscost
        {
            get
            {
                return _Cscost;
            }
            set
            {

                SetProperty<string>(ref _Cscost, value);
               // CostYcl();
            }

        }

        private string _Gtcost="0";

        public string Gtcost
        {
            get { return _Gtcost; }
            set
            {
                SetProperty<string>(ref _Gtcost, value);
              //  CostYcl();
            }
        }

        private string _Cbtext="0";

        public string Cbtext
        {
            get { return _Cbtext; }
            set
            {
                SetProperty<string>(ref _Cbtext, value);
               
            }
        }
        private string _Sltext = "0";

        public string Sltext
        {
            get { return _Sltext; }
            set
            {
                SetProperty<string>(ref _Sltext, value);

            }
        }
        private string _Tstext = "0";

        public string Tstext
        {
            get { return _Tstext; }
            set
            {
                SetProperty<string>(ref _Tstext, value);

            }
        }

        public void CostYcl()
        {
            //人工=人工单价*数量
            //Rgcost= (double.Parse(Rgcost) * double.Parse(Sltext)).ToString();
            //测试=测试单价*(数量+头数)
            //Cscost= (double.Parse(Cscost) * (double.Parse(Sltext)+double.Parse(Tstext))).ToString();
            //成本=散件+插芯+辅料+人工+测试+公摊
            double a = double.Parse(Sjcost)+ double.Parse(Cxcost) + double.Parse(Flcost)+ double.Parse(Rgcost)+ double.Parse(Cscost)+  double.Parse(Gtcost) ;
            Cbtext = a.ToString(Properties.Settings.Default.Num);
            
            WeakReferenceMessenger.Default.Send<object, string>(new string[] { Cbtext,Cscost }, "TouViewModel");
        }



    }

}
