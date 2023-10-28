using AlarmClock.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock.forms
{
    public partial class AwakeForm : Form
    {

        private const string FolderName = "images";

        private List<string> _filenames = new List<string>();

        private int _imageIndex = 0;

        public SettingsModel Model { get; set; }

        public AwakeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AwakeForm_Load(object sender, EventArgs e)
        {
            AwakeLabel.Text = Model.AlarmMessage;
        }

        private void InitializeImages()
        {
            _filenames.Clear();
            _filenames.AddRange(Directory.EnumerateFiles(FolderName));
            AwakePictureBox.Load(_filenames[_imageIndex]);
        }

        private void AwakeButton_Click(object sender, EventArgs e)
        {
            Model.IsAlarmOn = false;
            Close();
        }
    }
}


