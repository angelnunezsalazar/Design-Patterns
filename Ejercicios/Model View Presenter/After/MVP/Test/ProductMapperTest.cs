namespace MVP.Test
{
    using System;
    using System.IO;
    using System.Xml;

    using NUnit.Framework;

    [TestFixture]
    public class ProductMapperTest
    {
        private ProductMapper mapper;
        private StringReader input;
        private XmlReader reader;

        [SetUp]
        public void SetupContext()
        {
            this.mapper = new ProductMapper();
            this.input=new StringReader("<product id='1' name='xyz' unitPrice='10.44' discontinued='true' />");
            this.reader = XmlReader.Create(this.input);
            while (this.reader.Read())
                if (this.reader.Name == "product") return;
            Assert.Fail("Expected product xml fragment not found.");
        }

        [Test]
        public void can_map_a_product_from_xml_reader()
        {
            var product = this.mapper.Map(this.reader);

            Assert.IsNotNull(product);
            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("xyz", product.Name);
            Assert.AreEqual(10.44m, product.UnitPrice);
            Assert.IsTrue(product.Discontinued);
        }

        [Test][ExpectedException(typeof(ArgumentNullException))]
        public void when_mapping_with_a_null_reader_throws()
        {
            this.mapper.Map(null);
        }

        [Test][ExpectedException(typeof(InvalidOperationException))]
        public void when_mapping_and_reader_is_not_on_a_product_node_throws()
        {
            this.reader = XmlReader.Create(this.input);
            this.mapper.Map(this.reader);
        }
    }
}