﻿using System.Collections.Generic;
using WouterFennis.ChatApp.BackEnd.Domain;

namespace WouterFennis.ChatApp.BackEnd.Managers
{
    public interface IChatRoomManager
    {
        IEnumerable<ChatRoom> GetAllChatRooms();
        ChatRoom FindChatRoomById(long id);
        void AddMessageToChatRoom(long chatRoomId, Message message);
        long AddChatRoom(ChatRoom chatRoom);
    }
}
