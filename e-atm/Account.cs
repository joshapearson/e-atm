using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_atm
{
	public class Account
	{
		public string accountName{get;set;}
		public string accountPin{get;set;}
		public double amount{get;set;}
		public int withdrawalNumber{get;set;}
		public bool UsedAllWithdrawals()
		{
			return (withdrawalNumber <= 0);
		}
	}
}
