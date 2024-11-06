using Pilates.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates
{
    internal static class Program
    {
        public static string usuarioLogado { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.AddMessageFilter(new EscapeKeyFilter());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login telaLogin = new Login();
            Application.Run(telaLogin);
        }
    }
}
