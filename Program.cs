using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*            var view = new View.Login();
                        var model = new Model.LoginModel();
                        var presenter = new Presenter.LoginPresenter(view, model);
                        Application.Run(view);*/
            //to mi sluzy do stestowania co działa w nowym widoku
            var view = new View.UserSettings.UserSettings();
            var model = new Model.User();
            var presenter = new Presenter.UserSettingsPresenter(view, model);
            Application.Run(new Form1());
        }
    }
}
