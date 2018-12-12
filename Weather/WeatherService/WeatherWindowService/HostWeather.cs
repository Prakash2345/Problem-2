using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WeatherWindowService
{
    public partial class HostWeather : ServiceBase
    {
        ServiceHost host;
        public HostWeather()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(WeatherService.IService1));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
