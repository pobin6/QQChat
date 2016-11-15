using QQChat.Base;
using QQChat.Context;
using QQChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQChat.Manager
{
    public class UserManager : ManagerBase,ManagerInterface<USER>
    {
        public UserManager(QQChatContext context) : base(context)
        {
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Add(USER user)
        {
            try
            {
                context.USER.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 返回数据库数据
        /// </summary>
        /// <returns></returns>
        public List<USER> GetList()
        {
            return context.USER.ToList();
        }
        public USER findUser(string username,string password)
        {
            List<USER> users = GetList();
            foreach (var item in users)
            {
                if(item.username == username && item.password == password)
                {
                    return item;
                }
            }
            return null;
        }
        public bool Remove(USER t)
        {
            try
            {
                context.USER.Remove(t);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
