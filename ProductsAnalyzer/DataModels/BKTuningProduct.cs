using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductsAnalyzer
{
    [XmlType("product")]
    public class BKTuningProduct
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ProductCode"/> property
        /// </summary>
        private string? mProductCode { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductName"/> property
        /// </summary>
        private string? mProductName { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductDescription"/> property
        /// </summary>
        private string? mProductDescription { get; set; }

        /// <summary>
        /// The member of the <see cref="ProductDetailedDescription"/> property
        /// </summary>
        private string? mProductDetailedDescription { get; set; }

        /// <summary>
        /// The member of the <see cref="BrandName"/> property
        /// </summary>
        private string? mBrandName { get; set; }

        /// <summary>
        /// The member of the <see cref="BrandFor"/> property
        /// </summary>
        private string? mBrandFor { get; set; }

        /// <summary>
        /// The member of the <see cref="Images"/> property
        /// </summary>
        private string? mImages { get; set; }

        /// <summary>
        /// The member of the <see cref="EshopCategories"/> property
        /// </summary>
        private string? mEshopCategories { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The id
        /// </summary>
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// The code
        /// </summary>
        [XmlElement(ElementName = "ProductCode")]
        public string ProductCode
        {
            get => mProductCode ?? string.Empty;
            set => mProductCode = value;
        }

        /// <summary>
        /// The name
        /// </summary>
        [XmlElement(ElementName = "ProductName")]
        public string ProductName
        {
            get => mProductName ?? string.Empty;
            set => mProductName = value;
        }

        /// <summary>
        /// The description
        /// </summary>
        [XmlElement(ElementName = "ProductDescription")]
        public string ProductDescription
        {
            get => mProductDescription ?? string.Empty;
            set => mProductDescription = value;
        }

        /// <summary>
        /// The detailed description
        /// </summary>
        [XmlElement(ElementName = "ProductDetailedDescription")]
        public string ProductDetailedDescription
        {
            get => mProductDetailedDescription ?? string.Empty;
            set => mProductDetailedDescription = value;
        }

        /// <summary>
        /// The quantity
        /// </summary>
        [XmlElement(ElementName = "ProductQuantity")]
        public int ProductQuantity { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [XmlElement(ElementName = "ProductPrice")]
        public double ProductPrice { get; set; }

        /// <summary>
        /// The weight
        /// </summary>
        [XmlElement(ElementName = "ProductWeight")]
        public double ProductWeight { get; set; }

        /// <summary>
        /// The brand name
        /// </summary>
        [XmlElement(ElementName = "BrandName")]
        public string BrandName
        {
            get => mBrandName ?? string.Empty;
            set => mBrandName = value;
        }

        /// <summary>
        /// The brand 
        /// </summary>
        [XmlElement(ElementName = "brand_for")]
        public string BrandFor
        {
            get => mBrandFor ?? string.Empty;
            set => mBrandFor = value;
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
        public BKTuningProduct() : base()
        {

        }

        #endregion
    }
}
