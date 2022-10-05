// void Method21(string arg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(arg);
//         i++;
//     }
// }



// // Method21("Text", 4);

// Method21(arg: "new Text", count: 4);

// int Method3()
// // {
// //     return DateTime.Now.Year;
// // }

// // int year = Method3();
// // Console.WriteLine(year);

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }

// // string res = Method4(9, "zu ");
// // Console.WriteLine(res);


// // string Method4(int count, string text)
// // {
// //     string result = String.Empty;
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;

// // }
// // string res = Method4(9, "zu ");
// // // Console.WriteLine(res);

// // for (int i = 2; i <= 32; i++)
// // {
// //     for (int j = 2; j <= 32; j++)
// //     {
// //         Console.WriteLine($"{i} * {j} = {i*j}");
// //     }
// //     Console.WriteLine();
// // }


// string text = "Я думаю, – сказал князь, улыбаясь, – что, "
//      + "ежели бы вас послали вместо нашего милого Винценгероде,"
//     + " вы бы взяли приступом согласие прусского короля. "
//     + "Вы так красноречивы. Вы дадите мне чаю?";

//      Console.WriteLine(text);
//      Console.WriteLine();

//      string Replace(string text, char oldValue, char newValue)
//      {
//         string result = String.Empty;
//         int lenght = text.Length;
//         for (int i = 0; i < lenght; i++)
//         {
//             if (text[i] == oldValue) result = result + $"{newValue}";
//             else result = result + $"{text[i]}";
//         }
//         return result;
//      }
//      string newText = Replace(text, ' ', '|');
//      Console.WriteLine(newText);

//      Console.WriteLine();
//      string new2Text = Replace(newText, 'к', 'К');
//      Console.WriteLine(new2Text);

//      Console.WriteLine();
//      string new3Text = Replace(new2Text, 'с', 'С');
//      Console.WriteLine(new3Text);

//     Console.WriteLine();
//     string new4Text = Replace(new3Text, ',', '!');
//     Console.WriteLine(new4Text);


int[] arr = { 1, 9, 4, 993, 2, 6, 7, 1, 1 };

void PrintArrey(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArrey(arr);
SelectionSort(arr);
PrintArrey(arr);