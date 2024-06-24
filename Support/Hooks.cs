using TechTalk.SpecFlow;

namespace SpecFlowProject1.Support
{
    [Binding]
    public class Hooks
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Drivers.WebDriverSupport.CloseWebDriver();
        }
    }
}
