using System;

namespace P13306092022ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //string word = "Salam";
            #endregion

            #region Task 2
            //Console.WriteLine("Sozu Daxil Et:");
            //string word = Console.ReadLine();
            //word = ReverseStr(word);
            //Console.WriteLine(word);
            #endregion

            #region Task 3
            //string[] arr = { "Salam", "Hello", "World" };
            char symbol = 'a';

            string test = "P133";

            string[] newArr = FilterStringCollection(symbol,"Salam","Hello","Wolrd",test);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
            #endregion
        }

        #region Task 1
        static int FindCharCount(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
            }

            return count;
        }
        #endregion

        #region Task 2
        static string ReverseStr(string str)
        {
            string reversedStr = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                reversedStr += str[i];
            }

            return reversedStr;
        }
        #endregion

        #region Task 3
        static string[] FilterStringCollection( char symbol, params string[] arr)
        {
            string[] newArr = { };

            foreach(string item in arr)
            {
                foreach (char letter in item)
                {
                    if (letter == symbol)
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1] = item;
                        break;
                    }
                }
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    string str = arr[i];

            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[j] == symbol)
            //        {
            //            Array.Resize(ref newArr, newArr.Length + 1);
            //            newArr[newArr.Length - 1] = str;
            //            break;
            //        }
            //    }
            //}

            return newArr;
        }
        #endregion
    }
}
