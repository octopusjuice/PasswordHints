﻿using System;

namespace PasswordHints
{
    public class AccountData : IComparable<AccountData>
    {
        #region Public Properties

        public string Website { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHint { get; set; }

        #endregion

        #region Constructors

        public AccountData()
        {
            Website = Email = Username = PasswordHint = "";
        }

        public AccountData(string website, string email, string username, string passwordHint)
        {
            Website = website;
            Email = email;
            Username = username;
            PasswordHint = passwordHint;
        }

        public int CompareTo(AccountData other)
        {
            return Website.CompareTo(other.Website);
        }

        #endregion
    }
}
