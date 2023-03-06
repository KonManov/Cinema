string projectionType = Console.ReadLine();
int numberOfRows = int.Parse(Console.ReadLine());
int numberOfColumns = int.Parse(Console.ReadLine());
double totalIncome = 0;

switch(projectionType)
{
    case "Premier":
        totalIncome = (numberOfRows * numberOfColumns) * 12.00; break;
    case "Normal":
        totalIncome = (numberOfColumns * numberOfRows) * 7.50; break;
    case "Discount":
        totalIncome = (numberOfRows * numberOfColumns) * 5.00; 
        break;

        default: break;
}
Console.WriteLine($"{totalIncome:f2}");