using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Params
    {
        public double V1 { get; set; }
        public double V2 { get; set; }
        public double alpha { get; set; }
        public double alpha1 { get; set; }
        public double beta { get; set; }
        public double beta1 { get; set; }
        public double mu { get; set; }
        public double mu1 { get; set; }
        public double h { get; set; }
        public double a1 { get; set; }
        public double a2 { get; set; }
        public double b1 { get; set; }
        public double b2 { get; set; }

    }
}
