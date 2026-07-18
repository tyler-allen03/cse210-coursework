// keeps track of the both the reference and the text of the scripture. can hide words and get teh rendered display of the text
// calls the other classes and holds the scripture
// HideRandomWords(numberToHide : int) : void
//    - possible the hide and ishidden methods from words
// GetDisplayText() : string
// IsCompletelyHidden() ; bool

// _reference : Reference
// _words : List<Word>


public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] textList = text.Split(' ');
        foreach (string word in textList)
        {
            Word temp = new Word(word);

            _words.Add(temp);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }

            Random randomGenerator = new Random();
            int indexNum = randomGenerator.Next(0, _words.Count());

            if (_words[indexNum].IsHidden())
            {
                i--;
            }
            else
            {
                _words[indexNum].Hide();
            }
            

        }
        
    }

    public bool IsCompletelyHidden()
    {
        bool results = true;

        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                results = false;
            }
        }

        return results;

    }

    public string GetDisplayText()
    {
        string returnText = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words)
        {
            returnText += $"{word.GetDisplayText()} ";
        }
        return returnText;
    }

    public string GetFullScripture()
    {
        string returnText = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                word.Show();
                returnText += $"{word.GetDisplayText()} ";
                word.Hide();
            }
            else
            {
                returnText += $"{word.GetDisplayText()} ";
            }
            
        }
        return returnText;
    }
    
}