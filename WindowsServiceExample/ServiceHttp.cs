using System;
using System.ServiceProcess;
using WindowsServiceExample.Business.ServiceBusiness;

namespace WindowsServiceExample
{
    partial class ServiceHttp : ServiceBase
    {
        private bool _IsTimeOut = false;
        private readonly WindowsServiceBusiness _WindowsServiceBusinessHandler;
        public ServiceHttp()
        {
            InitializeComponent();
            _WindowsServiceBusinessHandler = new WindowsServiceBusiness();
        }

        protected override void OnStart(string[] args)
        {
            executingTimer.Start();
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        private async void executingTimer_ElapsedAsync(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_IsTimeOut) return;
            try
            {
                await _WindowsServiceBusinessHandler.MigrateData();
            }
            catch (Exception)
            {

                throw;
            }
            _IsTimeOut = false;

        }
    }
}
