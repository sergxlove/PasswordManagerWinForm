namespace PasswordManagerWinForm
{
    public class DefaultTextForTextBox
    {
        private Dictionary<string, string> _textForTextBox = new Dictionary<string, string>()
        {
            ["t1"] = "Поиск",
            ["t2"] = "Название",
            ["t3"] = "Введите email или логин",
            ["t4"] = "Введите пароль",
            ["t5"] = "Введите url",
            ["t6"] = "Описание ..."
        };
        public string GetDefaultText(string key)
        {
            if (_textForTextBox.ContainsKey(key))
            {
                return _textForTextBox[key];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
