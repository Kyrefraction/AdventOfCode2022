# Limits of integer data types & manipulating the algorithm with the lowest common multiple.

### The problem

When getting on to part 2 of the day 11 problem, the size of the number used to represent worry will quickly overflow the limits of the int datatype (it being a signed 32-bit integer https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types).
We can start using a signed 64 bit integer, a long, but even this will be overflown. It seems that there is no data type suitable for storing the worry value. The specification gives this subtle hint to push us towards considering another solution, "You'll need to find another way to keep your worry levels manageable."

### The solution

The solution can be conceptualised once we consider what about the "worry" value is actually important. 
We don't actually have to track the real value of the worry, it's value is only used by the monkeys just to see if it is divisible by a certain number that they hold. If we can apply a transformation to the worry value that completely maintains its divisibility, but reduces the integer value, then we can avoid the datatype overflow issue.

The task then becomes finding this transformation. Ultimately we are pushed towards the modulo function, and the lowest common multiple. The transformation that satisfies what we're after is: worry = worry % lowestCommonMultiple. Let's look at an example of how this works.

### Example
Consider the following monkey set ups with just one item:
```
Monkey 0:
    Inspection function: Adds 5
    Items: [ 10 ]
    Divisible test: divisible by 3
        True: send to monkey 1
        False: send to monkey 2

Monkey 1:
    Inspection function: Multiplies by 2
    Divisible test: divisible by 2
        True: send to monkey 2
        False: send to monkey 0
  
Monkey 2:
    Inspection function: Adds 30
    Divisible test: divisible by 5
        True: send to monkey 0
        False: send to monkey 1
```

#### Without modulo

- Monkey 0 will inspect 10
- - 10 + 5 = 15
- - 15 is divisible by 3, so send to monkey 1

- Monkey 1 will inspect 15
- - 15 * 2 = 30
- - 30 is divisible by 2, so send to monkey 2

- Monkey 2 will inspect 30
- - 30 + 30 = 60
- - 60 is divisible by 5, so send to monkey 0

- Monkey 0 will inspect 60
- - 60 + 5 = 65
- - 65 is not divisible by 3, so send to monkey 2

And so on...

We can see that the worry value of the item is always increasing, considering that this example only covers one complete round, over 10,000 rounds we can see how this number will become astronomically high. Lets apply the modulo function and see how different the value is at the end.

#### Example with modulo

Let's first figure out the lowest common multiple of 2, 3 and 5. It is 30.

- Monkey 0 will inspect 10 
- - 10 + 5 = 15 
- - 15 % 30 = 15
- - 15 is divisible by 3, so send to monkey 1

- Monkey 1 will inspect 15
- - 15 * 2 = 30
- - 30 % 30 = 0
- - 0 is divisible by 2, so send to monkey 2

- Monkey 2 will inspect 0
- - 0 + 30 = 30
- - 30 % 30 = 0
- - 0 is divisible by 5, so send to monkey 0

- Monkey 0 will inspect 0
- - 0 + 5 = 5
- - 5 % 30 = 5
- - 5 is not divisible by 3, so send to monkey 2

Notice how with and without the modulo are identical apart from the actual value that is passed around. 
We're not passing the exact value anymore, but a lower value that has the exact same divisibility. We can now confidently get the number of inspections without ever worrying about an overflow.
