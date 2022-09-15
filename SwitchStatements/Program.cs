Console.WriteLine(" What is your favorite school subject?");
string subject = Console.ReadLine();
switch (subject)
{
	case "math":
		Console.WriteLine("I love math!");
		break;
	case "science":
	case "physics":
	case "biology":
		Console.WriteLine("Science is very awesome subject!");
		break ;
	case "history":
		Console.WriteLine("History is more unseful as you age!");
        break;
	case "calculus":
		Console.WriteLine("too easy amigo!");
        break;
	case "english":
		Console.WriteLine(" English is one of my favs!");
		break;
	default:
		Console.WriteLine(" I don't know that subject!");
		break;
}