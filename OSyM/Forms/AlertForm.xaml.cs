using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OSyM.Controllers;

namespace OSyM.Forms
{
    /// <summary>
    /// Interaction logic for AlertForm.xaml
    /// </summary>
    public partial class AlertForm : Window
    {
        private AlertController controller;

        public AlertForm(AlertController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }
    }
}
