Console.WriteLine("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "aliya")
{
    Console.WriteLine("Yay, thats you! Hello there!");
}
else
{
    Console.Write(username);
    Console.WriteLine(", ahh, thats you again.");
}