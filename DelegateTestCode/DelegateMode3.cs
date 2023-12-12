using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTestCode
{
    public class DelegateMode3
    {
        public string Function1(string text)
        {
            return $"델리게이트 Mode3: {text}";
        }

        public string Function2()
        {
            return "델리게이트 Mode3";
        }

        public void Function3()
        {
            MessageBox.Show("델리게이트 Mode3");
        }
    }
}
