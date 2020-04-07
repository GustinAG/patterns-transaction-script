using System.Text;
using System.Windows.Forms;
using TransactionScript.BusinessLogic;
using TransactionScript.DataTransferObjects;

namespace TransactionScript.CheckOutGUI
{
    /// <summary>
    /// The check-out form.
    /// </summary>
    public partial class CheckOutForm : Form
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TransactionScript.CheckOutGUI.CheckOutForm" /> class.
        /// </summary>
        public CheckOutForm()
        {
            InitializeComponent();
        }

        #region Static helpers
        private static void AddSummaryLine(StringBuilder builder, string name, decimal price) => builder.AppendLine($"{name,-15} €{price,5:f2}");

        private static string GenerateSummaryText(BillDTO bill)
        {
            var builder = new StringBuilder();

            foreach (var product in bill.Products) AddSummaryLine(builder, product.Name, product.Price);

            builder.AppendLine("-----------------------------------------");
            AddSummaryLine(builder, "  TOTAL", bill.TotalPrice);

            return builder.ToString();
        }
        #endregion

        /// <summary>
        /// Handles the Click event of the StartButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void StartButtonClick(object sender, System.EventArgs e)
        {
            EnableCheckOutControls(true);
            CodeNumericUpDown.Focus();

            CheckOutServices.Start();
        }

        /// <summary>
        /// Handles the Click event of the ScanButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ScanButtonClick(object sender, System.EventArgs e)
        {
            CheckOutServices.Scan((long)CodeNumericUpDown.Value);

            CodeNumericUpDown.Value = 0;
            CodeNumericUpDown.Focus();
        }

        /// <summary>
        /// Handles the Click event of the CloseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CloseButtonClick(object sender, System.EventArgs e)
        {
            BillDTO bill = CheckOutServices.Close();

            EnableCheckOutControls(false);
            Display(bill);
        }

        #region Helpers
        private void EnableCheckOutControls(bool enable)
        {
            StartButton.Enabled = !enable;
            CodeNumericUpDown.Enabled = ScanButton.Enabled = CloseButton.Enabled = enable;
            if (enable) SummaryTextBox.Text = string.Empty;
        }

        private void Display(BillDTO bill) => SummaryTextBox.Text = GenerateSummaryText(bill);
        #endregion
    }
}
