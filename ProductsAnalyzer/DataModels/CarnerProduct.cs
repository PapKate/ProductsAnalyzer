using System.Xml.Serialization;

namespace ProductsAnalyzer
{
    [XmlType("product")]
    public class CarnerProduct
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Name"/> property
        /// </summary>
        private string? mName { get; set; }

        /// <summary>
        /// The member of the <see cref="Description"/> property
        /// </summary>
        private string? mDescription { get; set; }

        /// <summary>
        /// The member of the <see cref="Brands"/> property
        /// </summary>
        private string? mBrands { get; set; }

        /// <summary>
        /// The member of the <see cref="MPN"/> property
        /// </summary>
        private string? mMPN { get; set; }

        /// <summary>
        /// The member of the <see cref="EAN"/> property
        /// </summary>
        private string? mEAN { get; set; }

        /// <summary>
        /// The member of the <see cref="Availability"/> property
        /// </summary>
        private string? mAvailability { get; set; }

        /// <summary>
        /// The member of the <see cref="CategoryTree"/> property
        /// </summary>
        private string? mCategoryTree { get; set; }

        /// <summary>
        /// The member of the <see cref="Images"/> property
        /// </summary>
        private string? mImages { get; set; }

        /// <summary>
        /// The member of the <see cref="Manufacturer"/> property
        /// </summary>
        private string? mManufacturer { get; set; }

        /// <summary>
        /// The member of the <see cref="EshopCategories"/> property
        /// </summary>
        private string? mEshopCategories { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductWeight"/> property
        /// </summary>
        private string? mProductWeight { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The id
        /// </summary>
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        [XmlElement(ElementName = "description")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The brands
        /// </summary>
        [XmlElement(ElementName = "brands")]
        public string Brands
        {
            get => mBrands ?? string.Empty;
            set => mBrands = value;
        }

        /// <summary>
        /// The MPN
        /// </summary>
        [XmlElement(ElementName = "mpn")]
        public string MPN
        {
            get => mMPN ?? string.Empty;
            set => mMPN = value;
        }

        /// <summary>
        /// The EAN
        /// </summary>
        [XmlElement(ElementName = "ean")]
        public string EAN
        {
            get => mEAN ?? string.Empty;
            set => mEAN = value;
        }

        /// <summary>
        /// The price
        /// </summary>
        [XmlElement(ElementName = "price_with_vat")]
        public double ProductPrice { get; set; }

        /// <summary>
        /// The weight
        /// </summary>
        [XmlElement(ElementName = "weight_grams")]
        public string ProductWeight
        {
            get => mProductWeight ?? string.Empty;
            set => mProductWeight = value;
        }

        /// <summary>
        /// The availability
        /// </summary>
        [XmlElement(ElementName = "availability")]
        public string Availability
        {
            get => mAvailability ?? string.Empty;
            set => mAvailability = value;
        }

        /// <summary>
        /// The category tree 
        /// </summary>
        [XmlElement(ElementName = "category_tree")]
        public string CategoryTree
        {
            get => mCategoryTree ?? string.Empty;
            set => mCategoryTree = value;
        }

        /// <summary>
        /// The images
        /// </summary>
        [XmlElement(ElementName = "images")]
        public string Images
        {
            get => mImages ?? string.Empty;
            set => mImages = value;
        }

        /// <summary>
        /// The manufacturer
        /// </summary>
        [XmlElement(ElementName = "manufacturer")]
        public string Manufacturer
        {
            get => mManufacturer ?? string.Empty;
            set => mManufacturer = value;
        }
        
        /// <summary>
        /// The eshop categories
        /// </summary>
        [XmlElement(ElementName = "EshopCategories")]
        public string EshopCategories
        {
            get => mEshopCategories ?? string.Empty;
            set => mEshopCategories = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CarnerProduct() : base()
        {

        }

        #endregion
    }
}
