using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTestCode
{
    public partial class Form1 : Form
    {
        public delegate string Function1(string text);
        public delegate string Function2();
        public delegate void Function3();

        public Dictionary<string, Function1> _Funcs1;
        public Dictionary<string, Function2> _Funcs2;
        public Dictionary<string, Function3> _Funcs3;

        private string[] _Modes = { "Mode1", "Mode2", "Mode3" };

        public Form1()
        {
            InitializeComponent();

            _Funcs1 = new Dictionary<string, Function1>();
            _Funcs2 = new Dictionary<string, Function2>();
            _Funcs3 = new Dictionary<string, Function3>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Funcs1.Add("Mode1", new DelegateMode1().Function1);
            _Funcs1.Add("Mode2", new DelegateMode2().Function1);
            _Funcs1.Add("Mode3", new DelegateMode3().Function1);

            _Funcs2.Add("Mode1", new DelegateMode1().Function2);
            _Funcs2.Add("Mode2", new DelegateMode2().Function2);
            _Funcs2.Add("Mode3", new DelegateMode3().Function2);

            _Funcs3.Add("Mode1", new DelegateMode1().Function3);
            _Funcs3.Add("Mode2", new DelegateMode2().Function3);
            _Funcs3.Add("Mode3", new DelegateMode3().Function3);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string mode = GetMode();
            string state = "";

            if (rdoFunction1.Checked)
                state = _Funcs1[mode](mode);
            else if (rdoFunction2.Checked)
                state = _Funcs2[mode]();
            else
                _Funcs3[mode]();

            lbResult.Text = state;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GetMode()
        {
            if (rdoMode1.Checked)
                return rdoMode1.Text;
            else if (rdoMode2.Checked)
                return rdoMode2.Text;
            else
                return rdoMode3.Text;
        }
    }
}
