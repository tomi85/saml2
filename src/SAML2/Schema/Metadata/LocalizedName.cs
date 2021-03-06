using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SAML2.Schema.Metadata
{
    /// <summary>
    /// The localizedNameType complex type extends a string-valued element with a standard XML language
    /// attribute.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = Saml20Constants.Metadata)]
    [XmlRoot(ElementName, Namespace = Saml20Constants.Metadata, IsNullable = false)]
    public class LocalizedName
    {
        /// <summary>
        /// The XML Element name of this class
        /// </summary>
        public const string ElementName = "OrganizationName";

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedName"/> class.
        /// </summary>
        public LocalizedName() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedName"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="language">The language.</param>
        public LocalizedName(string value, string language)
        {
            Value = value;
            Language = language;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText]
        public string Value { get; set; }

        #region Attributes

        /// <summary>
        /// Gets or sets the lang.
        /// </summary>
        /// <value>The lang.</value>
        [XmlAttribute("lang", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string Language { get; set; }

        #endregion
    }
}
