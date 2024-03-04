using Domain.Models;
using Infrastructure.Repositories;

namespace infrastructureTest.Repositories
{
    public class JsonSettingConverterTest
    {
        [Fact]
        public void ConvertObjectToJson_通常()
        {
            var setting = new ApplicationSetting("AAABBB","CCC", SaveType.CSV);
            var converter = new JsonSettingConverter();

            Assert.Equal("{\r\n" +
                         "  \"SaveDirectoryPath\": \"AAABBB\",\r\n" +
                         "  \"SaveFileNameWithoutExtension\": \"CCC\",\r\n" +
                         "  \"SaveType\": 1\r\n" +
                         "}",
                         converter.ConvertObjectToJson(setting));
        }

        [Fact]
        public void ConvertJsonToObject_通常()
        {
            var jsonText = "{\r\n" +
                         "  \"SaveDirectoryPath\": \"AAABBB\",\r\n" +
                         "  \"SaveFileNameWithoutExtension\": \"CCC\",\r\n" +
                         "  \"SaveType\": 1\r\n" +
                         "}";

            var converter = new JsonSettingConverter();
            var setting = new ApplicationSetting("AAABBB", "CCC", SaveType.CSV);

            Assert.Equal(setting, converter.ConvertJsonToObject(jsonText));
        }
    }
}
