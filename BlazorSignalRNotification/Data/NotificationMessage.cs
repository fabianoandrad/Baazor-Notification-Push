using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalRNotification.Data
{
    public class NotificationMessage
    {
        public int MsgId { get; set; } = 0;
        public string SenderName { get; set; } = "";
        public string ReceiverName { get; set; } = "";
        public string MsgTitle { get; set; } = "";
        public string MsgBody { get; set; } = "";
        public DateTime MsgDate { get; set; } = DateTime.Now;
        public string MsgDateSt  => this.MsgDate.ToString("dd-MM-yyyy");

    }
}