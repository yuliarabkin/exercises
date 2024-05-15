using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerical
{
    internal class NumericalExpression
    {
        private int _num;
        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] between10to20 = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "Seventeen", "eighteen", "nineteen" };

        public NumericalExpression(int num) 
        { 
            _num = num;
        }

        public override string ToString()
        {
            string numInWords = "";
            int numTemp = _num;

            if(numTemp >= 1 && numTemp <= 9)
            {
                return units[numTemp];
            }
            if (numTemp/ 1000000000 >= 1)
            {
                numInWords += TurnNumToWords(numTemp / 1000000000) + " billion ";
                numTemp = numTemp % 1000000000;
            }
            if (numTemp/ 1000000 >= 1)
            {
                numInWords += TurnNumToWords(numTemp / 1000000) + " million ";
                numTemp = numTemp % 1000000;
            }
            if(numTemp/ 1000 >= 1)
            {
                numInWords += TurnNumToWords( numTemp / 1000) + " Thousand ";
                numTemp = numTemp % 1000;
            }
            if (numTemp / 100 >= 1)
            {
                numInWords += TurnNumToWords( numTemp / 100) + " hundred ";
                numTemp = numTemp % 100;
            }
            if (numTemp / 10 >= 1)
            {
                numInWords += TurnNumToWords(numTemp) + " ";
                numTemp = numTemp % 10;
            }
            return numInWords;
        }

        private string TurnNumToWords(int num)
        {
            if (num >= 100 && num <= 999)
            {
                return HundredIntoWords(num);
            }
            string numInWords = "";
            if (num >= 10 && num <= 99)
            {
                return TensIntoWords(num, numInWords);
            }
            return units[num];
        }
        private string HundredIntoWords(int num)
        {
            string numInWords = "";
            numInWords += units[num / 100] + " hundred ";
            num = num % 100;
            return TensIntoWords(num, numInWords);
        }
        private string TensIntoWords(int num, string numInWords)
        {
            if(num / 10 == 1)
            {
                return between10to20[num % 10];
            }
            numInWords += tens[num / 10] + " " + units[num % 10];
            return numInWords;
        }

        public int GetValue()
        { 
            return _num;
        }

        public static int SumLetters(int num)
        {
            int countLetters = 0;
            NumericalExpression numericalExpression = new NumericalExpression(1);
            for (int i = 2; i <= num + 1; i++)
            {
                foreach(char letter in numericalExpression.ToString())
                {
                    if (letter != ' ')
                    {
                        countLetters++;
                    }
                }
                numericalExpression = new NumericalExpression(i);
            }
            return countLetters;
        }

        //פולימורפיזם - בגלל עצם השימוש בהעמסה של שתי פונקציות בעלות אותו השם
        public static int SumLetters(NumericalExpression numericalExpression)
        {
            int countLetters = 0;
            for (int i = numericalExpression._num; i > 0 ; i--)
            {
                foreach (char letter in numericalExpression.ToString())
                {
                    if (letter != ' ')
                    {
                        countLetters++;
                    }
                }
                numericalExpression = new NumericalExpression(i);
            }
            return countLetters;
        }
    }
}
