using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cost.Models
{
    public class MessengerA: ObservableRecipient
    {
        public MessengerA()
        { 
        }
        public static string Facost { get; set; }

        public static string Dancost { get; set; }

        //private string _Dancost = "0";
        //public string Dancost
        //{
        //    get
        //    {
        //        return _Dancost;
        //    }
        //    set
        //    {

        //        SetProperty<string>(ref _Dancost, value);
        //    }

        //}

        //private string _Facost = "0";
        //public string Facost
        //{
        //    get
        //    {
        //        return _Facost;
        //    }
        //    set
        //    {

        //        SetProperty<string>(ref _Facost, value);
        //    }

        //}
    }
}
