using System;

namespace FirstStringSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string maindotString = "test.my.string.vscode";
            //Convert string with dots to string array using Split method
            string[] splittedString = maindotString.Split(".");
            //Create temp array with the same size splittedString
            string[] arrTemp = new string[splittedString.Length];

            //You can use simple two lines of code to reverse array
            //instead of using for loop
            //Array.Reverse(splittedString);
            //Console.WriteLine(string.Join(".", splittedString));

            //Assign last item of splittedArray to first item of arrTemp
            int i = 0;
            for (int j = splittedString.Length - 1; j >= 0; j--)
            {
                arrTemp[i] = splittedString[j];
                i++;
            }
            //Use below if you want to assign arrTemp to splittedArray and print it out
            //splittedString = arrTemp;
            //Console.WriteLine(string.Join(".", splittedString));

            //This will print out reversed array arrTemp
            //string.Join method will help us putting dots between them
            Console.WriteLine(string.Join(".", arrTemp));

        }
    }
}
