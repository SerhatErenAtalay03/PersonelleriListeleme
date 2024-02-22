using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelleriListeleme
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // splash formu başlatın
            SplashEkranics splash = new SplashEkranics();
            splash.Show();
            
            // ana formun yüklenmesini beklemek için bir gecikme ekleyin
            Application.DoEvents();
            Thread.Sleep(1000); // 3 saniye bekleyiniz (simülasyon amacıyla) 
            
            // splash formu kapatın 
            splash.Close();
            
            // ana formu başlatın
            Application.Run(new Form1());


        }
    }
}
