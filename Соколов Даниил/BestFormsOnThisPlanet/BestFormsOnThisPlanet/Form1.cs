namespace BestFormsOnThisPlanet
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void a_Click(object sender, EventArgs e)
        {

            var username = textBox1.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Где тебя шлёпнуть", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var slepresult = MessageBox.Show($"Разрешите вас шлёпнуть {username}?", "Шлёпа",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (slepresult== DialogResult.Yes)
            {
                MessageBox.Show("Вас шлёпнули");
            }
            else
            {
                MessageBox.Show("Грусть(((");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
    }
}