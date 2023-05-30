namespace ScreenKeyboard
{
    public partial class Form1 : Form
    {
        /*
        Button[] buttons =
            {
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
                ApostropheButton,
                zButton,
                xButton,
                cButton,
                vButton,
                bButton,
                nButton,
                mButton,
                CommaButton,
                FullstopButton,
                QuestionMarkButton,
                BackspaceButton,
                EnterButton,
        };
        */

        public Form1()
        {
            InitializeComponent();
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
    }
}