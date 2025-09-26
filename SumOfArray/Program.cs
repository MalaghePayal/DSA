// See https://aka.ms/new-console-template for more information

// Sum Of Array Elements
//Input: {1,2,3,4,5}
//Output: 15

//Declare array

int[] Numbers = { 1, 2, 3, 4, 5, 6,7,8,9,10};
Console.WriteLine("Input Array Is:"+ string.Join(' ',Numbers));

int L = Numbers.Length;
int sum = 0;

for (int i = 0; i < L; i++)
{
    sum = sum + Numbers[i];


}

Console.WriteLine("Sum of Elements of Input Array Is:" + string.Join(' ', sum));