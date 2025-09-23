// Input: "Hello World"
//Output: "olleH dlroW"

//declare the string

using System.Runtime.InteropServices;

string Input ="Hello World";

//split the string into words
string[] words=Input.Split(' ');
Console.WriteLine(string.Join(' ',words));
Console.WriteLine("Original string is:" + string.Join(' ', words));
//calculate length of wordsarray
int L = words.Length;
//reverse each word

for (int w = 0; w < L; w++)
{

    // convert each word to indivisual  character arraychar[]
    char[] chars = words[w].ToCharArray();
    int charL = chars.Length;
    for (int i=0;i<charL/2;i++) 
    {
        char temp = chars[i];
        chars[i] = chars[charL-i-1];
        chars[charL-i-1] = temp;
        
    }
    words[w] = new string(chars); // ✅ update correct word

}
Console.WriteLine("Reversed string is:"+ string.Join(' ',words));