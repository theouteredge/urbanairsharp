﻿// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)
using System;
using System.Net.Http;
using UrbanAirSharp.Request.Base;

namespace UrbanAirSharp.Request
{
	/// <summary>
	/// Used to form a SCHEDULE request
	/// http://docs.urbanairship.com/reference/api/v3/schedule.html#schedule-a-notification
	/// </summary>
	public class ScheduleGetRequest : GetRequest
	{
		public ScheduleGetRequest(Guid scheduleId)
		{
			RequestUrl = "api/schedules/" + scheduleId;
		}
	}
}
