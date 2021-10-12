using NUnit.Framework;

namespace FileDataTest
{
    [TestFixture]
    public class VersionTest
    {
        [Test]
        public void TestGetVersionFirstArg()
        {
            FileData.VersionClasses.Versions versions = new FileData.VersionClasses.Versions();

            bool a = versions.CheckIfFirstArgIsValidForVersion("-v");
            bool b = versions.CheckIfFirstArgIsValidForVersion("--v");
            bool c = versions.CheckIfFirstArgIsValidForVersion("/v");
            bool d = versions.CheckIfFirstArgIsValidForVersion("--version");

            bool e = versions.CheckIfFirstArgIsValidForVersion("---v");

            Assert.AreEqual(true, a);
            Assert.AreEqual(true, b);
            Assert.AreEqual(true, c);
            Assert.AreEqual(true, d);
            Assert.AreEqual(false, e);
        }

        [Test]
        public void TestGetSizeFirstArg()
        {
            FileData.SizeClasses.Size size = new FileData.SizeClasses.Size();

            bool a = size.CheckIfFisrtArgIsValidForSize("-s");
            bool b = size.CheckIfFisrtArgIsValidForSize("--s");
            bool c = size.CheckIfFisrtArgIsValidForSize("/s");
            bool d = size.CheckIfFisrtArgIsValidForSize("--size");

            bool e = size.CheckIfFisrtArgIsValidForSize("---s");

            Assert.AreEqual(true, a);
            Assert.AreEqual(true, b);
            Assert.AreEqual(true, c);
            Assert.AreEqual(true, d);
            Assert.AreEqual(false, e);
        }
        


    }
}
