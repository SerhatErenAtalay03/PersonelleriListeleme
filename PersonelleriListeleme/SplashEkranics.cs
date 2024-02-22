using Microsoft.FSharp.Data.UnitSystems.SI.UnitNames;
using SplashDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PersonelleriListeleme
{
    public partial class SplashEkranics : Form
    {
        public SplashEkranics()
        {
            InitializeComponent();
        }
        private void SplashEkranics_Load(object sender, EventArgs e)
        {
        
        }
      
        public void ShowMainForm()
        {

            Thread.Sleep(1000);
            this.Close();
        }


    }

}