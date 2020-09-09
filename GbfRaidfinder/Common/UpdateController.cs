using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GbfRaidfinder.Common {
    public static class UpdateController {
        public const float Localver = 0.86f;
        private const string Url = "http://rel.sakura.ne.jp/GbfRaidfinder/version";

        public static async Task<bool> Check() {
            try {
                string ver;
                using (var web = new HttpClient()) {
                    ver = await web.GetStringAsync(Url);
                }
                return float.Parse(ver, CultureInfo.InvariantCulture) > Localver;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}