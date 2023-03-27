using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace cost.ViewModels
{
    internal class ConfigViewModel: ObservableObject
    {
        public ConfigViewModel()
        {
            BtnSave = new AsyncRelayCommand<object>(myBtnSave);
        }

        public ICommand BtnSave { get; set; }
        public async Task myBtnSave(object obj)
        {
            //Properties.Settings.Default.host = Host;
            Properties.Settings.Default.Num = Num;
            Properties.Settings.Default.Save();//使用Save方法保存更改
           
            MessageBox.Success("保存成功");
        }

        private string _Host= Properties.Settings.Default.host;

        public string Host
        {
            get { return _Host; }
            set { _Host = value; }
        }

        private string _Num= Properties.Settings.Default.Num;

        public string Num
        {
            get { return _Num; }
            set { _Num = value; }
        }


    }
}
