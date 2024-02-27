using ClockApp.forms.moderns;
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

namespace ClockApp.forms
{
    public partial class AwakeForm : Form
    {
        private const string FolderName = "images";

        private List<string> _fileNames = new List<string>();

        private int _imageIndex = 0;

        public SettingModel Model { get; set; }
        public AwakeForm()
        {
            InitializeComponent();
        }

        private void AwakeForm_Load(object sender, EventArgs e)
        {
            AwakeLabel.Text = Model.AlarmMessage;
            InitializeImages();
        }

        private void InitializeImages()
        {
            _fileNames.Clear();
            _fileNames.AddRange(Directory.EnumerateFiles(FolderName));
            AwakePictureBox.Load(_fileNames[_imageIndex]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Model.IsAlarmOn = false;
            Close();
        }

        private void AwakeTimer_Tick(object sender, EventArgs e)
        {
            _imageIndex++;
            if (_imageIndex == _fileNames.Count)
            {
                _imageIndex = 0;
            }

            AwakePictureBox.Load(_fileNames[_imageIndex]);
        }
    }
}
