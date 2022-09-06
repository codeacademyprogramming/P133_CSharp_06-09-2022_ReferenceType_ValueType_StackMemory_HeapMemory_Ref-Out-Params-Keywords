using System;

namespace P133Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = { 15, 20,23,25};

            //int[] nums2 = new int[5];

            //int[] nums3 = new int[] { 6,7,15};

            //nums1[15] = 15;

            //set value
            //nums1[0] = 25;

            //get value and set any variable
            //int num = nums1[2];

            //Console.WriteLine(nums1[0]);

            //Console.WriteLine(nums1.Length);

            //nums2[0] = 66;
            //nums2[1] = 77;
            //nums2[2] = 88;
            //nums2[4] = 100;

            //Console.WriteLine(nums2[3]);

            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    Console.WriteLine(nums3[i]);
            //}

            //string[] words = new string[5];

            //Console.WriteLine(words[0]);

            //string word = null;
            //string word1 = "Hello Wolrd P133";


            //int[] arr1 = nums1;

            //arr1[2] = 500;

            //Console.WriteLine(nums1[2]);
            //Console.WriteLine(arr1[2]);

            //int[] arr2 = arr1;

            //arr2[2] = 5000;

            //Console.WriteLine(nums1[2]);
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr2[2]);


            //int a = 5;

            //int b = a;

            //b += 50;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //string str = "Hello";

            //string str1 = str;
            //str1 += " P133";

            //Console.WriteLine(str);
            //Console.WriteLine(str1);

            //int num;
            //ChangeNum(out int num);

            //Console.WriteLine(num);

            //int[] arr = { 10, 20, 30 };
            //ChangeArrayElement(arr);

            //Console.WriteLine(arr[1]);


            int[] arr = { 10, 20, 30 ,7,8,15,3,9};
            int[] evensArr = { };

            //Console.WriteLine(evensArr.Length);

            //Array.Resize(ref evensArr, evensArr.Length + 1);

            //Console.WriteLine(evensArr.Length);


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Array.Resize(ref evensArr, evensArr.Length + 1);
                    evensArr[evensArr.Length - 1] = arr[i];
                }
            }

            for (int i = 0; i < evensArr.Length; i++)
            {
                Console.WriteLine(evensArr[i]);
            }

            //Array.Resize(ref arr, 5);

            //arr[3] = 40;
            //arr[4] = 50;
            ////arr[5] = 60;
            //Console.WriteLine(arr[3]);
            //Console.WriteLine(arr[4]);
        }


        static void ChangeNum(out int a)
        {
            a = 50;

            Console.WriteLine(a);
        }

        //static void ChangeArrayElement(int[] arr)
        //{
        //    arr[1] = 200;

        //    Console.WriteLine(arr[1]);
        //}
    }
}
