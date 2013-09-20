﻿using System.Collections.Generic;
using NBot.Core;
using NBot.Core.Brains;
using NBot.Core.Messaging.ContentFilters;
using NBot.MessageHandlers;

namespace NBot.ConsoleAdapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var brain = new FileBrain(".\\Brain");
            Robot.Create("NBot")
                .UseBrain(brain)
                .RegisterMessageFilter(new HandleBarsMessageFilter(brain))
                .RegisterAdapter(new ConsoleAdapter(), "ConsoleChannel")
                .RegisterHandler(new Achievement())
                .RegisterHandler(new Akbar())
                .RegisterHandler(new Announce())
                .RegisterHandler(new AsciiMe())
                .RegisterHandler(new BotSnack())
                .RegisterHandler(new CalmDown())
                .RegisterHandler(new ChuckNorris())
                .RegisterHandler(new ConsoleTestHandler())
                .RegisterHandler(new DownForMe())
                .RegisterHandler(new ExcuseMe())
                .RegisterHandler(new FacePalm())
                .RegisterHandler(new FortuneMe())
                .RegisterHandler(new Hello())
                .RegisterHandler(new MemeCaptain())
                .RegisterHandler(new Pager())
                .RegisterHandler(new PirateTranslator())
                .RegisterHandler(new Ping())
                .RegisterHandler(new PityMe())
                .RegisterHandler(new Remember())
                .RegisterHandler(new Sensitive())
                .RegisterHandler(new Sosearch())                
                .RegisterHandler(new Status())
                .RegisterHandler(new Swanson())
                .Run();

        }
    }
}