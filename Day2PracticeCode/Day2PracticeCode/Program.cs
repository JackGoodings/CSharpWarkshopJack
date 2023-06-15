// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//two variable that hold two different numbers

int num1 = 5;
int num2 = 10;

//use the addition operator on these two numbers

int sum = num1+ num2;

//print the sum to the console

Console.WriteLine(sum);
string fancyoutput = $"{num1} + {num2} = {sum}";
Console.WriteLine(fancyoutput);

//using the other operators on these two numbers

int difference =  num1 - num2;

string fancyoutputdifference = $"{num1} - {num2} = {difference}";
Console.WriteLine(fancyoutputdifference);

int product = num1 * num2;

string fancyoutputproduct = $"{num1} * {num2} = {product}";
Console.WriteLine(fancyoutputproduct);

int div = num1 / num2;

string fancyoutputdiv = $"{num1} / {num2} = {div}";
Console.WriteLine(fancyoutputdiv);

//do the same thing with functions

int numberoneforfuctions = 5;
int numbertwoforfuctions = 10;

//function definition

int AddTwoNumbers(int num1, int num2)
{
    int sum = num1+ num2;
    return sum;
}

//Function call

int storeResultOfAddTwoNumbersFunctionCall = AddTwoNumbers(numberoneforfuctions, numbertwoforfuctions);
string FancyoutputFunction = $"{numberoneforfuctions} + {numbertwoforfuctions} = {storeResultOfAddTwoNumbersFunctionCall}";
Console.WriteLine(FancyoutputFunction);