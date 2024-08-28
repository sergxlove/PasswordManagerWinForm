namespace PasswordManagerWinForm.Contracts
{
    public class ParamsValidationObject
    {
        public ParamsValidationObject(TextBox selectTextbox, Label messageLabel, int maxSymbol, int minSymbol, string defNameTextBox, string defNameLabel)
        {
            this.selectTextbox = selectTextbox;
            this.messageLabel = messageLabel;
            this.maxSymbol = maxSymbol;
            this.minSymbol = minSymbol;
            this.defNameTextBox = defNameTextBox;
            this.defNameLabel = defNameLabel;
        }

        public TextBox selectTextbox { get; set; }

        public Label messageLabel { get; set; }

        public int maxSymbol {  get; set; }

        public int minSymbol { get; set; }

        public string defNameTextBox { get; set; }

        public string defNameLabel { get; set; }
    }
}
