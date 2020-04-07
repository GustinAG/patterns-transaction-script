using System.Collections.Generic;

namespace TransactionScript.DataTransferObjects
{
    public class BillDTO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillDTO"/> class.
        /// </summary>
        public BillDTO()
        {
            Products = new List<ProductDTO>();
        }

        /// <summary>
        /// Gets the list of products on the bill.
        /// </summary>
        public IList<ProductDTO> Products { get; }

        /// <summary>
        /// Gets or sets the total price of the bought products on the bill.
        /// </summary>
        public decimal TotalPrice { get; set; }
    }
}
