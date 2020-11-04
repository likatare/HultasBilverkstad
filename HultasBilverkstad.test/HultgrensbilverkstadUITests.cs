using Xunit;


namespace HultasBilverkstad.test
{

    public class HultgrensbilverkstadUITests : UITestBase
    {
        [Fact]
        public void Hultgrensbilverkstad_ViewStartpage_Succeed()
        {
            using (var driver = this.NewBrowserDriver())
            {
                driver.Navigate().GoToUrl(this.BaseUri);

                var headline = driver.FindElementById("Logo");
                Assert.Equal("Hultas Bilverkstad",headline.Text);

            }
        }
    }
}
