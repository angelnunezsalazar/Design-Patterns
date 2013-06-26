namespace MVP.Test
{
    using System.IO;
    using System.Linq;
    using System.Xml;

    using Moq;

    using NUnit.Framework;

    [TestFixture]
    public class ProductRepositoryTest
    {
        private ProductRepository repository;
        private Mock<IProductMapper> mapper;
        private string fileName;
        private Mock<IFileLoader> fileLoader;

        [SetUp]
        public void SetupContext()
        {
            this.fileName = "products.xml";
            this.mapper = new Mock<IProductMapper>();
            this.fileLoader = new Mock<IFileLoader>();
            this.repository = new ProductRepository(this.fileLoader.Object, this.mapper.Object);

            // Arrange
            var xmlFragment = "<product id='1' name='xyz' unitPrice='10.44' discontinued='true' />";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.WriteLine("<products>");
            writer.WriteLine(xmlFragment);
            writer.WriteLine(xmlFragment);
            writer.WriteLine("</products>");
            writer.Flush();
            ms.Position = 0;
            this.fileLoader.Setup(x => x.Load(this.fileName)).Returns(ms);
        }

        [Test]
        public void xml_document_is_loaded_via_file_helper()
        {
            // Act
            this.repository.GetByFileName(this.fileName);
            // Assert
            this.fileLoader.Verify(x => x.Load(this.fileName));
        }

        [Test]
        public void mapper_is_called_to_map_from_xml_reader_to_product()
        {
            // Act
            this.repository.GetByFileName(this.fileName);
            // Assert
            this.mapper.Verify(x => x.Map(It.IsAny<XmlReader>()));
        }

        [Test]
        public void all_products_are_mapped_from_the_xml_document()
        {
            var products = this.repository.GetByFileName(this.fileName);
            Assert.AreEqual(2, products.Count());
        }
    }
}