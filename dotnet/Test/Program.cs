// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadLine();
String? inp = Console.ReadLine();
Console.WriteLine($"Hello {inp}");
if (inp == "Test") {
	Console.WriteLine("Passed");
}
else {
	Console.WriteLine("Failed");
}
Console.ReadLine();
