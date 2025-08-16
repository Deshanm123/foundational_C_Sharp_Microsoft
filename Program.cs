
/*
    This code reverses a message, counts the number of times
    a particular character appears, then prints the results 
    to the console window
*/

string originalMessage = "the quick brown fox jumps over the lazy dog";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new string(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears  {letterCount} times");





/*
    The following Code creates five random OrderIDs to test the 
    fraud  detection process.OrderIDs consist of a letter A to  E,and a 
    three Digit number Ex-A124
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    //Get a random value that equates to ASCII leeters A through R
    int prefixValue = random.Next(65, 70);

    //convert the random value into char,  then to a string
    string prefix = Convert.ToChar(prefixValue).ToString();

    //create a randdom number,paded with zeros  this makes 36 => 036
    string suffix = random.Next(1, 1000).ToString("000");

    //Combine the prefix with suffix together , then assign to current OrderIf
    orderIDs[i] = prefix + suffix;

}

foreach(string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


/*
string[] fradulentOrderIDArr = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string order in fradulentOrderIDArr)
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine(order);
    }
}
*/

/*

int sum = 0, bin = 0;
int[] inventory = { 200, 450, 700, 175, 250 };
foreach (int num in inventory)
{
    bin++;
    sum += num; 
   Console.WriteLine($"Bin {bin} = {num} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}


string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

string[] fraudulentOrderIDs = ["A123", "B456", "C789"]; 
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");


fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First :{fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
Console.WriteLine($"There are {fraudulentOrderIDs.Count()} fraudulent orders to process.");
*/