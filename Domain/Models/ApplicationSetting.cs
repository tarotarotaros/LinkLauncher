namespace Domain.Models
{

    public enum SaveType
    {
        MarkDown,
        CSV,
        TSV,
        Json,
    }

    public class ApplicationSetting
    {
        public static ApplicationSetting NULL =  new ApplicationSetting();
        
        private readonly bool _isNull = false;

        public bool IsNull { get { return _isNull; } }

        private ApplicationSetting()
            :this(string.Empty,string.Empty,SaveType.CSV)
        {
            _isNull = true;
        }

        public ApplicationSetting(string saveDirectoryPath, string saveFileNameWithoutExtension, SaveType saveType)
        {
            SaveDirectoryPath = saveDirectoryPath;
            SaveFileNameWithoutExtension = saveFileNameWithoutExtension;
            SaveType = saveType;
        }

        /// <summary>
        /// 保存先ディレクトリパス
        /// </summary>
        public string SaveDirectoryPath { get; }
        
        /// <summary>
        /// ファイル名（拡張子なし）
        /// </summary>
        public string SaveFileNameWithoutExtension { get; }

        /// <summary>
        /// 保存方法
        /// </summary>
        public SaveType SaveType { get; }

        public override bool Equals(object? obj)
        {
            return obj is ApplicationSetting setting &&
                   SaveDirectoryPath == setting.SaveDirectoryPath &&
                   SaveFileNameWithoutExtension == setting.SaveFileNameWithoutExtension &&
                   SaveType == setting.SaveType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SaveDirectoryPath, SaveFileNameWithoutExtension, SaveType);
        }
    }
}
