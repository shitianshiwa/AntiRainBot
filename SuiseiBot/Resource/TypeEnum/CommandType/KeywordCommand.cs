using System.ComponentModel;

namespace SuiseiBot.Resource.TypeEnum.CommandType
{
    /// <summary>
    /// 关键字触发
    /// 关键字在Description中以空格分隔多个关键字，仅在初始化时读取
    /// </summary>
    internal enum KeywordCommand
    {
        /// <summary>
        /// 随机数
        /// </summary>
        [Description("dice")]
        Random,
        /// <summary>
        /// 昏睡红茶
        /// </summary>
        [Description("优质睡眠 昏睡红茶")]
        RedTea,
        /// <summary>
        /// 24岁，是学生
        /// </summary>
        [Description("24岁，是学生")]
        Student,
        /// <summary>
        /// 来点色图！
        /// </summary>
        [Description("来点色图 来点涩图 我要看色图")]
        Hso
    }
}