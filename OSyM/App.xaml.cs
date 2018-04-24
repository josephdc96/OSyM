using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using OSyM.Objects;
using OSyM.Forms;
using Newtonsoft.Json;
using OSyM.Requests;
using OSyM.Controllers;
using System.Windows.Threading;

namespace OSyM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Building building;
        public static Dictionary<string, Account> user = new Dictionary<string, Account>();
        public static Account loggedInUser = null;
        public static List<MainWindow> clients = new List<MainWindow>();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            building = JsonConvert.DeserializeObject<Building>(System.IO.File.ReadAllText("../../data.json"));
            user["jdc0066"] = new Account
            {
                UserName = "jdc0066",
                Password = "passw0rd",
                EmployeeObj = new BuildingManager
                {
                    FirstName = "Joseph",
                    LastName = "Cauble",
                    IDNumber = 1,
                    ZoneCode = "001A"
                }
            };

            AccountController controller = new AccountController();
            controller.requestLoginForm();
        }
    }
}
