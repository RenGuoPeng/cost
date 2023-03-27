using cost.Models;
using HandyControl.Controls;
using HandyControl.Tools;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using cost.Helper;

namespace cost.ViewModels
{
    public class MainWindowViewModel: ObservableRecipient
    {
       
        List<Models.微型不加头成本表> ListMode = new List<Models.微型不加头成本表>();
        Models.微型不加头成本表 ModeWei = new Models.微型不加头成本表();
        table_fa table_Fa ;
        private string _XpData;
        public string XpData
        {
            get { return _XpData; }
            set
            {
                // 这种方式只要变更就会通知，不管数值是否有变化
                //_value = value;
                //this.OnPropertyChanged();

                SetProperty<string>(ref _XpData, value);
                
                // 数据有变化才会通知
            }
        }

        private List<string> _dataList;
        public List<string> DataList
        {
            get { return _dataList; }

            set 
            {
                SetProperty<List<string>>(ref _dataList, value);
            }

        }
        private string _ProData;
        public string ProData
        {
            get { return _XpData; }
            set
            {
                // 这种方式只要变更就会通知，不管数值是否有变化
                //_value = value;
                //this.OnPropertyChanged();

                SetProperty<string>(ref _ProData, value);

                // 数据有变化才会通知
            }
        }

        static string CombilePath(string first, string second)
        {
            if (string.IsNullOrEmpty(second)) return first;

            var pathNow = first;
            if (second.StartsWith("\\"))
            {
                if (first[1] != ':')
                {
                    //如果第一个路径不是绝对路径，但是第二个路径却是 \ 开始的，那么直接返回第二个路径
                    pathNow = second;
                }
                else
                {
                    //第二个是绝对路径
                    pathNow = string.Format("{0}:{1}", first[0], second);
                }
            }
            else
            {
                pathNow = string.Concat(first, first.EndsWith("\\") ? "" : "\\", second);
            }
            Console.WriteLine(pathNow);
            //如果没有向上返回等字符，那么直接返回。
            if (pathNow.IndexOf("..") == -1) return pathNow;

            //格式化路径
            var pathArray = pathNow.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(pathArray.Length);
            foreach (var pathFragment in pathArray)
            {
                if (pathFragment == ".") continue;

                switch (pathFragment)
                {
                    case "..":
                        stack.Pop();
                        break;
                    default:
                        stack.Push(pathFragment);
                        break;
                }
            }
            pathArray = stack.ToArray();
            Array.Reverse(pathArray);
            return string.Join("\\", pathArray);
        }



        public MainWindowViewModel()
        {
           
            // 用于该模型的初始话
            //初始话command
            BtnAsynccommand = new AsyncRelayCommand<object>(myAsynccommand);
            ComSeleChange = new AsyncRelayCommand<object>(myComSeleChange);
            BtnGuan=new AsyncRelayCommand<object>(myBtnGuan);
            btnShowConfig = new AsyncRelayCommand<object>(mybtnShowConfig);
            BtnJT = new AsyncRelayCommand<object>(myBtnJT);
            var updateInfoFile = "update_c.xml";
           // var updateSrc = CombilePath(root, @"..\..\..\..\示例升级包\{0}");
           // FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple(updateSrc, updateInfoFile);
           // Updater.CheckUpdateSimple("http://192.168.31.216:8080", updateInfoFile);

            ListMode = Helper.DataRepository.GetBySql<Models.微型不加头成本表>("select * from `微型不加头成本表`");
            List<string> fieldList = ListMode.AsEnumerable().Select(t => t.products_code).ToList<string>();
            DataList = fieldList;
            //注册Fa计算完后得数据获取
            WeakReferenceMessenger.Default.Register<object, string>(this,"FaViewModel", FaReceive);
            //注册单纤计算完后得数据获取
            WeakReferenceMessenger.Default.Register<string, string>(this, "DanViewModel", DanReceive);
            //注册套管计算完后得数据获取
            WeakReferenceMessenger.Default.Register<string, string>(this, "TaoViewModel", TaoReceive);
            //注册加头计算完后得数据获取
            WeakReferenceMessenger.Default.Register<string, string>(this, "JtViewModel", JtReceive);
        }
        
        public void FaReceive(object recipient, object message)
        {
            Facost = ((object[])message)[0].ToString();
            table_Fa = (table_fa)((object[])message)[1];
            Debug.WriteLine(message);
        }
        public void DanReceive(object recipient, string message)
        {
            Dancost = message;
            Debug.WriteLine(message);
        }
        public void TaoReceive(object recipient, string message)
        {
            Taocost = message;
            Debug.WriteLine(message);
        }
        public void JtReceive(object recipient, string message)
        {
            Jtcost = message;
            Debug.WriteLine(message);
        }


        public ICommand BtnAsynccommand { get; set; }
        public async Task myAsynccommand(object obj)
        {
            
            if (!string.IsNullOrEmpty(Comtext))
            {
                cost.Views.FA fA = new cost.Views.FA(table_Fa);
               
                fA.Show();
            }

        }
        private string _Comtext;

        public string Comtext
        {
            get 
            { 
                return _Comtext; 
            }
            set
            {
                _Comtext = value;
                ModeWei=ListMode.Find(t=>  t.products_code == value);
                Xpcost = ModeWei.芯片成本;
                Ggcost = ModeWei.钢管堵头成本;
                Flcost = ModeWei.辅料;
                Jjrgcost = ModeWei.计件人工;
                Gtcost = ModeWei.费用公摊;
                //Bzrgcost = ModeWei.简包人工;
                //Bzjtcost = ModeWei.简包公摊;
                //Bccost = ModeWei.简包材料;
                CostBz(IsCheck);
                CostYcl();
            }
        }

        public ICommand ComSeleChange { get; set; }
        public async Task myComSeleChange(object obj)
        {
            if (!string.IsNullOrEmpty(Comtext))
            {
                cost.Views.Dan dan = new cost.Views.Dan(Comtext);
                dan.Show();
            }
            
        }
        public ICommand BtnGuan { get; set; }
        public async Task myBtnGuan(object obj)
        {
           
            if (!string.IsNullOrEmpty(Comtext))
            {
                cost.Views.TaoWindow Tao = new cost.Views.TaoWindow(Comtext);
                Tao.Show();
            }
        }
       
        public ICommand BtnJT { get; set; }
        public async Task myBtnJT(object obj)
        {
            if (!string.IsNullOrEmpty(Comtext))
            {
                cost.Views.JtWindow jt = new Views.JtWindow(Comtext,Cbcost);
                jt.Show();
            }
           

        }

        public ICommand btnShowConfig { get; set; }
        public async Task mybtnShowConfig(object obj)
        {
            cost.Views.Config cf = new Views.Config();
            cf.ShowDialog();


        }

        /// <summary>
        /// 芯片成本
        /// </summary>
        private string _Xpcost = "0";

        public string Xpcost
        {
            get
            {
                return _Xpcost;
            }
            set
            {
                SetProperty<string>(ref _Xpcost, value);
            }
        }
        /// <summary>
        /// 钢管+堵头成本
        /// </summary>
        private string _Ggcost = "0";

        public string Ggcost
        {
            get
            {
                return _Ggcost;
            }
            set
            {
                SetProperty<string>(ref _Ggcost, value);
            }
        }
        /// <summary>
        /// 辅料
        /// </summary>
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
            }
        }
        /// <summary>
        /// 计件人工
        /// </summary>
        private string _Jjrgcost="0";

        public string Jjrgcost
        {
            get
            {
                return _Jjrgcost;
            }
            set
            {
                SetProperty<string>(ref _Jjrgcost, value);
            }
        }
        /// <summary>
        /// 费用公摊
        /// </summary>
        private string _Gtcost="0";

        public string Gtcost
        {
            get
            {
                return _Gtcost;
            }
            set
            {
                SetProperty<string>(ref _Gtcost, value);
            }
        }

        /// <summary>
        /// Fa成本
        /// </summary>
        private string _Facost = "0";

        public string Facost
        {
            get
            {
                return _Facost;
            }
            set
            {
                SetProperty<string>(ref _Facost, value);
                CostYcl();
            }
        }

        /// <summary>
        /// 单纤成本
        /// </summary>
        private string _Dancost = "0";

        public string Dancost
        {
            get
            {
                return _Dancost;
            }
            set
            {
                SetProperty<string>(ref _Dancost, value);
                CostYcl();
            }
        }

        /// <summary>
        /// 套管成本
        /// </summary>
        private string _Taocost = "0";

        public string Taocost
        {
            get
            {
                return _Taocost;
            }
            set
            {
                SetProperty<string>(ref _Taocost, value);
                CostYcl();
            }
        }

        /// <summary>
        /// 连接头成本
        /// </summary>
        private string _Toucost = "0";

        public string Toucost
        {
            get
            {
                return _Toucost;
            }
            set
            {
                SetProperty<string>(ref _Toucost, value);
            }
        }

        /// <summary>
        /// 加头成本
        /// </summary>
        private string _Jtcost = "0";

        public string Jtcost
        {
            get
            {
                return _Jtcost;
            }
            set
            {
                SetProperty<string>(ref _Jtcost, value);
            }
        }

        /// <summary>
        /// 分路器良率
        /// </summary>
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

        /// <summary>
        /// 原材料
        /// </summary>
        private string _Yclcost = "0";

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

        /// <summary>
        /// 成本
        /// </summary>
        private string _Cbcost = "0";

        public string Cbcost
        {
            get
            {
                return _Cbcost;
            }
            set
            {
                SetProperty<string>(ref _Cbcost, value);
            }
        }

       
        private string _Bzrgcost = "0";

        public string Bzrgcost
        {
            get
            {
                return _Bzrgcost;
            }
            set
            {
                SetProperty<string>(ref _Bzrgcost, value);
            }
        }
        private string _Bccost = "0";

        public string Bccost
        {
            get
            {
                return _Bccost;
            }
            set
            {
                SetProperty<string>(ref _Bccost, value);
            }
        }
        private string _Bzjtcost = "0";

        public string Bzjtcost
        {
            get
            {
                return _Bzjtcost;
            }
            set
            {
                SetProperty<string>(ref _Bzjtcost, value);
            }
        }
        private string _Chcost = "0";

        public string Chcost
        {
            get
            {
                return _Chcost;
            }
            set
            {
                SetProperty<string>(ref _Chcost, value);
            }
        }

        private Boolean isCheck = false;
        /// <summary>
        /// 单选框是否选中
        /// </summary>
        public Boolean IsCheck
        {
            get { return isCheck; }
            set
            { 
                SetProperty<Boolean>(ref isCheck, value);
                CostBz(value);
                CostYcl();
               
                
            }
        }
        public void CostBz(bool value)
        {
            if (value)
            {
                Bzrgcost = ModeWei.吸塑人工;
                Bzjtcost = ModeWei.吸塑公摊;
                Bccost = ModeWei.吸塑材料;
            }
            else
            {
                Bzrgcost = ModeWei.简包人工;
                Bzjtcost = ModeWei.简包公摊;
                Bccost = ModeWei.简包材料;
            }
        }
        public void CostYcl()
        {
            //原材料=芯片成本+Fa+单纤+钢管+套管++辅料
            double a = double.Parse(Xpcost)+ double.Parse(Facost)+ double.Parse(Dancost)+ double.Parse(Ggcost)+ double.Parse(Taocost) + double.Parse(Flcost);
            Yclcost = a.ToString(Properties.Settings.Default.Num);
            //制造成本=（芯片成本+FA+单纤+钢管+0.9套管+辅料+计件人工+公摊）*100/良率
            double b = (double.Parse(Xpcost) + double.Parse(Facost) + double.Parse(Dancost)+ double.Parse(Ggcost)+double.Parse(Taocost)+ double.Parse(Flcost)+ double.Parse(Jjrgcost)+ double.Parse(Gtcost))*100/ double.Parse(Lvtext);
            Cbcost = b.ToString(Properties.Settings.Default.Num);
            //出货成本=制造成本+包装人工+包装公摊+包材
            double c = b + double.Parse(Bzrgcost) + double.Parse(Bzjtcost) + double.Parse(Bccost);
            Chcost = c.ToString(Properties.Settings.Default.Num);
        }
    }
}
