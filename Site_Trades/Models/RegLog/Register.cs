﻿namespace Site_Trades.Models.RegLog
{
    public class Register
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsRegisted { get; set; }
    }
}
