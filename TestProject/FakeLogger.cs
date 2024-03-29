﻿using CandidateRatingLibrary.Core.Interfaces;
using System.Collections.Generic;

namespace CandidateRater.Tests
{
    public class FakeLogger : ILogger
    {
        public List<string> LoggedMessages { get; } = new List<string>();
        public void Log(string message)
        {
            LoggedMessages.Add(message);
        }
    }
}
