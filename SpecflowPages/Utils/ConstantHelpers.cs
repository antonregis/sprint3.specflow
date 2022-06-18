namespace MarsFramework.Utils
{
    public class ConstantHelper
    {
        // Base Url
        public static string BaseUrl = "http://localhost:5000";

        // Driver path
        public static string DriverPath = RelativePath.setup(@"\..\..\..\..\SpecflowPages\");

        // ScreenshotPath 
        public static string ScreenshotPath = RelativePath.setup(@"\..\..\..\..\SpecflowPages\TestReports\Screenshots\");

        // ExtentReportsPath
        public static string ReportsPath = RelativePath.setup(@"\..\..\..\..\SpecflowPages\TestReports\");

        // ExcelDataPath
        public static string ExcelDataPath = RelativePath.setup(@"\..\..\..\..\SpecflowTests\Data\Excel\Data.xlsx");

        // ExcelSigninDataPath
        public static string ExcelSigninDataPath = RelativePath.setup(@"\..\..\..\..\SpecflowTests\Data\Excel\Mars.xlsx");

        // FileUpload
        public static string Fileupload = RelativePath.setup(@"\..\..\..\..\SpecflowTests\Data\Fileupload\");
    }

    class RelativePath
    {
        public static string setup(string path)
        {
            return Path.GetFullPath(Directory.GetCurrentDirectory()) + path;
        }
    }
}