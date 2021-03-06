﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WouterFennis.ChatApp.BackEnd.Domain
{
    public class Message
    {
        public long Id { get; set; }
        [Required]
        public string Sender { get; set; }
        public DateTime CreatedOnUtc { get; private set; }
        [Required]
        public string Content { get; set; }

        public Message(string sender, string content)
        {
            Sender = sender;
            CreatedOnUtc = DateTime.UtcNow;
            Content = content;
        }

        public Message()
        {

        }
    }
}
