namespace ScreenKeyboard
{

    public partial class Form1 : Form
    {
        private Button[] letterButtons;
        private bool isUpperEnabled = false;

        public Form1()
        {
            InitializeComponent();

            letterButtons = new Button[] {
                qButton,
                wButton,
                eButton,
                rButton,
                tButton,
                yButton,
                uButton,
                iButton,
                oButton,
                pButton,
                aButton,
                sButton,
                dButton,
                fButton,
                gButton,
                hButton,
                jButton,
                kButton,
                lButton,
                zButton,
                xButton,
                cButton,
                vButton,
                bButton,
                nButton,
                mButton,
            };
        }

        private void BackSpaceClick(object sender, EventArgs e)
        {
            if (this.InputTextBox.Text.Length == 0)
                return;

            int textLength = this.InputTextBox.Text.Length;
            this.InputTextBox.Text = this.InputTextBox.Text[..(textLength - 1)];
        }

        private void EnterClick(object sender, EventArgs e)
        {
            this.InputTextBox.Text = "";
        }

        private void SymbolButtonClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            this.InputTextBox.Text += currentButton.Text;
        }

        private void ToUpperButtonClick(object sender, EventArgs e)
        {
            Button toUpperButton = (Button)sender;

            if (isUpperEnabled == false)
            {
                foreach (var button in letterButtons)
                    button.Text = button.Text.ToUpper();

                isUpperEnabled = true;
                return;
            }

            foreach (var button in letterButtons)
                button.Text = button.Text.ToLower();

            isUpperEnabled = false;
        }

    }
}