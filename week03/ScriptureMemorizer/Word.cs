// keeps track of a single word and whether it is shown or hidden
// methods to either show or hide the word
// Hide() : void
// Show() : void
// IsHidden() : bool
// GetDisplayText() : string

// _text : string
// _isHidden : bool

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
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
        string returnText = "";

        if (_isHidden)
        {
            for (int i = 0; i < _text.Length; i++)
            {
                returnText += "_";
            }
        }
        else
        {
            returnText = _text;
        }

        return returnText;
    }

}