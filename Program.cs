using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 10 array exercises comment out each to see the result
            //Reverse String
            #region Reverse String
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //ReverseString(r);
            //void ReverseString(string str)
            //{

            //    char[] charArray = str.ToCharArray();
            //    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            //    {
            //        charArray[i] = str[j];
            //        charArray[j] = str[i];
            //    }
            //    string reversedstring = new string(charArray);
            //    Console.WriteLine(reversedstring);
            //    Console.ReadKey(); 
            //}
            #endregion/Reverse String

            //check Palindrome
            #region check Palindrome
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //chkPalindrome(r);
            //void chkPalindrome(string str)
            //{
            //    bool flag = false;
            //    for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            //    {
            //        if (str[i] != str[j])
            //        {
            //            flag = false;
            //            break;
            //        }
            //        else
            //            flag = true;
            //    }
            //    if (flag)
            //    {
            //        Console.WriteLine("Palindrome");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Palindrome");
            //        Console.ReadKey();
            //    }
            //}
            #endregion/check Palindrome

            //Reverse WordOrder
            #region Reverse WordOrder
            //using System.Text;
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //ReverseWordOrder(r);

            //void ReverseWordOrder(string str)
            //{
            //    int i;
            //    System.Text.StringBuilder reverseSentence = new StringBuilder();

            //    int Start = str.Length - 1;
            //    int End = str.Length - 1;

            //    while (Start > 0)
            //    {
            //        if (str[Start] == ' ')
            //        {
            //            i = Start + 1;
            //            while (i <= End)
            //            {
            //                reverseSentence.Append(str[i]);
            //                i++;
            //            }
            //            reverseSentence.Append(' ');
            //            End = Start - 1;
            //        }
            //        Start--;
            //    }

            //    for (i = 0; i <= End; i++)
            //    {
            //        reverseSentence.Append(str[i]);
            //    }
            //    Console.WriteLine(reverseSentence.ToString());
            //    Console.ReadKey(); 
            //}
            #endregion/Reverse WordOrder

            //reverse word in sentences
            #region ReverseWords
            //using System.Text;
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //ReverseWords(r);

            // void ReverseWords(string str)
            //{
            //    StringBuilder output = new StringBuilder();
            //    List<char> charlist = new List<char>();

            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] == ' ' || i == str.Length - 1)
            //        {
            //            if (i == str.Length - 1)
            //                charlist.Add(str[i]);
            //            for (int j = charlist.Count - 1; j >= 0; j--)
            //                output.Append(charlist[j]);

            //            output.Append(' ');
            //            charlist = new List<char>();
            //        }
            //        else
            //            charlist.Add(str[i]);
            //    }
            //    Console.WriteLine(output.ToString());
            //    Console.ReadKey(); 
            //}
            #endregion/ReverseWords

            //Count character
            #region Countcharacter
            //using System.Text;
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //Countcharacter(r);

            //void Countcharacter(string str)
            //{
            //    Dictionary<char, int> characterCount = new Dictionary<char, int>();

            //    foreach (var character in str)
            //    {
            //        if (character != ' ')
            //        {
            //            if (!characterCount.ContainsKey(character))
            //            {
            //                characterCount.Add(character, 1);
            //            }
            //            else
            //            {
            //                characterCount[character]++;
            //            }
            //        }

            //    }
            //    foreach (var character in characterCount)
            //    {
            //        Console.WriteLine("{0} - {1}", character.Key, character.Value);
            //        Console.ReadKey(); 
            //    }
            //}
            #endregion/Countcharacter

            //remove duplicate
            #region removeduplicate
            //using System.Text;
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //removeduplicate(r);

            //void removeduplicate(string str)
            //{
            //    string result = string.Empty;

            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (!result.Contains(str[i]))
            //        {
            //            result += str[i];
            //        }
            //    }
            //    Console.WriteLine(result);
            //    Console.ReadKey();  
            //}
            #endregion/removeduplicate

            //find all substring
            #region findallsubstring
            //using System.Text;
            //Console.WriteLine("please write:");
            //string r = Console.ReadLine();
            //findallsubstring(r);

            //void findallsubstring(string str)
            //{
            //    for (int i = 0; i < str.Length; ++i)
            //    {
            //        StringBuilder subString = new StringBuilder(str.Length - i);
            //        for (int j = i; j < str.Length; ++j)
            //        {
            //            subString.Append(str[j]);
            //            Console.Write(subString + " ");
            //            Console.ReadKey(); 
            //        }
            //    }
            //}
            #endregion/findallsubstring

            //Rotate Left
            #region RotateLeft
            //using System.Text;
            //int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //RotateLeft(input);
            // void RotateLeft(int[] array)
            //{

            //    int size = array.Length;
            //    int temp;
            //    for (int j = size - 1; j > 0; j--)
            //    {
            //        temp = array[size - 1];
            //        array[array.Length - 1] = array[j - 1];
            //        array[j - 1] = temp;
            //    }

            //    foreach (int num in array)
            //    {
            //        Console.Write(num + " ");
            //        Console.ReadKey(); 
            //    }
            //}
            #endregion/RotateLeft

            ///These two ends are written today 16.07.2022
          
            //find Max Number
            #region find Max Number

            //int[] ArrayNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //findMaxNum(ArrayNumber);

            //void findMaxNum(int[] ArryNum)
            //{
            //    int MaxNum=0;

            //    for (int i = 0; i < ArryNum.Length; i++)
            //    {

            //        if (MaxNum < ArryNum[i])
            //        {
            //            MaxNum = ArryNum[i];
            //        }

            //    }
            //    Console.WriteLine($"The Max Number in this Array is :{ MaxNum}");
            //    Console.ReadKey(); 
            //}
            #endregion/find Max Number

            //find duplicate
            #region findDuplicate

            int[] ArrayNumber = { 1, 2, 3, 4, 5, 4, 6, 7, 8, 9 };
            FindDuplicate(ArrayNumber);

            void FindDuplicate(int[] ArryNum)
            {
                int Temp = 0;
                bool flag = false;

                for (int i = 0; i < ArryNum.Length; i++)
                {
                    Temp = ArryNum[i];
                    for (int j = i + 1; j < ArryNum.Length; j++)
                    {
                        if (Temp == ArryNum[j])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{Temp} is repeted in the Array");
                Console.ReadKey();  
            }
            #endregion/findDuplicate
        }
    }
}
