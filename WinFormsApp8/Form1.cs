using System;
using System.Drawing;
using System.Windows.Forms;

namespace UbegayushayaKnopka
{
    public partial class Form1 : Form
    {
        private Button runawayButton;

        public Form1()
        {
            InitializeComponent();
            InitializeRunawayButton();
        }

        private void InitializeRunawayButton()
        {
            runawayButton = new Button();
            runawayButton.Text = "ֽאזלט לוםÿ!";
            runawayButton.Size = new Size(100, 50);
            runawayButton.Location = GetRandomLocation();
            runawayButton.MouseEnter += RunawayButton_MouseEnter;

            Controls.Add(runawayButton);
        }

        private void RunawayButton_MouseEnter(object sender, EventArgs e)
        {
            MoveRunawayButton();
        }

        private void MoveRunawayButton()
        {
            runawayButton.Location = GetRandomLocation();
        }

        private Point GetRandomLocation()
        {
            Random random = new Random();
            int x = random.Next(0, ClientSize.Width - runawayButton.Width);
            int y = random.Next(0, ClientSize.Height - runawayButton.Height);
            return new Point(x, y);
        }

    }
}
