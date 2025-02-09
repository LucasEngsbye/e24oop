// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Exercise 7 Variables
Console.WriteLine("\n\n7 Variable");

// Exercise 7.1 Area of three circles
Console.WriteLine("\n\n7.1 Area of three circles");
Console.WriteLine("\nWrite a program that calculates the area of three circles og print it out.\nr1 = 1. r2 = 3. r3 = 5.");
Console.WriteLine("The calculation to calculate the area is: pi * r^2\n");

// Defining every radius
double radius1 = 1.0;
double radius2 = 3.0;
double radius3 = 5.0;

// Calculating the area of the three circles (calculation is:  pi * r^2)
double area1 = Math.PI * radius1 * radius1;
double area2 = Math.PI * radius2 * radius2;
double area3 = Math.PI * radius3 * radius3;

// Printing out the results of the calculations
Console.WriteLine("The results: \n");
Console.WriteLine("The area of circle one with a radius of 1 is: " + area1);
Console.WriteLine("The area of circle two with a radius of 3 is: " + area2);
Console.WriteLine("The area of circle three with a radius of 5 is: " + area3);

// Exercise 7.2 Sum of area of circles
Console.WriteLine("\n\n7.2 Sum of area of circles (Omkredsen af de tre circler");
Console.WriteLine("\nWrite a program that calculates the circumference of three circles og print it out. End with printing out the sum of every circumference" +
    "\nr1 = 1. r2 = 3. r3 = 5.");
Console.WriteLine("The calculation to calculate the circumference is: 2 * pi * r\n");

// Define new vairable
int two = 2;

// Calculating the circumference of the three circles, we do this by taking the defined radius from exercise 7.1
double circumference1 = two * Math.PI * radius1;
double circumference2 = two * Math.PI * radius2;
double circumference3 = two * Math.PI * radius3;

// Printing out the results of the calculations
Console.WriteLine("The results:\n");
Console.WriteLine("The circumference of circle one with a radius of 1 is: " + circumference1);
Console.WriteLine("The circumference of circle two with a radius of 3 is: " + circumference2);
Console.WriteLine("The circumference of circle three with a radius of 5 is: " + circumference3);

// Calculating the sum of every circumference
double circumferenceSum = circumference1 + circumference2 + circumference3;

// Printing out the sum of circumference
Console.WriteLine("\nThe sum of the circumference of the three circles is: " + circumferenceSum);

// Exercise 7.3 Celcius to Fahrenheit
Console.WriteLine("\n\n7.3 7.3 Celcius to Fahrenheit");
Console.WriteLine("\nWrite a program that calculates a Celcius temperature to Fahrenheit.\nDefine a Ceclius degree youself in a variable");
Console.WriteLine("The calculations from Celcius to Fahrenheit is: CelciusDegree * 9/5 + 32");

// Define a Celcius degree
int numb1 = 9;
int numb2 = 5;
int numb3 = 32;
int celciusDegree = 22;

// Calculating the Celcius to Fahrenheit
