﻿using System;
using System.Threading;
using log4net;
using log4net.Config;

namespace LogzioLog4netSampleApplication
{
	class Program
	{
		static void Main()
		{
			XmlConfigurator.Configure();

			var logger = LogManager.GetLogger("GreetingsLogger");
			logger.Info("Hmm.");
			Thread.Sleep(TimeSpan.FromSeconds(30));
		}
	}
}