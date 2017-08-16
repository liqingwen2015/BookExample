namespace _03单例模式
{
    internal class SingletonObject
    {
        /// <summary>
        /// 实例
        /// </summary>
        /// <remarks>创建 SingleObject 的一个对象</remarks>
        private static readonly SingletonObject Instance = new SingletonObject();

        /// <summary>
        /// 私有构造函数
        /// </summary>
        /// <remarks>该类无法被实例化</remarks>
        private SingletonObject()
        {
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <remarks>获取唯一可用的对象</remarks>
        /// <returns></returns>
        public static SingletonObject GetInstance()
        {
            return Instance;
        }
    }
}