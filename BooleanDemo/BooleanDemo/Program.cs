// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int someRandomNumber = 55;

string BooleanPositive = "Yes, the number is 55";
string BooleanNegative = "No, the number is not 55";

if(someRandomNumber == 55)
{
    //later
    Console.WriteLine(BooleanPositive);
}
else
{
    //later
    Console.WriteLine(BooleanNegative);
}


if(someRandomNumber != 55)
{
    Console.WriteLine(BooleanNegative);
}
else
{
    Console.WriteLine(BooleanPositive);
}

int beginningNumber = 1;
int endingNumber = 10;

for(int i = beginningNumber; i <= endingNumber; i++)
{
    string Sentence = $"I am Counting at Number {i}";
    Console.WriteLine(Sentence);
}