﻿using Heranca.Entities;

// instancia um objeto do tipo classe BusinessAccount
BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

Console.WriteLine(account.Balance);

//account.Balance = 200.0;