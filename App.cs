using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            var model = new Model.LoginModel();
            var view = new View.AppLoginView();
            var presenter = new Presenter.LoginPresenter(view, model);
        }
    }
}
