using AlarmClock._0._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock._0._1.Forms1
{
    public partial class AwakeForm : Form
    {
        private const string FolderName = "Images";

        private List<string> _fileNames = new List<string>();

        private int _imageIndex = 0;

        public SettingsModel Model { get; set; }

        public AwakeForm()
        {
            InitializeComponent();
        }

        private void AwakeButton_Click(object sender, EventArgs e)
        {
            Model.IsAlarmOn = false;
            //Model.AlarmOff?.Invoke();
            Close();
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

        private void AwakeTimer_Tick(object sender, EventArgs e)
        {
            _imageIndex++;
            if (_imageIndex == _fileNames.Count)
            {
                _imageIndex = 0;
            }

            AwakePictureBox.Load(_fileNames[_imageIndex]);
        }

        private void AwakePictureBox_Click(object sender, EventArgs e)
        {
        
        }
    }
}