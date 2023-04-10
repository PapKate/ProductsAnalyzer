
using IronXL;
using Atom.Data.Excel;
using System.Collections.Generic;
using System.Xml.Serialization;
using SixLabors.ImageSharp.ColorSpaces;
using System.ComponentModel;
using Atom;

namespace ProductsAnalyzer
{
    public static class Constants
    {
        #region Public Properties

        /// <summary>
        /// The excel file path
        /// </summary>
        public static string ExcelPath = "WooCommerce-Products-Export-2023-February-02-1530.xlsx";

        public static string XMLFolderPath = "C:\\Users\\DK\\Desktop\\XMLtoExcel";

        public static string BKTurningProductsPath = XMLFolderPath + "\\dc_bktuning.xml";
        public static string CarnerProductsPath = XMLFolderPath + "\\dc_carner.xml";
        public static string DigitalIQProductsPath = XMLFolderPath + "\\dc_digitaliq.xml";
        public static string VisualAcousticsProductsPath = XMLFolderPath + "\\dc_visualacoustics.xml";

        #endregion
    }

    public class Program
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Program() : base()
        {

        }

        #endregion

        #region Public Methods

        public static async Task Main(string[] args)
        {
            var excelProducts = await GetExcelProductsAsync(Constants.ExcelPath)!;
            Console.WriteLine($"The excel products are: {excelProducts.Count()}");
            var bkTuningProducts = GetXMLProducts<BKTuningProduct>(Constants.BKTurningProductsPath)!;
            Console.WriteLine($"The bkTuning products are: {bkTuningProducts.Count()}");

            var carnerProducts = GetXMLProducts<CarnerProduct>(Constants.CarnerProductsPath)!;
            Console.WriteLine($"The carner products are: {carnerProducts.Count()}");

            var digitalIQProducts = GetXMLProducts<DigitalIQProduct>(Constants.DigitalIQProductsPath)!;
            Console.WriteLine($"The digitalIQ products are: {digitalIQProducts.Count()}");

            var visualAcousticsProducts = GetXMLProducts<VisualAcousticsProduct>(Constants.VisualAcousticsProductsPath)!;
            Console.WriteLine($"The visualAcoustics products are: {visualAcousticsProducts.Count()}");

            var xmlProductsInExcel = excelProducts.Where(x => bkTuningProducts.Any(y => y.ProductCode == x.SKU) ||
                                                     carnerProducts.Any(z => z.MPN == x.SKU) ||
                                                     digitalIQProducts.Any(d => d.SKU == x.SKU) ||
                                                     visualAcousticsProducts.Any(v => v.SKU == x.SKU))
                                                  .ToList();
            Console.WriteLine($"The XML products in excel are: {xmlProductsInExcel.Count()}");

            var productsOnlyInExcel = excelProducts.Except(xmlProductsInExcel).ToList()!;

            CreateExcelWithProductsNotInXML(productsOnlyInExcel);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        /// <summary>
        /// Gets all the products of type <typeparamref name="T"/> from the specified <paramref name="filePath"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">The file path</param>
        /// <returns></returns>
        public static IEnumerable<T>? GetXMLProducts<T>(string filePath)
        {
            var mySerializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("products"));

            // Opens the file
            // C:\\Users\\DK\\Desktop\\XMLtoExcel\\dc_bktuning.xml
            var myFileStream = new FileStream(filePath, FileMode.Open);

            // Deserializes the stream to an envelope
            return (List<T>?)mySerializer.Deserialize(myFileStream);
        }

        /// <summary>
        /// Gets all products from the specified <paramref name="fileName"/>
        /// </summary>
        /// <returns></returns>
        /// <param name="fileName">The file name</param>
        public static async Task<IEnumerable<ExcelProduct>> GetExcelProductsAsync(string fileName)
        {
            var importer = new Importer<ExcelProduct>(() => new ExcelProduct());

            importer.Select(x => x.Id, "A", value => value.ToInt(), false);
            importer.Select(x => x.Title, "B", value => value, false);
            importer.Select(x => x.Description, "C", value => value, false);
            importer.Select(x => x.SKU, "D", value => value, false);
            importer.Select(x => x.ProductType, "E", value => value, false);
            importer.Select(x => x.RegularPrice, "AT", value => value.ToDouble(), false);
            importer.Select(x => x.SalePrice, "AU", value => value.ToDouble(), false);
            importer.Select(x => x.StockStatus, "AV", value => value, false);
            importer.Select(x => x.Stock, "AW", value => value.ToInt(), false);

            var resposne = await importer.ImportAsync(fileName);

            return resposne.Result;
        }
        
        public static async void CreateExcelWithProductsNotInXML(IEnumerable<ExcelProduct> products)
        {
            var exporter = new Exporter<ExcelProduct>();

            exporter.Select(x => x.Id, "A");
            exporter.Select(x => x.Title, "B");
            exporter.Select(x => x.Description, "C");
            exporter.Select(x => x.SKU, "D");
            exporter.Select(x => x.ProductType, "E");
            exporter.Select(x => x.RegularPrice, "F");
            exporter.Select(x => x.SalePrice, "G");
            exporter.Select(x => x.StockStatus, "H");
            exporter.Select(x => x.Stock, "I");

            exporter.SetNumberColumnStyle(x => x.Id);
            exporter.SetNumberColumnStyle(x => x.RegularPrice);
            exporter.SetNumberColumnStyle(x => x.SalePrice);
            exporter.SetNumberColumnStyle(x => x.Stock);

            await exporter.ExportAsync(products, "products.xlsx");
        }

        #endregion
    }
}