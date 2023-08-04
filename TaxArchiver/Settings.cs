using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxArchiver
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        private void settings_Load(object sender, EventArgs e)
        {
        

            // Create the Configuration object
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            // List of settings to load
            string[] settings = new string[] { "server", "port", "database", "username", "password" };
            TextBox[] textBoxes = new TextBox[] { txt_server, txt_port, txt_database, txt_username, txt_password };

            // Load each setting
            for (int i = 0; i < settings.Length; i++)
            {
                KeyValueConfigurationElement setting = config.AppSettings.Settings[settings[i]];

                if (setting != null)
                {
                    // Set the text box value
                    textBoxes[i].Text = setting.Value;
                }
                else
                {
                    // Clear the text box if the setting doesn't exist
                    textBoxes[i].Text = "";
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            // Create the Configuration object
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            // List of settings to modify
            string[] settings = new string[] { "server", "port", "database", "username", "password" };
            TextBox[] textBoxes = new TextBox[] { txt_server, txt_port, txt_database, txt_username, txt_password };

            // Modify each setting
            for (int i = 0; i < settings.Length; i++)
            {
                KeyValueConfigurationElement setting = config.AppSettings.Settings[settings[i]];
                string textBoxText = textBoxes[i].Text;

                if (setting != null)
                {
                    // Update the setting
                    setting.Value = textBoxText;
                }
                else
                {
                    // Add the setting
                    config.AppSettings.Settings.Add(settings[i], textBoxText);
                }
            }

            // Save the configuration file
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of the changed section, if needed
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("Settings Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
