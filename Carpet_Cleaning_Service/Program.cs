namespace Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Islam's Carpet Cleaning Service
             Charges:
                 $25 per small
                 $35 per large
               Sales tax rate is 6%
             Estimates are valid for 30 days

          Prompt the user for the number of small and large rooms they would like cleaned
          and provide an estimate such as:

           Estimate for carpet cleaning service
           Number of small carpets: 3 < --
           Number of large carpets: 1 < --
           Price per small room: $25
           Price per large room: $35
           Cost: $110
           Tax: $6.6
           ===============================
          Total estimate: $116.6
          This estimate is valid for 30 days

          hint: + - * /
          */

            Console.WriteLine("Enter the number of small carpets");

            int SmallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of large carpets");
            int LargeCarpets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small carpets: $25");
            Console.WriteLine("Price per large carpets: $35");

            int cost = (SmallCarpets * 25) + (LargeCarpets * 35);
            Console.WriteLine($"Cost: {cost}");

            double tax = cost * 0.06;
            Console.WriteLine($"Tax: {tax}");
            double TotalEstimate = tax + cost;

            Console.WriteLine($"Total estimate:  {TotalEstimate} ");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
