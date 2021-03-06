﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGUI1.Source.Models
{
    public class User
    {
		[Key]
		public int UserID { get; set; }

		private string login;

		public string Login
		{
			get { return login; }
			set { login = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public User(string login, string password)
		{
			this.login = login;
			this.password = password;
		}
	}
}
