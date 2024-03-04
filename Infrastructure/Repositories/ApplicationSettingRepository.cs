using Domain.Models;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    internal class ApplicationSettingRepository : IApplicationSettingRepository
    {
        private const string SETTING_FILE_NAME = "setting.json";
        private readonly JsonSettingConverter _jsonSettingConverter;
        private readonly FileIO _fileIO;

        public ApplicationSettingRepository()
        {
            _jsonSettingConverter = new JsonSettingConverter();
            _fileIO = new FileIO();
        }

        public ApplicationSetting LoadApplicationSetting()
        {
            if (!File.Exists(SETTING_FILE_NAME))
            {
                var nullSetting = ApplicationSetting.NULL;
                var text = _jsonSettingConverter.ConvertObjectToJson(nullSetting);
                _fileIO.WriteFile(text, SETTING_FILE_NAME);
            }

            var savedText = _fileIO.ReadFile("", SETTING_FILE_NAME);
            var savedSetting = _jsonSettingConverter.ConvertJsonToObject(savedText);

            return savedSetting;
        }

        public bool SaveApplicationSetting(ApplicationSetting applicationSetting)
        {
            var text = _jsonSettingConverter.ConvertObjectToJson(applicationSetting);
            return _fileIO.WriteFile(text, SETTING_FILE_NAME);
        }
    }
}
