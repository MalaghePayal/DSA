// Declare a string

string Input = "Hello World";


//convert this string to character arrray.

char[] InputChar = Input.ToCharArray();
Console.WriteLine("Original String Is:" + string.Join(' ', InputChar));
//calculate length of an array

int L = InputChar.Length;

for (int i =0; i < L / 2; i++) 
{
    char temp = InputChar[i];
    InputChar[i] = InputChar[L - i - 1];
    InputChar[L - i - 1] = temp;

}
Console.WriteLine("Reversed String Is:"+ string.Join(' ',InputChar));