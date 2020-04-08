using System;
using TransactionScript.DataTransferObjects;

namespace TransactionScript.DataAccess
{
    public static class BillsDal
    {
        public static void SaveBill(BillDTO bill) => Console.WriteLine($"Bill with {bill.Products.Count} products saved.");
    }
}
