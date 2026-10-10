using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroClient48
{
    public partial class Form1 : Form
    {
        private bool isChanging = false;

        // Language combo button menu
        private string[] languageEN = { "English", "French", "German" };
        private string[] languageFR = { "Anglais", "Français", "Allemand" };
        private string[] languageDE = { "Englisch", "Französisch", "Deutsch" };

        //Theme combo button menu
        private string[] themeEN = { "Default", "Light", "Dark" };
        private string[] themeFR = { "Par défaut", "Clair", "Sombre" };
        private string[] themeDE = { "Standard", "Hell", "Dunkel" };

        // Grid history language
        private string[] calculateEN = { "Star Velocity", "Star Distance", "Temperature Conversion", "Event Horizon" };
        private string[] calculateFR = { "Vitesse stellaire", "Distance stellaire", "Conversion de température", "Horizon des événements" };
        private string[] calculateDE = { "Sterngeschwindigkeit", "Sternentfernung", "Temperaturumrechnung", "Ereignishorizont" };

        //Server status :[0]on , [1]off
        private string[] serverEN = { "SERVER : ON", "SERVER : OFF" };
        private string[] serverFR = { "SERVEUR : ACTIF", "SERVEUR : INACTIF" };
        private string[] serverDE = { "SERVER : AN", "SERVER : AUS" };

        //Message box & Message Label text :[0] invalid value, [1]success ,[2]temperature range,[3] kelvin range,[4] Error
        private string[] messageEN = { "Please enter a valid value." , "Calculation completed successfully." , "Temperature must be greater than -273°C.", "Kelvin temperature must be greater than zero." ,"Error:"};
        private string[] messageFR = { "Veuillez entrer une valeur valide." , "Calcul terminé avec succès." , "La température doit être supérieure à -273°C.", "La température en Kelvin doit être supérieure à zéro." ,"Erreur :"};
        private string[] messageDE = { "Bitte geben Sie einen gültigen Wert ein." ,"Berechnung erfolgreich abgeschlossen.","Die Temperatur muss größer als -273°C sein.", "Die Kelvin-Temperatur muss größer als null sein.", "Fehler: " };

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

            CheckServerConnection();


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

                if (!double.TryParse(txtObservedWavelength.Text, out double observedWavelength))
                {
                    MessageBox.Show(GetMessageculture()[0]);
                    return;
                }
                if (!double.TryParse(txtRestWavelength.Text, out double restWavelength))
                {
                    MessageBox.Show(GetMessageculture()[0]);
                    return;
                }
                
               
                IAstroContract channeling = contract();

                double velocityResult = channeling.StarVelocity(observedWavelength, restWavelength);

                txtVelocityResult.Text = velocityResult.ToString("E4");

                int rowIndex = dgvHistory.Rows.Add(
                    GetClaculateculture()[0],
                    observedWavelength + "nm," + restWavelength + "nm",
                    velocityResult.ToString("E4") + "m/s"
                    );
                dgvHistory.Rows[rowIndex].Tag = 0;

                lblError.Text = GetMessageculture()[1];
                lblError.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblError.Text = GetMessageculture()[4] + ex.Message;
                lblError.ForeColor = Color.Red;
            }

        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtParallaxAngle.Text, out double parallaxAngle))
                {
                    MessageBox.Show(GetMessageculture()[0]);
                    return;
                }

                IAstroContract channeling = contract();

                double distanceResult = channeling.StarDistance(parallaxAngle);

                txtDistanceResult.Text = distanceResult.ToString("E4");

                int rowIndex = dgvHistory.Rows.Add(
                    GetClaculateculture()[1],
                    parallaxAngle + "arcsec",
                    distanceResult.ToString("E4") + "parsecs"
                    );
                dgvHistory.Rows[rowIndex].Tag = 1;

                lblError.Text = GetMessageculture()[1];
                lblError.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                lblError.Text = GetMessageculture()[4] + ex.Message;
                lblError.ForeColor = Color.Red;
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtCelsius.Text, out double celsius))
                {
                    MessageBox.Show(GetMessageculture()[0]);
                    return;
                }
                if (celsius <= -273)
                {
                    MessageBox.Show(GetMessageculture()[2]);
                    return ;
                }

                IAstroContract channeling = contract();

                double kelvinResult = channeling.CelsiusToKelvin(celsius);
                if (kelvinResult <= 0)
                {
                    MessageBox.Show(GetMessageculture()[3]);
                    return;
                }

                txtKelvinResult.Text = kelvinResult.ToString("F2");

                int rowIndex = dgvHistory.Rows.Add(
                    GetClaculateculture()[2],
                    celsius + "C",
                    kelvinResult.ToString("F2") + "K"
                    );
                dgvHistory.Rows[rowIndex].Tag = 2;

                lblError.Text = GetMessageculture()[1];
                lblError.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                lblError.Text = GetMessageculture()[4] + ex.Message;
                lblError.ForeColor = Color.Red;
            }

        }

        private void btnEventHorizon_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtMass.Text, out double mass))
                {
                    MessageBox.Show(GetMessageculture()[0]);
                    return;
                }

                IAstroContract channeling = contract();

                double horizonResult = channeling.BlackholeEventHorizon(mass);

                txtEventHorizonResult.Text = horizonResult.ToString("E4");

                int rowIndex = dgvHistory.Rows.Add(
                    GetClaculateculture()[3],
                    mass + "kg",
                    horizonResult.ToString("E4") + "m"
                    );
                dgvHistory.Rows[rowIndex].Tag = 3;

                lblError.Text = GetMessageculture()[1];
                lblError.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                lblError.Text = GetMessageculture()[4] + ex.Message;
                lblError.ForeColor = Color.Red;
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
                ApplyFont(this, fontDialog.Font);
            }

        }

        private void ApplyFont(Control parent, Font selectedFont)
        { 
            parent.Font = selectedFont;

            foreach (Control control in parent.Controls)
            {
                ApplyFont(control, selectedFont);
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
            if (isChanging) return;

            switch (cmbLanguage.SelectedIndex)
            { 
                case 0: //English
                    picFlag.Image = Properties.Resources.UK;
                    ChangeLanguage("en-GB");
                    break;
                case 1: //French
                    picFlag.Image = Properties.Resources.French;
                    ChangeLanguage("fr-FR");
                    break;
                case 2: //German
                    picFlag.Image = Properties.Resources.German;
                    ChangeLanguage("de-DE");
                    break;
            }

        }

        private void ChangeLanguage(string culture)
        {
            //
            isChanging = true;

            //Save values that should not be overwritten
            Font font = this.Font;
            int languageIndex = cmbLanguage.SelectedIndex;
            int themeIndex = cmbTheme.SelectedIndex;

            //Apply translation
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, "$this");
            TranslatorControls(resources, this);

            //language combobox
            cmbLanguage.Items.Clear();         
            cmbTheme.Items.Clear();

            if (culture == "en-GB")
            {
                cmbLanguage.Items.AddRange(languageEN);
                cmbTheme.Items.AddRange(themeEN);

                dgvHistory.Columns[0].HeaderText ="Calculation";
                dgvHistory.Columns[1].HeaderText = "Input";
                dgvHistory.Columns[2].HeaderText = "Result";

            }
            else if (culture == "fr-FR")
            {
                cmbLanguage.Items.AddRange(languageFR);
                cmbTheme.Items.AddRange(themeFR);

                dgvHistory.Columns[0].HeaderText = "Calcul";
                dgvHistory.Columns[1].HeaderText = "Entrée";
                dgvHistory.Columns[2].HeaderText = "Résultat";

            }
            else if (culture == "de-DE")
            {
                cmbLanguage.Items.AddRange(languageDE);
                cmbTheme.Items.AddRange(themeDE);

                dgvHistory.Columns[0].HeaderText = "Berechnung";
                dgvHistory.Columns[1].HeaderText = "Eingabe";
                dgvHistory.Columns[2].HeaderText = "Ergebnis";
            }


            // Restore saved values
            this.Font = font;
            cmbLanguage.SelectedIndex = languageIndex;

            foreach(DataGridViewRow row in dgvHistory.Rows)
            {
                if (row.Tag != null)
                {
                    int claType = (int)row.Tag;
                    row.Cells[0].Value = GetClaculateculture()[claType];
                }
            }

            cmbTheme.SelectedIndex = themeIndex;

            //
            CheckServerConnection();

            isChanging = false;
        }

        private string[] GetClaculateculture()
        {
            
            if (cmbLanguage.SelectedIndex == 1) 
                return calculateFR;
            if (cmbLanguage.SelectedIndex == 2)
                return calculateDE;

            return calculateEN;

        }

        private string[] GetServerStatusculture()
        {
            if (cmbLanguage.SelectedIndex == 1)
                return serverFR;
            if (cmbLanguage.SelectedIndex == 2)
                return serverDE;

            return serverEN;
        }

        private string[] GetMessageculture()
        {
            if (cmbLanguage.SelectedIndex == 1)
                return messageFR;
            if (cmbLanguage.SelectedIndex == 2)
                return messageDE;

            return messageEN;
        }



        private void TranslatorControls(ComponentResourceManager resources, Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (!(control is TextBox))
                {
                    resources.ApplyResources(control, control.Name);
                }

                TranslatorControls(resources, control);

            }
        }

        private void CheckServerConnection()
        {
            try
            {
                IAstroContract channeling = contract();
                ICommunicationObject communication = (ICommunicationObject)channeling;

                communication.Open();

                lblServerStatus.Text = GetServerStatusculture()[0];
                lblServerStatus.ForeColor = Color.Green;

                communication.Close();

            }
            catch
            {
                lblServerStatus.Text = GetServerStatusculture()[1];
                lblServerStatus.ForeColor = Color.Red;

            }
               
        }


    }
}
