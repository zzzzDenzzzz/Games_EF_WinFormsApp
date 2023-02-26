using System.ComponentModel;

namespace Games_EF_WinFormsApp.Constants
{
    public enum Genre
    {
        [Description("Стратегия")]
        STRATEGY = 1,
        [Description("Ролевая игра")]
        RPG,
        [Description("Экшен")]
        ACTION,
        [Description("Приключение")]
        ADVENTURE,
        [Description("Шутер")]
        SHOOTER,
        [Description("Выживание")]
        SURVIVAL,
    }
}
