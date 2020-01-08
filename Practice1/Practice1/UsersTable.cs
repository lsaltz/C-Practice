using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Practice1
{
    class UsersTable
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string Q { get; set; }
        public string Passcode { get; set; }
    }
}
