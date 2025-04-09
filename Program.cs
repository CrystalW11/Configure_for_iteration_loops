// Write a basic for statement
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// ----------------------------------
// Change the iteration conditions

// for (int i = 0; i < 10; i--)
// {
//     Console.WriteLine(i);
// }

// -------------------------------------------
// Experiment with the iterator's pattern

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// ------------------------------------------------------
// Use the break keyword to break the iteration statement

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// ------------------------------------------------------------
// Loop through each element of an array

// string[] names = {"Alex", "Eddie", "David", "Michael"};
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// ----------------------------------------------------------------

// string[] names = {"Alex", "Eddie", "David", "Michael"};
// foreach (var name in names)
// {
//     //Can't Do this
//     if (name == "David") name = "Sammy";
// }

// ----------------------------------------------------------------
// Overcoming the limitation of the foreach statement using the for statement

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}