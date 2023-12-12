using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTestCode
{
    public class DelegateMode1
    {
        public string Function1(string text)
        {
            return $"델리게이트 Mode1: {text}";
        }

        public string Function2()
        {
            return "델리게이트 Mode1";
        }

        public void Function3()
        {
            MessageBox.Show("델리게이트 Mode1");
        }
    }
}
