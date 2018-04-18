using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using OSyM.Objects;

namespace OSyM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Building building = new Building
        {
            Departments =
            {
                new Department
                {
                    DepartmentNumber = 1,
                    MeetingRoom = new MeetingSpace(),
                    Rooms =
                    {
                        new Room
                        {
                            RoomNumber = 1,
                            Lock = new InteriorLock
                            {
                                Status = true
                            },
                            Zones =
                            {
                                new Zone
                                {
                                    ZoneCode = "1A",
                                    MyLight = new Light
                                    {
                                        Brightness = 100.0,
                                        Status = true
                                    },
                                    MyVent = new Vent
                                    {
                                        Temperature = 72.0
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
