using System;

class Reference
{
   private string _referenceString;
   private int _chapter;
   private int _verse;
   private int _endverse;

   public Reference(string book, int chapter, int verse) 
   {
    _referenceString = $"{book} {chapter}: {verse}";
   }

   public Reference(string word, string chapter, int startverse, int endverse)
   {
    _referenceString = $"{book} {chapter}: {verse}- {endverse}":
   }

   public string GetDisplayText()
   {
     return _referenceString;
   }
}