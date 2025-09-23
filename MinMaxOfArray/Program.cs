// Input : {2,6,50,200,500,450,100}
//find minimum value from array : 2
//find maximum value from array : 500

//declare array

int[] Input = { 2, 6, 50, 200, 500, 450, 100 };
Console.WriteLine("Original Array  Is: " + string.Join(' ', Input));
int L = Input.Length;
int min = Input[0];
int max = Input[0];

for (int i = 0; i < L; i++) 
{
    if (Input[i] < min) 
    
    {
        min = Input[i];
    }

    if (Input[i]>max)
    {
        max= Input[i];
    }

}
Console.WriteLine("Mimimum value from array Is: "+ string.Join(' ',min));
Console.WriteLine("Mimimum value from array Is: " + string.Join(' ', max));