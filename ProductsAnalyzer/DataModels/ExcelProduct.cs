namespace ProductsAnalyzer
{
    public class ExcelProduct
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Title"/> property
        /// </summary>
        private string? mTitle;

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription;

        /// <summary>
        /// The member of the <see cref="SKU"/> property
        /// </summary>
        private string? mSKU;

        #endregion

        #region Public Properties

        /// <summary>
        /// The Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title
        /// </summary>
        public string Title 
        {
            get => mTitle ?? string.Empty;
            set => mTitle = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The SKU
        /// </summary>
        public string SKU
        {
            get => mSKU ?? string.Empty;
            set => mSKU = value;
        }

        /// <summary>
        /// The regular price
        /// </summary>
        public double RegularPrice { get; set; }

        /// <summary>
        /// The sale price
        /// </summary>
        public double SalePrice { get; set; }

        /// <summary>
        /// The product type
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// The stock status
        /// </summary>
        public string StockStatus { get; set; }

        /// <summary>
        /// The stock
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// A flag indicating whether the stock is managed or not
        /// </summary>
        public bool IsStockManaged { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExcelProduct() : base()
        {

        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return $"{Id} {Title} {SKU}";
        }

        #endregion
    }

}