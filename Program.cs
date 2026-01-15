string[] fraudulentOrderIds = new string[10];

fraudulentOrderIds[0] = "A123";
fraudulentOrderIds[1] = "B456";     
fraudulentOrderIds[2] = "C789";
fraudulentOrderIds[3] = "D012";
fraudulentOrderIds[4] = "E345";
fraudulentOrderIds[5] = "F678";
fraudulentOrderIds[6] = "A123";
fraudulentOrderIds[7] = "B456";     
fraudulentOrderIds[8] = "C789";
fraudulentOrderIds[9] = "D012";

foreach (string orderId in fraudulentOrderIds)
{
    if(orderId.ToLower().StartsWith("a") || orderId.StartsWith("B"))
    {
        Console.WriteLine(orderId);
    } else
    {
        Console.WriteLine("Not a fraudulent order ID.");
    }
}