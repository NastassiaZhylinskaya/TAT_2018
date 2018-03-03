using System;

namespace TaskDev1
{
  /// <summary>
  /// This class for work with string and
  /// count max length same symbols.
  /// </summary>
  class Counter
  {  
    private string currentString;
   /// <summary>
   /// This method for find max length same symbols.
   /// </summary>
   /// <returns>Return the response to the task.</returns>
    public int FindMaxLengthSameSymbols()
    {
      int maxSameStringLength = 0;
      int currentSequenceLength = 0;
      char theFirstSymbol;
      for (int i = 0; i < currentString.Length - 1; i++)
      {
        theFirstSymbol = currentString[i];
        if (theFirstSymbol == currentString[i + 1])
        {
          currentSequenceLength++;
        }
        else
        {
          currentSequenceLength = 0;
        }
        if (maxSameStringLength < currentSequenceLength)
        {
          maxSameStringLength = currentSequenceLength;
          maxSameStringLength++;
        }                
      } 
     return maxSameStringLength;
    }
    /// <summary>
    /// This method gets console arguments.
    /// </summary>
    /// <param name="ourString">return our string.</param>     
    public Counter(string ourString)
    {
      currentString = ourString;
    }
  }
}