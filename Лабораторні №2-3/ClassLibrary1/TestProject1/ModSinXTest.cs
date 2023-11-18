using ClassLibrary1;
namespace TestProject1
{
    public class ModSinXTest
    {
        [Fact]
        public void ModSinXCycleTest()
        {
            var msxc = new ModSinX();
            var testRes = 0.019;
            var trueRes = Math.Round(msxc.ModSinXLoop(), 3);
            Assert.Equal(testRes, trueRes);
        }

        [Fact]
        public void ModSinXRecTest()
        {
            var msxc = new ModSinX();
            var testRes = 0.019;
            var trueRes = Math.Round(msxc.ModSinXRec(1, 0, 0), 3);
            Assert.Equal(testRes, trueRes);
        }
    }
}
