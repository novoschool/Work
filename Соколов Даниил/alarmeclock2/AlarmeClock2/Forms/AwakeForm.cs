using AlarmeClock2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmeClock2.Forms
{
    public partial class AwakeForm : Form
    {
        public SettingsModel Model { get; set; }

        private const string FolderNmae = "img";

        private List<string> FileName = new List<string>();

        private int ImageIndex = 0;

        public bool postpone = false;

        public AwakeForm()
        {
            InitializeComponent();
        }

        private void InitializeImages()
        {
            FileName.Clear();
            FileName.AddRange(Directory.EnumerateFiles(FolderNmae));
            AwakePicture.Load(FileName[ImageIndex]);
        }

        private void AwakeTimer_Tick_1(object sender, EventArgs e)
        {
            ImageIndex++;
            if (ImageIndex == FileName.Count)
            {
                ImageIndex = 0;
            }
            AwakePicture.Load(FileName[ImageIndex]);
        }

        private void AwakeForm_Load(object sender, EventArgs e)
        {
            AwakeLabel.Text = Model.AlarmMessage;
            InitializeImages();
        }

        private void Awakebutton_Click(object sender, EventArgs e)
        {
            Model.IsAlarmOn = false;
            Close();
        }

        private void PostponeButton_Click(object sender, EventArgs e)
        {
            Model.WaitingAlarmTime += new TimeSpan(0, 2, 0);
            Close();
        }
    }
}
