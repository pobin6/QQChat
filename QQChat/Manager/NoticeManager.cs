using QQChat.Base;
using QQChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQChat.Context;

namespace QQChat.Manager
{
    class NoticeManager : ManagerBase, ManagerInterface<NOTICE>
    {
        public NoticeManager(QQChatContext context) : base(context)
        {
        }

        public bool Add(NOTICE t)
        {
            try
            {
                context.NOTICE.Add(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<NOTICE> GetList()
        {
            try
            {
                return context.NOTICE.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Remove(NOTICE t)
        {
            try
            {
                context.NOTICE.Remove(t);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
