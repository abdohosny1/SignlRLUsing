using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignlRLTest.ServiceSignlR
{
    public class ChatHub : Hub
    {
       
            public void SendMessage(string name , string message)
            {
            // dbsave

            Clients.All().newMessage(name,message); //send all
            Clients.Others(); // send all but not send to resender
            }
        
    }
}