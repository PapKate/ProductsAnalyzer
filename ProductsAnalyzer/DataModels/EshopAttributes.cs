using System.Xml.Serialization;

namespace ProductsAnalyzer
{
    public class EshopAttributes
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Brand"/> property
        /// </summary>
        private string? mBrand { get; set; }

        /// <summary>
        /// The member of the <see cref="LedIllumination"/> property
        /// </summary>
        private string? mLedIllumination { get; set; }

        /// <summary>
        /// The member of the <see cref="Reclining"/> property
        /// </summary>
        private string? mReclining { get; set; }

        /// <summary>
        /// The member of the <see cref="Images"/> property
        /// </summary>
        private string? mSize { get; set; }

        /// <summary>
        /// The member of the <see cref="ArmSettings"/> property
        /// </summary>
        private string? mArmSettings { get; set; }

        /// <summary>
        /// The member of the <see cref="Material"/> property
        /// </summary>
        private string? mMaterial { get; set; }

        /// <summary>
        /// The member of the <see cref="Color"/> property
        /// </summary>
        private string? mColor { get; set; }

        #endregion

        #region Public Properties

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
        /// The color
        /// </summary>
        [XmlElement(ElementName = "color")]
        public string Color
        {
            get => mColor ?? string.Empty;
            set => mColor = value;
        }

        /// <summary>
        /// A flag indicating whether it has LED lights or not
        /// </summary>
        [XmlElement(ElementName = "led-illumination")]
        public string LedIllumination
        {
            get => mLedIllumination ?? string.Empty;
            set => mLedIllumination = value;
        }

        /// <summary>
        /// A flag indicating whether it can be recicled or not
        /// </summary>
        [XmlElement(ElementName = "reclining")]
        public string Reclining
        {
            get => mReclining ?? string.Empty;
            set => mReclining = value;
        }

        /// <summary>
        /// The size
        /// </summary>
        [XmlElement(ElementName = "megethos")]
        public string Size
        {
            get => mSize ?? string.Empty;
            set => mSize = value;
        }

        /// <summary>
        /// The arm settings
        /// </summary>
        [XmlElement(ElementName = "arm-settings")]
        public string ArmSettings
        {
            get => mArmSettings ?? string.Empty;
            set => mArmSettings = value;
        }

        /// <summary>
        /// The material
        /// </summary>
        [XmlElement(ElementName = "material")]
        public string Material
        {
            get => mMaterial ?? string.Empty;
            set => mMaterial = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EshopAttributes() : base()
        {

        }

        #endregion
    }
}
