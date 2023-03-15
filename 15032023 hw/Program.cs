using Core.Entities;

Square square = new Square(5);
Rectangular rectangular = new Rectangular(3,6);

Console.WriteLine("sizde 3 option var: 1 - 2 - 0 arasinda secim edin");

int panelchoice = int.Parse(Console.ReadLine());

switch (panelchoice)
{
	case 0:
		Console.WriteLine(square.CalcArea());
		break;
		case 1:
			Console.WriteLine(rectangular.CalcArea());
		break;
		case 2:
		break;
	default:
		Console.WriteLine("sehf reqem");
		break;
}


