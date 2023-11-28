using Calculator2.Business.Models;
using Calculator2.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class CalculatorForm : Form
    {
        private CalculatorService _service = new CalculatorService();

        private CalculatorModel _model = new CalculatorModel();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Text, out var digit))
            {
                _service.AddDigit(_model, digit);
                DisplayRegister();
            }
        }

        private void DisplayRegister()
        {
            DisplayLabel.Text = _model.XRegister.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _service.Clear(_model);
            DisplayRegister();
        }
    }
}
