using Domain.Models;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class JsonSettingConverter
    {
        public string ConvertObjectToJson(ApplicationSetting applicationSetting)
        {
            var options = new JsonSerializerOptions
            {
                // JavaScriptEncoder.Createでエンコードしない文字を指定するのも可
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                // 読みやすいようインデントを付ける
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(applicationSetting, options);

            return json;
        }

        public ApplicationSetting ConvertJsonToObject(string jsonText)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            ApplicationSetting? setting = JsonSerializer.Deserialize<ApplicationSetting>(jsonText, options);

            if (setting == null) { return ApplicationSetting.NULL; }

            return setting;
        }
    }
}
