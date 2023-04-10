using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductsAnalyzer
{
    [XmlType("product")]
    public class DigitalIQProduct
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
        /// The member of the <see cref="SKU"/> property
        /// </summary>
        private string? mSKU { get; set; }

        /// <summary>
        /// The member of the <see cref="Excerpt"/> property
        /// </summary>
        private string? mExcerpt { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductType"/> property
        /// </summary>
        private string? mProductType { get; set; }

        /// <summary>
        /// The member of the <see cref="Availability"/> property
        /// </summary>
        private string? mAvailability { get; set; }

        /// <summary>
        /// The member of the <see cref="CategoryTree"/> property
        /// </summary>
        private string? mCategoryTree { get; set; }

        /// <summary>
        /// The member of the <see cref="Image"/> property
        /// </summary>
        private string? mImage { get; set; }

        /// <summary>
        /// The member of the <see cref="Manufacturer"/> property
        /// </summary>
        private string? mStockStatus { get; set; }

        /// <summary>
        /// The member of the <see cref="EshopCategories"/> property
        /// </summary>
        private string? mEshopCategories { get; set; }

        /// <summary>
        /// The member of the <see cref="Brand"/> property
        /// </summary>
        private string? mBrand { get; set; }

        /// <summary>
        /// The member of the <see cref="CarBrands"/> property
        /// </summary>
        private string? mCarBrands { get; set; }

        /// <summary>
        /// The member of the <see cref="CarModels"/> property
        /// </summary>
        private string? mCarModels { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The id
        /// </summary>
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// The id
        /// </summary>
        [XmlElement(ElementName = "ParentProductID")]
        public int? ParentId { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        [XmlElement(ElementName = "Title")]
        public string Name
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        [XmlElement(ElementName = "_wpb_woo_add_info_content")]
        public string Description
        {
            get => mDescription ?? string.Empty;
            set => mDescription = value;
        }

        /// <summary>
        /// The SKU
        /// </summary>
        [XmlElement(ElementName = "SKU")]
        public string SKU
        {
            get => mSKU ?? string.Empty;
            set => mSKU = value;
        }

        /// <summary>
        /// The expert
        /// </summary>
        [XmlElement(ElementName = "Excerpt")]
        public string Excerpt
        {
            get => mExcerpt ?? string.Empty;
            set => mExcerpt = value;
        }

        /// <summary>
        /// The product type
        /// </summary>
        [XmlElement(ElementName = "ProductType")]
        public string ProductType
        {
            get => mProductType ?? string.Empty;
            set => mProductType = value;
        }

        /// <summary>
        /// The price
        /// </summary>
        [XmlElement(ElementName = "RegularPrice")]
        public double ProductPrice { get; set; }

        /// <summary>
        /// The weight
        /// </summary>
        [XmlElement(ElementName = "Weight")]
        public double ProductWeight { get; set; }

        /// <summary>
        /// The brand
        /// </summary>
        [XmlElement(ElementName = "brand")]
        public string Brand
        {
            get => mBrand ?? string.Empty;
            set => mBrand = value;
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
        [XmlElement(ElementName = "Cat")]
        public string CategoryTree
        {
            get => mCategoryTree ?? string.Empty;
            set => mCategoryTree = value;
        }

        /// <summary>
        /// The car brands
        /// </summary>
        [XmlElement(ElementName = "car_brands")]
        public string CarBrands
        {
            get => mCarBrands ?? string.Empty;
            set => mCarBrands = value;
        }

        /// <summary>
        /// The car models
        /// </summary>
        [XmlElement(ElementName = "car_models")]
        public string CarModels
        {
            get => mCarModels ?? string.Empty;
            set => mCarModels = value;
        }

        /// <summary>
        /// The image
        /// </summary>
        [XmlElement(ElementName = "ImageURL")]
        public string Image
        {
            get => mImage ?? string.Empty;
            set => mImage = value;
        }

        /// <summary>
        /// The stock status
        /// </summary>
        [XmlElement(ElementName = "StockStatus")]
        public string StockStatus
        {
            get => mStockStatus ?? string.Empty;
            set => mStockStatus = value;
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
        public DigitalIQProduct() : base()
        {

        }

        #endregion
    }
}
