public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<Word> _hiddenWords = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsArray = text.Split(" ");
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 1; i <= numberToHide; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(_words.Count);
            } while (_hiddenWords.Contains(_words[randomIndex]) && _hiddenWords.Count < _words.Count);
            _words[randomIndex].Hide();
            _hiddenWords.Add(_words[randomIndex]);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText();
            displayText += " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;
    }

    public void ResetHidden()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
        _hiddenWords.Clear();
    }
}