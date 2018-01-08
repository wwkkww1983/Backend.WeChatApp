﻿using DapperExtensions.Mapper;
using System;

namespace Backend.WeChatApp.Repository
{
	public class CustomPluralizedMapper<T> : PluralizedAutoClassMapper<T> where T : class
	{
		public override void Table(string tableName)
		{
			if (tableName.Equals("UserInRole", StringComparison.CurrentCultureIgnoreCase))
			{
				TableName = "UserRole";
			}

			base.Table(tableName);
		}
	}
}