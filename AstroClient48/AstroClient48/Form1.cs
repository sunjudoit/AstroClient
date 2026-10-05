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

            dgvHistory.Columns.Add("Calculation", "Calculation");
            dgvHistory.Columns.Add("Input", "Input");
            dgvHistory.Columns.Add("Result", "Result");

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            picFlag.Image = Properties.Resources.UK;
            cmbLanguage.SelectedIndex = 0;
            cmbTheme.SelectedIndex = 0;



        }
        private IAstroContract contract()
        {
            string localAddress = "net.pipe://localhost/AstroServer";

            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

            EndpointAddress endpoint = new EndpointAddress(localAddress);

            IAstroContract channeling = ChannelFactory<IAstroContract>.CreateChannel(binding, endpoint);

            return channeling;
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

                dgvHistory.Rows.Add(
                    "Star Velocity",
                    observedWavelength + "nm," + restWavelength + "nm",
                    velocityResult.ToString("F2") + "m/s"
                    );
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

                dgvHistory.Rows.Add(
                    "Star Distance",
                    parallaxAngle + "arcsec",
                    distanceResult.ToString("F2") + "parsecs"
                    );
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

                double kelvinResult = channeling.CelsiusToKelvin(celsius);

                txtKelvinResult.Text = kelvinResult.ToString("F2");

                dgvHistory.Rows.Add(
                    "Temperature Conversion",
                    celsius + "C",
                    kelvinResult.ToString("F2") + "K"
                    );

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

                double horizonResult = channeling.BlackholeEventHorizon(mass);

                txtEventHorizonResult.Text = horizonResult.ToString("E4");

                dgvHistory.Rows.Add(
                    "Event Horizon",
                    mass + "kg",
                    horizonResult.ToString("E4") + "m"
                    );

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Font = fontDialog.Font;
            }

        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbTheme.SelectedIndex)
            {
                case 0: // Default
                    this.BackColor = SystemColors.Control;
                    panelTopMenu.BackColor = SystemColors.GradientActiveCaption;
                    btnColor.BackColor = SystemColors.Info;
                    btnFont.BackColor = SystemColors.Info;
                    btnVelocity.BackColor = SystemColors.Info;
                    btnDistance.BackColor = SystemColors.Info;
                    btnTemperature.BackColor = SystemColors.Info;
                    btnEventHorizon.BackColor = SystemColors.Info;
                    break;

                case 1: //Light
                    this.BackColor = Color.Beige;
                    panelTopMenu.BackColor = Color.Bisque;
                    btnColor.BackColor = Color.LightBlue;
                    btnFont.BackColor = Color.LightBlue;
                    btnVelocity.BackColor = Color.LightBlue;
                    btnDistance.BackColor = Color.LightBlue;
                    btnTemperature.BackColor = Color.LightBlue;
                    btnEventHorizon.BackColor = Color.LightBlue;
                    break;

                case 2: //Dark
                    this.BackColor = Color.DarkGray;
                    panelTopMenu.BackColor = Color.SlateGray;
                    btnColor.BackColor = Color.SteelBlue;
                    btnFont.BackColor = Color.SteelBlue;
                    btnVelocity.BackColor = Color.SteelBlue;
                    btnDistance.BackColor = Color.SteelBlue;
                    btnTemperature.BackColor = Color.SteelBlue;
                    btnEventHorizon.BackColor = Color.SteelBlue;
                    break;

            }

        }

        private void cmbLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cmbLanguage.SelectedIndex)
            { 
                case 0: //English
                    picFlag.Image = Properties.Resources.UK;
                    break;
                case 1: //French
                    picFlag.Image = Properties.Resources.French;
                    break;
                case 2: //German
                    picFlag.Image = Properties.Resources.German;
                    break;
            }

        }
    }
}
