
// declare intteger array

int[] Numbers = {1,2,3,4,5,6,7,8 };
Console.WriteLine("Original Array is:" + string.Join(' ', Numbers));
//calculate length of an array

int L = Numbers.Length;

for (int i = 0; i < L / 2; i++)
{ 

    int temp = Numbers[i];
    Numbers[i] = Numbers[L - i - 1];
    Numbers[L - i - 1] = temp;

}
Console.WriteLine("Reverse Array is:"+string.Join(' ',Numbers));