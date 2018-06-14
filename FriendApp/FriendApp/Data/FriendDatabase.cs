using System;
using System.Collections.Generic;
using System.Text;

namespace FriendApp.Data
{
    using FriendApp.Model;
    using SQLite;
    public class FriendDatabase
    {
        private readonly SQLiteAsyncConnection database;
        public FriendDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait();
        }

    }
}
