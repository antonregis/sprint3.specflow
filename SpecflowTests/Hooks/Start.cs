using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MarsFramework.Pages;
using TechTalk.SpecFlow;
using static MarsFramework.Utils.CommonMethods;


namespace MarsFramework.Utils
{
    [Binding]
    public class Start : Driver
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


        [BeforeTestRun]
        public static void InitializeExtentReports()
        {
            var htmlReporter = new ExtentHtmlReporter(ConstantHelper.ReportsPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void InitializeFeature(FeatureContext featurecontext)
        {
            // ExtentReport: Create test or the Feature
            featureName = extent.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void Setup(ScenarioContext scenarioContext)
        {
            // Launch the browser
            Initialize();

            // Run SignIn
            SignIn SignInObj = new SignIn(driver);
            SignInObj.SignInStep();

            // ExtentReport: Create node or the Scenario
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterStep]
        public void AfterEachStep(ScenarioContext scenariocontext)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (scenariocontext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }

            if (scenariocontext.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
            }
        }

        [AfterScenario]
        public void TearDown()
        {
            // Taking screenshot only if test is Fail
            if (scenario.Status.ToString() != "Pass")
            {
                string img = SaveScreenShotClass.SaveScreenshot(driver, "Screenshot");
                scenario.AddScreenCaptureFromPath(img);
            }
            
            //string img = SaveScreenShotClass.SaveScreenshot(driver, "Screenshot");
            //scenario.AddScreenCaptureFromPath(img);

            //Close the browser
            driver.Quit();
        }

        [AfterTestRun]
        public static void SaveExtentReports()
        {
            extent.Flush();
        }
    }
}