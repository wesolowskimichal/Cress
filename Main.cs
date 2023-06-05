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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            var view = loginViewController1;
            var model = new Model.LoginModel();
            var presenter = new Presenter.LoginPresenter(view, model);
        }
    }
}
