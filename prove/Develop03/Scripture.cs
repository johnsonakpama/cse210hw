using System;

class Scripture
{
    private string _reference = Reference;
    private List<Word> _words = new List<Word>();

    public string Scripture(string Reference, string text)
    {
        _scripture = text;
        _reference = reference;
        string[] stringWord = text.Split();

        foreach (stringWord word in words);
        {
           Word wordobj = new Word(stringWord);
           _word.Add(stringWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
       HideRandomWords = new HideRandomWords();
       index = 0;

       do
       index = HideRandomWords.next(_word.count);

       while:
       _word[index].GetHidden() == true;
       _word[index].Hide();
    }

    public string GetDisplayText()
    {
        foreach (word d in _word);
        {
            Console.WriteLine(word.GetDisplayText() + "");
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (word w in _words);
        if(word.IsCompletelyHidden() == false);
          return false;
        else
        return true;

    }

}