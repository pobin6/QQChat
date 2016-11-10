
using QQChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQChat.Context;
using QQChat.Base;

namespace QQChat.Manager
{
    class MessageManager : ManagerBase,ManagerInterface<MESSAGE>
    {
        public MessageManager(QQChatContext context) : base(context)
        {
        }

        public bool Add(MESSAGE t)
        {
            try
            {
                context.MESSAGE.Add(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MESSAGE> GetList()
        {
            try
            {
                return context.MESSAGE.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Remove(MESSAGE t)
        {
            try
            {
                context.MESSAGE.Remove(t);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
