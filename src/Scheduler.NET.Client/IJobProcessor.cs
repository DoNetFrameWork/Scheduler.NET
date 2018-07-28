﻿using Scheduler.NET.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.NET.Client
{
	public interface IJobProcessor
	{
		bool Process(JobContext context);
	}
}
