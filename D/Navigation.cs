using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace D
{
    public class Navigation
    {

        //Навигация между страницами
     public static Frame CurrentFrame {  get; set; }
        public static Window Root {  get; set; }
    }
}
