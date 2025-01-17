﻿// Performing Basic Math Operation in C#

// Learning Objectives

/*  Perform mathematical operations on numeric values
 *  Observe implicit type conversion between strings and numeric values
 *  Temporarily convert one data type into another 
 */

using System.Security.Cryptography;

int firstNum = 12;
int secondNum = 13;

Console.WriteLine(firstNum + secondNum);

// Mix data types to force implicit type conversions

string firstName = "Bob";
int widgetsSold = 58;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets");

// In this case, the C# compiler understands that we want to
// use the + symbol to concatenate the two operands. It deduces this because
// the + symbol is surrounded by operands of string and int data types.

// C# compiler will help if whenever possible. But ideally, a programmer must be explicit about intentions

// Advance case of concatenating and adding number
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets "); // adding parentheses to be clearer of our intentions. C# compiler understands it as the addition operation of two ints, 
// rather than adding it all togehter like the previous example without parentheses
// () - overloaded operator. We want C# compiler to solve operation inside the parentheses first. 

// Recap

/*  You can perform mathematical-like addition operations on numbers.
 *  
 *  Both string concatenation and addition use the plus + symbol. 
 *  This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
 
 *  When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to 
 *  concatenate the string representation of a number for presentation purposes.

 *  You can use parentheses to define an order of operations to explicitly tell the compiler that you want to 
 *  perform certain operations before other operations.

 */


// Math Operation

int sum = 5 + 7;
int difference = 7 - 5;
int product = 5 * 7;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// using decimal data type

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal Quotient: " + decimalQuotient);

// alternative 
decimal decimalQuotient1 = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;

Console.WriteLine(decimalQuotient1);
Console.WriteLine(decimalQuotient2);

// inaccurate example

/*
int decimalQuotient = 7 / 5.0m;
int decimalQuotient = 7.0m / 5;
int decimalQuotient = 7.0m / 5.0m;
decimal decimalQuotient = 7 / 5;
*/

// Performing addition using literal decimal data

decimal Quotient = (decimal)firstNum / (decimal)secondNum;
Console.WriteLine(Quotient);

// Three uses, or overloads for the parenthesis operator: 
// Method invocation, order of operations and type casting 

// To determine remainder after int division 

Console.WriteLine("Modulus of 200 / 5: " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 %5 ));

// C# follows the same PEMDAS convention except for exponents
// although there is no exponents operator in C#, can use System.Math.Pow() method, available from .NET Class Library

// to exercise C#'s order of operation

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;

Console.WriteLine(value1);
Console.WriteLine(value2);


// Increment and decrement value

int value = 1;

// Operators like +=, -=, *=, ++, and -- are known as compound assignment operators,
// because they compound some operation in addition to assigning the result to the variable.
// The += operator is specifically termed the addition assignment operator.

value = value + 1;
Console.WriteLine("First Increment: " + value);

value += 1;
Console.WriteLine("Second Increment: " + value);

value++;
Console.WriteLine("Third Increment: " + value);


value = value - 1;
Console.WriteLine("First Decrement: " + value);

value -= 1;
Console.WriteLine("Second Decrement: " + value);

value--;
Console.WriteLine("Third Decrement: " + value);


// using variable to increment the value

int increment = 10;

value = value += increment;
Console.WriteLine(value);

// Positioning the increment and decrement operators

// ++value - increment is happened before the retrieval of the value
// value++ - increment is happened after the retrieval of the value
// likewise for --value and value--

int testValue = 1;
testValue++;

Console.WriteLine("First: " + testValue);           // display value in line 152
Console.WriteLine("Second: " + testValue++);        // display the same as previous line because it has retrieved the value but has not yet increment it
Console.WriteLine("Third: " + testValue);           // display the incremented value
Console.WriteLine("Fourth: " + (++testValue));      // incremented the number

// Challenge

int fahrenheit = 94;
decimal celcius = ((decimal)fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {celcius} Celcius");

// an even accurate way

decimal celcius1 = ((decimal)fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"The temperature is {celcius1} Celcius");



























