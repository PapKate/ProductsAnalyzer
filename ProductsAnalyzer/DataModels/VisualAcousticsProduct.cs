using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductsAnalyzer
{
    [XmlType("product")]
    public class VisualAcousticsProduct
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Title"/> property
        /// </summary>
        private string? mName { get; set; }

        /// <summary>
        /// The member of the <see cref="Content"/> property
        /// </summary>
        private string? mContent { get; set; }

        /// <summary>
        /// The member of the <see cref="SKU"/> property
        /// </summary>
        private string? mSKU { get; set; }

        /// <summary>
        /// The member of the <see cref="ShortDescription"/> property
        /// </summary>
        private string? mShortDescription { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductType"/> property
        /// </summary>
        private string? mProductType { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductVisibility"/> property
        /// </summary>
        private string? mProductVisibility { get; set; }

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
        /// The member of the <see cref="ProductCategories"/> property
        /// </summary>
        private string? mProductCategories { get; set; }

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
        [XmlElement(ElementName = "Title")]
        public string Title
        {
            get => mName ?? string.Empty;
            set => mName = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        [XmlElement(ElementName = "Content")]
        public string Content
        {
            get => mContent ?? string.Empty;
            set => mContent = value;
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
        /// The short description
        /// </summary>
        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription
        {
            get => mShortDescription ?? string.Empty;
            set => mShortDescription = value;
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
        /// The price when on sale
        /// </summary>
        [XmlElement(ElementName = "SalePrice")]
        public double ProductSalePrice { get; set; }

        /// <summary>
        /// The weight
        /// </summary>
        [XmlElement(ElementName = "Weight")]
        public double ProductWeight { get; set; }

        /// <summary>
        /// The length
        /// </summary>
        [XmlElement(ElementName = "Length")]
        public double ProductLength { get; set; }

        /// <summary>
        /// The width
        /// </summary>
        [XmlElement(ElementName = "Width")]
        public double ProductWidth { get; set; }

        /// <summary>
        /// The height
        /// </summary>
        [XmlElement(ElementName = "Height")]
        public double ProductHeight { get; set; }

        /// <summary>
        /// The product categories
        /// </summary>
        [XmlElement(ElementName = "Productcategories")]
        public string ProductCategories
        {
            get => mProductCategories ?? string.Empty;
            set => mProductCategories = value;
        }

        /// <summary>
        /// The visibility
        /// </summary>
        [XmlElement(ElementName = "ProductVisibility")]
        public string ProductVisibility
        {
            get => mProductVisibility ?? string.Empty;
            set => mProductVisibility = value;
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

        /// <summary>
        /// The eshop attributes
        /// </summary>
        [XmlElement(ElementName = "EshopAttributes")]
        public EshopAttributes? EshopAttributes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VisualAcousticsProduct() : base()
        {

        }

        #endregion
    }
}
