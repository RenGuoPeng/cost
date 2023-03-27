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
    public class TaoViewModel : ObservableObject
    {
        public List<table_tao> table_Taos = new List<table_tao>();
        table_tao table_Tao = new table_tao();
        table_optical table_Optical = new table_optical();
        public TaoViewModel(string products)
        {
            NewDbHelper sugar = new NewDbHelper();
           
            using (var db = sugar.db)
            {
                try
                {
                    table_Taos = DataRepository.GetBySql<table_tao>("select * from `table_tao` where products_code='" + products + "'");
                    List<string> fieldList = table_Taos.AsEnumerable().Select(t => t.products_code).ToList<string>();
                    Dropproducts = fieldList;
                    Droptext = products;
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
                table_Tao = table_Taos.Find(t => t.products_code == value);
                
                Djcost = table_Tao.单价;
                Sltext = table_Tao.数量;
                Srtext = table_Tao.输入根数;
            }
        }


        private string _Cdtext = "1";

        public string Cdtext
        {
            get { return _Cdtext; }
            set
            { 
                SetProperty<string>(ref _Cdtext, value);
                CostYcl();
            }
        }

        private string _Djcost = "0";

        public string Djcost
        {
            get { return _Djcost; }
            set 
            { 
                SetProperty<string>(ref _Djcost, value);
                CostYcl();
            }
        }


        private string _Cbtext="0";
        public string Cbtext
        {
            get 
            { 
                return _Cbtext; 
            }
            set 
            {
                
                SetProperty<string>(ref _Cbtext, value);
                
            }
        }

        
        private string _Cd2text = "1";
        public string Cd2text
        {
            get
            {
                return _Cd2text;
            }
            set
            {

                SetProperty<string>(ref _Cd2text, value);
                CostYcl();
            }

        }
        private string _Sltext = "2";
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

        private string _Srtext = "1";
        public string Srtext
        {
            get
            {
                return _Srtext;
            }
            set
            {

                SetProperty<string>(ref _Srtext, value);
                CostYcl();
            }

        }

        public void CostYcl()
        {
            if (true)
            {
                //成本=数量*单价*输出长度+单价*输入长度*根数
                double a = double.Parse(Djcost) * double.Parse(Sltext) * double.Parse(Cd2text) + double.Parse(Djcost) * double.Parse(Cdtext) * double.Parse(Srtext);
                Cbtext = a.ToString(Properties.Settings.Default.Num);
            }
            else
            {
                //成本=数量*单价*输出长度+单价*输入长度*2
                double a = double.Parse(Djcost) * double.Parse(Sltext) * double.Parse(Cd2text) + double.Parse(Djcost) * double.Parse(Cdtext) * double.Parse(Srtext);
                Cbtext = a.ToString(Properties.Settings.Default.Num);
            }
           
            
            WeakReferenceMessenger.Default.Send<string, string>(Cbtext, "TaoViewModel");
        }



    }

}
