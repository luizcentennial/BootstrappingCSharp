# Bootstrapping C#

## Module 3

### Lesson 11 - Do While

Iteration is another one of the main tasks in computer programming. Iteration means "looping", the act of doing something repeatedly for a certain number of times. It is quite useful in software development, as we are about to see in this lesson.

There are several different types of looping elements, all of which will be covered in this section. The first one, and perhaps the simplest, is the do while loop. It has a very simple structure. The basic concept is: 

- **DO** something **WHILE** a condition is true.

Let's try a simple example. Say you need to make an application that counts from 0 to 50. It is a lot of work to do ```Console.WriteLine()``` fifty times. Instead, you could reduce it to just a handful of lines by using the do while loop.

Here is what it looks like:

```csharp
// First of all, we need something to count the number of times a number will be printed on the screen.
// We create a counter element, and its initial value is zero. Zero is also the first value to be printed.
// This is to keep track of the number of times we are executing the loop.
int counter = 0;

do
{
    Console.WriteLine(counter);

    // After the counter number is printed on the screen, we need to add one to itself, in order to get the next number.
    counter = counter + 1;
}

// The whole code block inside the do statement will run repeatedly, until we stablish when to stop.
// We must state that this block must run WHILE some condition is met. In this case, WHILE counter <= 50.
while (counter <= 50);
```

This is all there is to it. If you run this code, you will see 51 lines containing all numbers from 0 to 50.

All other statements that were covered in other lessons can also be incorporated inside do while loops. For instance, let's try and write a code that will print all even numbers from 1 to 50.

```csharp
// Let's create another counter. This time, our count starts at 1.
int newCounter = 1;

do
{
    // IF the counter has an even number, display it.
    // A number is even if the remainder of its division by 2 equals 0.
    if (newCounter % 2 == 0)
    {
        Console.WriteLine(newCounter);
    }

    // Never forget to add 1 to your counter!
    newCounter = newCounter + 1;

    // In this case, there are no instructions to be done for odd numbers. So, no else is required.
}
// We repeat this code block WHILE our counter is smaller than or equal to 50.
while (newCounter <= 50);
```

Ready for a more complex example?

Let's write a code that prints even numbers normally, but prints an asterisk * right after every odd number. The range of numbers to be printed is 1 to 50.

```csharp
int lastCounter = 1;

do
{
    if (lastCounter % 2 == 0)
    {
        Console.WriteLine(lastCounter);
    }

    else
    {
        Console.WriteLine($"{lastCounter} *");
    }

    // This is another way to add 1 to your counter: 
    lastCounter++;
}
while (lastCounter <= 50);
```

**Note:** ```variable++``` is just another way of writing ```variable = variable + 1```. It's nothing but a nice shortcut!

As we advance, things start to get a little more complicated. No need to panic! Go over and over again through each lesson until you feel comfortable with every statement, and don't forget to play around with the exercises!

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                Console.WriteLine(counter);

                counter = counter + 1;
            }
            while (counter <= 50);


            int newCounter = 1;

            do
            {
                if (newCounter % 2 == 0)
                {
                    Console.WriteLine(newCounter);
                }
                newCounter = newCounter + 1;
            }
            while (newCounter <= 50);


            int lastCounter = 1;

            do
            {
                if (lastCounter % 2 == 0)
                {
                    Console.WriteLine(lastCounter);
                }

                else
                {
                    Console.WriteLine($"{lastCounter} *");
                }

                lastCounter++;
            }
            while (lastCounter <= 50);
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) Write a program that prints all multiples of 7 from 0 to 100.

2) Write a program that displays the sum of all numbers from 0 to 100.

3) Write a program that prompts the user for a number. The program must return the factorial of this number.
Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.

*****

### Lesson 12 - While Statement

The do while statement from the previous lesson was quite simple, wasn't it? Now, we can make it even simpler. It can be reduced to a simple while statement, and in that case, it will have the following philosophy:

- WHILE (something is true), repeat this code.

And then, the block of code inside the while block will run as many times as needed, until the defined condition is no longer true. Let's take a look at an example. Say we want to write a code that counts from 1 to 5.

```csharp
// Declaring counters.
int counter = 1;

// While counter is less than or equal to 5...
while (counter <= 5)
{
    // ... Do this:
    Console.WriteLine(counter);

    // Do not forget to increment the counter. You don't want an infinite loop here!
    counter++;
}
```

As you may have noticed, there is very little difference in the syntax we used in the last lesson for the do while statement. Let's see another example. Say we want to print on the screen all numbers from 1 to 10, but placing an asterisk next to the even numbers. 

```csharp
int i = 1;

while (i <= 50)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} *");
    }

    else
    {
        Console.WriteLine(i);
    }

    i++;
}
```

You may be asking yourself what the difference between do while and while is. It's simple:

- Do while statements will run first, and then again **if their condition is true**. It means they will always run at least once.
- While statements will check the condition first, and will **only run if the condition is true**. It means they may not be run at all!.

Hopefully you had no worries with the previous do while lesson, and now the while is even simpler! Don't forget to check the exploration exercises to make sure you understand the concepts of looping structures before continuing with the course.

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 5)
            {
                Console.WriteLine(counter);

                counter++;
            }

            int i = 1;

            while (i <= 50)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} *");
                }

                else
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
    }
}

```

#### EXPLORATION EXERCISES:

1) Write a program that prints all multiples of 7 from 0 to 100.

2) Write a program that displays the sum of all numbers from 0 to 100.

3) Write a program that prompts the user for a number. The program must return the factorial of this number.
Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.

*****

### Lesson 13 - For Statement

Basically, there are two types of loops. While-type loops are typically destined to applications in which you do not know exactly the number of iterations (loops) that is going to be done by the program, that is, the block of code within the loop will be repeated for an unknown number of times.

However, there are times in which you want a repeating block of code to run for an specific number of times. The for loop is the answer in this case.

Similarly to the while loop, for loops also make use of counter variables. Although, the structure is a little different, as for statements allow for more control over the looping. When writing a for statement, there are three parameters that must be declared with it:

- The number in which the counter starts;
- The number up to which the counter must go to;
- The step in which the counter increases (or decreases).

Let's take a look at an example. If we wanted to use a for loop to write a code that counts from 1 to 5, here is what it would look like:

```csharp
// Declaring counters.
int counter;

// The counter variable can be declared inside, or outside the loop definition.
// It starts at 1, and goes up to 5, increasing 1 unit at a time.
for (counter = 1; counter <= 5; counter = counter + 1)
{
    Console.WriteLine(counter);
}
```

As you may have noticed, there is very little difference in the syntax we used for while statements. Let's see another example. Say we want to print on the screen all numbers from 1 to 10, but placing an asterisk next to even numbers.

```csharp
// Let's get elegant and declare the counter inside the statement.
// The loop starts on 1, goes up to 50, one by one.
for (int i = 1; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} *");
    }

    else
    {
        Console.WriteLine(i);
    }
}
```

This is all there is to it. The statement itself is very simple, but it takes a little practice to memorize the mechanics of it. Don't forget to give it a go on the exploration exercises and get the for statement under your fingers, as they are very, very important in the daily life of a programmer.

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter;

            for (counter = 1; counter <= 5; counter = counter + 1)
            {
                Console.WriteLine(counter);
            }

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} *");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) Write a program that prints all multiples of 7 from 0 to 100.

2) Write a program that displays the sum of all numbers from 0 to 100.

3) Write a program that prompts the user for a number. The program must return the factorial of this number.
Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.

*****


### Lesson 14 - Break and Continue Statements

This lesson is going to cover a couple of very important C# keywords that gives us more control over our code. These are the ```break``` and ```continue``` statements.

They are generally used inside a looping structure, and this is what they do:

- Break: Stops the code in that particular line, breaking out of that block of code and continuing code execution outside of the loop.
- Continue: Immediately goes to the next iteraction of the loop.

These concepts might appear a little complex, but they'll make much more sense when we look at an example. Let's write a code that prints only odd numbers from 1 to 10.

```csharp
for (int counter = 1; counter <= 10; counter++)
{
    // If counter is an even number - That is, if counter divided by two has a remainder of zero:
    if (counter % 2 == 0)
    {
        // Skip this loop, and do not print anything.
        continue;
    }

    // If the code gets this far, it means that counter is an odd number.
    // In this case, print its value.
    Console.WriteLine(counter);
}
```

What happened here is, once the compiler reaches the ```continue``` statement, it jumps immediately to the beginning of the next loop. Hence, whatever comes after the ```continue``` statement will never be executed **if** the condition inside the if statement is satisfied. 

Try running the code below. Can you see the special warning being printed?

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue;
        Console.WriteLine("Special Warning: This line never gets printed!");
    }

    Console.WriteLine(i);
}
```

The special warning is not printed, because it comes **after** the ```continue``` statement. That's how it is designed to work.

Now let's try something different. Say we have two control variables, a and b. We want to run a loop 100 times, but if a becomes greater than b at some point, the loop must stop.

```csharp
int a = 0;
int b = 20;

for (int i = 1; i <= 100; i++)
{
    a++;

    if (a > b)
    {
        Console.WriteLine("The loop has been broken!");
        break;
        Console.WriteLine("Will this message be printed?");
    }

    Console.WriteLine(a);
}
```

There are many situations in which these statements come in handy. Maybe new students struggle to actually see a practical situation in which they can be used to solve a problem, but that's fine. There are a few things in life that you don't know you need it until you need it. Sounds obvious, but it couldn't be more true in this case. So, get used to the break and continue statements, and remember you have them as an option. It won't be long until you have to use them.

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int counter = 1; counter <= 10; counter++)
            {
                if (counter % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(counter);
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                    Console.WriteLine("Special Warning: This line never gets printed!");
                }

                Console.WriteLine(i);
            }

            int a = 0;
            int b = 20;

            for (int i = 1; i <= 100; i++)
            {
                a++;

                if (a > b)
                {
                    Console.WriteLine("The loop has been broken!");
                    break;
                    Console.WriteLine("Will this message be printed?");
                }

                Console.WriteLine(a);
            }
        }
    }
}
```

*****

### Congratulations!

This is the end of Module 3. Congratulations for making it this far!

Before moving to the next Module, make sure that every concept covered up to this point is really under your fingers. Things will start to get more challenging from now on, but I'm sure you're prepared!
