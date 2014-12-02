﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rubberduck.Config;

namespace Rubberduck.UI.Settings
{
    public partial class SettingsDialog : Form
    {
        private Configuration _config;
        private ConfigurationTreeView _treeview;
        private Control _settingsControl;

        public SettingsDialog()
        {
            InitializeComponent();

            _config = ConfigurationLoader.GetDefaultConfiguration(); //todo: get actual config
            _treeview = new ConfigurationTreeView(_config);
            _settingsControl = new TodoListSettingsControl(new TodoSettingView(new List<IToDoMarker>(_config.UserSettings.ToDoListSettings.ToDoMarkers)));
            
            this.splitContainer1.Panel1.Controls.Add(_treeview);
            this.splitContainer1.Panel2.Controls.Add(_settingsControl);

            _treeview.Dock = DockStyle.Fill;
            _settingsControl.Dock = DockStyle.Fill;

        }

        private void configurationTreeView1_Load(object sender, EventArgs e)
        {

        }

        private void todoListSettingsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
