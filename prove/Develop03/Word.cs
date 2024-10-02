public class Word
{
    private string _shownText;
    private string _hiddenText;
    private bool _isHidden = false;

    public Word(string text)
    {
        _shownText = text;
        foreach (char c in text)
        {
            _hiddenText += "_";
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            return _hiddenText;
        }
        else return _shownText;
    }
}