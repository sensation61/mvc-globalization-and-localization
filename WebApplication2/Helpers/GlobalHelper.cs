using System.Globalization;
using System.Threading;
using System.Web.Configuration;

namespace WebApplication2.Helpers
{
    public class GlobalHelper
    {
        public static string CurrentCulture
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture.Name;
            }
        }
        public static void SetCulture(string culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }

        public static string CurrentCultureTwoLetterISOLanguageName
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            }
        }
        public static string CurrentCultureThreeLetterISOLanguageName
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture.ThreeLetterISOLanguageName;
            }
        }
        public static string CurrentCultureThreeLetterWindowsLanguageName
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture.ThreeLetterWindowsLanguageName;
            }
        }
        public static string DefaultCulture
        {
            get
            {
                var config = WebConfigurationManager.OpenWebConfiguration("/");
                GlobalizationSection section = (GlobalizationSection)config.GetSection("system.web/globalization");
                return section.UICulture;
            }
        }
    }
}