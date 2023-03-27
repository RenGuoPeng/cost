using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cost.Helper;
using cost.Models;
using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace cost.ViewModels
{
    public class JTViewModel : ObservableObject
    {
        public List<table_Jt> table_Jts = new List<table_Jt>();
        table_Jt table_Jt = new table_Jt();
        public JTViewModel(string products_code,string cbtext)
        {
            BtnTou = new AsyncRelayCommand<object>(myBtnTou);
            //注册加头计算完后得数据获取
            WeakReferenceMessenger.Default.Register<object, string>(this, "TouViewModel", TouReceive);
            NewDbHelper sugar = new NewDbHelper();
           
            using (var db = sugar.db)
            {
                try
                {
                    table_Jts = DataRepository.GetBySql<table_Jt>("select * from `table_Jt` where products_code='"+ products_code + "'");
                    List<string> fieldList = table_Jts.AsEnumerable().Select(t => t.products_code).ToList<string>();
                    Dropproducts = fieldList;
                    Droptext = products_code;
                    NJtcost = cbtext;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void TouReceive(object recipient, object message)
        {
            string[] mes= message as string[];
            Toucost = mes[0].ToString();
            Cscost = mes[1].ToString();
            Debug.WriteLine(mes);
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
                table_Jt = table_Jts.Find(t => t.products_code == value);
                Rgcost = table_Jt.包装人工;
                Gtcost = table_Jt.包装公摊;
                Hccost = table_Jt.耗材费用;
                Sltext = table_Jt.数量;
                Tstext = table_Jt.头数;
            }
        }


        private string _NJtcost = "0";

        public string NJtcost
        {
            get { return _NJtcost; }
            set
            { 
                SetProperty<string>(ref _NJtcost, value);
                
            }
        }

        private string _Toucost = "0";

        public string Toucost
        {
            get { return _Toucost; }
            set 
            { 
                SetProperty<string>(ref _Toucost, value);
                CostYcl();
            }
        }


        private string _Sltext = "1";
        public string Sltext
        {
            get 
            { 
                return _Sltext; 
            }
            set 
            {
                
                SetProperty<string>(ref _Sltext, value);
                CostYcl();
            }
        }

        private string _Tstext = "0";
        public string Tstext
        {
            get
            {
                return _Tstext;
            }
            set
            {

                SetProperty<string>(ref _Tstext, value);
                //CostYcl();
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
        private string _Lvtext = "100";
        public string Lvtext
        {
            get
            {
                return _Lvtext;
            }
            set
            {

                SetProperty<string>(ref _Lvtext, value);
                CostYcl();
            }

        }

        private string _Hccost = "0";

        public string Hccost
        {
            get { return _Hccost; }
            set
            {
                SetProperty<string>(ref _Hccost, value);
              //  CostYcl();
            }
        }

        private string _Gtcost = "0";

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

        public ICommand BtnTou { get; set; }
        public async Task myBtnTou(object obj)
        {
            cost.Views.TouWindow Tou = new Views.TouWindow(Sltext, Tstext);
            Tou.Show();

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
            }

        }

        public void CostYcl()
        {
            //成本=（数量*单价+不加头成本）/良率+人工+耗材+公摊+（测试*头数）
            double a = (double.Parse(Sltext) * double.Parse(Toucost)+ double.Parse(NJtcost))*100/ double.Parse(Lvtext)+ double.Parse(Rgcost)+ double.Parse(Hccost)+ double.Parse(Gtcost)+ (double.Parse(Cscost)* double.Parse(Tstext));
            Cbtext = a.ToString(Properties.Settings.Default.Num);
            
            WeakReferenceMessenger.Default.Send<string, string>(Cbtext, "JtViewModel");
        }



    }

}
