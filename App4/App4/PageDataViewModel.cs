using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App4
{
    public class PageDataViewModel 
    {
        public Type Type { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public static IList<PageDataViewModel> All { set; get; }
        public PageDataViewModel(Type type, string Title, string description)
        {
            Type = type;
            this.Title = Title;
            Description=description;
        }
        static PageDataViewModel()
        {
            All = new List<PageDataViewModel> {
                new PageDataViewModel(typeof(Page1),"bruce01","description01"),
                new PageDataViewModel(typeof(Page2),"bruce02","descrition02"),
                new PageDataViewModel(typeof(Page3), "bruce03", "description-bruce03"),
                new PageDataViewModel(typeof(Page11),"bruce10","description-bruce10"),
                new PageDataViewModel(typeof(Page12),"bruce12","description-ver"),
                new PageDataViewModel(typeof(Page13),"bruce13","desription")
        };
           
            
        }
    }
}