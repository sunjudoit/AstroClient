using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroClient48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IAstroContract contract()
        {
            string localAddress = "net.pipe://localhost/AstroServer";

            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

            EndpointAddress endpoint = new EndpointAddress(localAddress);

            IAstroContract channeling = ChannelFactory<IAstroContract>.CreateChannel(binding, endpoint);

            return channeling;
        }
        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVelocity_Click(object sender, EventArgs e)
        {
            try
            {

                double observedWavelength = double.Parse(txtObservedWavelength.Text);
                double restWavelength = double.Parse(txtRestWavelength.Text);

                IAstroContract channeling = contract();

                double velocityResult = channeling.StarVelocity(observedWavelength, restWavelength);

                txtVelocityResult.Text = velocityResult.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            try
            {
                double parallaxAngle = double.Parse(txtParallaxAngle.Text);

                IAstroContract channeling = contract();

                double distanceResult = channeling.StarDistance(parallaxAngle);

                txtDistanceResult.Text = distanceResult.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(txtCelsius.Text);

                IAstroContract channeling = contract();

                double KelvinResult = channeling.CelsiusToKelvin(celsius);

                txtKelvinResult.Text = KelvinResult.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnEventHorizon_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = double.Parse(txtMass.Text);

                IAstroContract channeling = contract();

                double HorizonResult = channeling.BlackholeEventHorizon(mass);

                txtEventHorizonResult.Text = HorizonResult.ToString("E4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
