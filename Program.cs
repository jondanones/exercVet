using exercVet;

Estudante[] vect = new Estudante[10];

Console.Write("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++) {
    Console.WriteLine("Rent #" + i + ":");
    Console.Write("Name: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int quarto = int.Parse(Console.ReadLine());
    vect[quarto] = new Estudante { Nome = nome, Email = email };
}

Estudante p = new Estudante();

Console.WriteLine();
Console.WriteLine("Busy rooms:");

for (int i = 1; i < 10; i++) {

    if (vect[i] != null) {
        Console.WriteLine(i + ": " + vect[i]);
    }
}
