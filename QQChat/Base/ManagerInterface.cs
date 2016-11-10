using System.Collections.Generic;

namespace QQChat.Base
{
    interface ManagerInterface<T>
    {
        /// <summary>
        /// 增加数据库数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Add(T t);
        /// <summary>
        /// 返回数据库数据
        /// </summary>
        /// <returns></returns>
        List<T> GetList();
        /// <summary>
        /// 删除指定数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Remove(T t);
    }
}
