﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EnitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.get(x => x.MessageID == id);

        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com"); //Kullanıcı

        }

        public List<Message> GetListSendInbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com"); //Kullanıcı

        }

        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
