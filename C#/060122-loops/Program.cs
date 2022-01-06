// mass comment / uncomment -> ctrl + k + c/u (c = comment, u = uncomment)

// writeline vypis
// int i = 0;
// Console.WriteLine("zadej slovo pro vypis");
// string UserInput = Console.ReadLine();
// Console.WriteLine("slovo obsahuje " + UserInput.Length + " znaku");
// foreach (char letter in UserInput)
// {
//     i++;
//     Console.WriteLine(i + ". " + letter);
// }

// or also.. (int i is already declared)

// for (int i = 0; i < UserInput.Length; i++) {
//     Console.WriteLine(i + ". " + UserInput[i]);
// }


// slash
// Console.WriteLine("zadej slovo pro vypis");
// string UserInput = Console.ReadLine();
// for (int i = 0; i < UserInput.Length; i++) {
//     Console.Write(UserInput[i]);
//     if (i != UserInput.Length-1) {
//         Console.Write("/");
//     }
// }


// no space
// Console.WriteLine("zadej slovo pro vypis");
// string UserInput = Console.ReadLine();
// for (int i = 0; i < UserInput.Length; i++)
// {
//     if (UserInput[i] == ' ') {}
//     else
//         Console.Write(UserInput[i]);
// }