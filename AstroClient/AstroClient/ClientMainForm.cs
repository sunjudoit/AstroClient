using System.ServiceModel;

namespace AstroClient
{
    public partial class ClientMainForm : Form
    {
        public ClientMainForm()
        {
            InitializeComponent();
        }
        /*
        private IAstroContract contract()
        {
            string localAddress = "net.pipe://localhost/AstroServer";

            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

            EndpointAddress endpoint = new EndpointAddress(localAddress);

            IAstroContract channeling = ChannelFactory<IAstroContract>.CreateChannel(binding, endpoint);
            
            return channeling;
        }
        */
        private void btnVelocity_Click(object sender, EventArgs e)
        {

        }
        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
