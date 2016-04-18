using GalaSoft.MvvmLight;

namespace XBMCRemoteWP.Models
{
    public class ConnectionItem : ViewModelBase
    {
        private int connectionId;
        public int ConnectionId
        {
            get { return connectionId; }
            set { Set(ref connectionId, value); }
        }

        private string connectionName;
        public string ConnectionName
        {
            get { return connectionName; }
            set { Set(ref connectionName, value); }
        }
        
        private string ipAddress;
        public string IpAddress
        {
            get { return ipAddress; }
            set { Set(ref ipAddress, value); }
        }

        private int port;
        public int Port
        {
            get { return port; }
            set { Set(ref port, value); }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { Set(ref username, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }      
    }
}

