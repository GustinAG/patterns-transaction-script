using System.Linq;
using TransactionScript.DataAccess;
using TransactionScript.DataTransferObjects;

namespace TransactionScript.BusinessLogic
{
    public static class CheckOutServices
    {
        private static BillDTO _currentBill;

        /// <summary>
        /// Starts a new bill.
        /// </summary>
        public static void Start()
        {
            _currentBill = new BillDTO();
        }

        /// <summary>
        /// Scans the given product onto the current bill.
        /// </summary>
        /// <param name="productCode">The product's code.</param>
        public static void Scan(long productCode)
        {
            if (_currentBill == null) return;

            ProductDTO product = ProductsDal.GetProduct(productCode);
            _currentBill.Products.Add(product);
        }

        /// <summary>
        /// Closes the current bill.
        /// </summary>
        /// <returns>The closed bill.</returns>
        public static BillDTO Close()
        {
            _currentBill.TotalPrice = _currentBill.Products.Sum(p => p.Price);
            BillsDal.SaveBill(_currentBill);

            return _currentBill;
        }
    }
}
