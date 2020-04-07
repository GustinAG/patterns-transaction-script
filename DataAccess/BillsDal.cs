using System;
using TransactionScript.DataTransferObjects;

namespace TransactionScript.DataAccess
{
    public static class BillsDal
    {
        public static void SaveBill(BillDTO bill) => Console.WriteLine("Bill with {0} poducts saved.", bill.Products.Count);
    }
}
