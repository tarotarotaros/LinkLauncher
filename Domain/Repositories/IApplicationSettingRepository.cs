using Domain.Models;

namespace Domain.Repositories
{
    public interface IApplicationSettingRepository
    {
        ApplicationSetting LoadApplicationSetting();

        bool SaveApplicationSetting(ApplicationSetting applicationSetting);
    }
}
