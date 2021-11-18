using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TCPServer.Command;
using TCPServer.Model;

namespace TCPServer.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {

        
        public ICommand ExecuteStartTCPServer { get; private set; }


        public MainWindowViewModel()
        {
            ExecuteStartTCPServer = new DelegateCommand<string>(RunTCPServer);
        }

        private void RunTCPServer(string command)
        {
            var server = new TCPServerModel();

            server.ServerStart(9990);

        }

    }
}
