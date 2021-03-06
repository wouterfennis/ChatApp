﻿using System.Collections.Generic;
using System.Linq;
using WouterFennis.ChatApp.BackEnd.DAL.Repositories;
using WouterFennis.ChatApp.BackEnd.Domain;

namespace WouterFennis.ChatApp.BackEnd.Managers
{
    public class ChatRoomManager : IChatRoomManager
    {
        public IRepository<ChatRoom, long> _chatRoomRepository { get; private set; }

        public ChatRoomManager(IRepository<ChatRoom, long> chatRoomRepository)
        {
            _chatRoomRepository = chatRoomRepository;
        }

        public IEnumerable<ChatRoom> GetAllChatRooms()
        {
            IEnumerable<ChatRoom> chatRooms = _chatRoomRepository.FindAll();
            return chatRooms;
        }

        public ChatRoom FindChatRoomById(long chatRoomId)
        {
            ChatRoom foundChatRoom = null;
            if (_chatRoomRepository.Exists(chatRoomId))
            {
                foundChatRoom = _chatRoomRepository.FindByIdWithMessages(chatRoomId).FirstOrDefault();
            }
            else
            {
                throw new KeyNotFoundException();
            }
            return foundChatRoom;
        }

        public void AddMessageToChatRoom(long chatRoomId, Message message)
        {
            ChatRoom foundChatRoom = FindChatRoomById(chatRoomId);
            if (foundChatRoom != null)
            {
                foundChatRoom.Messages.Add(message);
                _chatRoomRepository.Update(foundChatRoom);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public long AddChatRoom(ChatRoom chatRoom)
        {
            long chatRoomId = _chatRoomRepository.Insert(chatRoom);
            return chatRoomId;
        }
    }
}
