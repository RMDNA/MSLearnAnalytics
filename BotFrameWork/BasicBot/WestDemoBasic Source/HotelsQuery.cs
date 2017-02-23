﻿namespace LuisBot
{
    using System;
    using Microsoft.Bot.Builder.FormFlow;
    using Dialogs;

    [Serializable]
    public class HotelsQuery
    {
        [Prompt("Please enter your {&}")]
       
        public string Destination { get; set; }

        [Prompt("When do you want to {&}?")]

        public DateTime CheckIn { get; set; }

        [Numeric(1, int.MaxValue)]
        [Prompt("How many {&} do you want to stay?")]

        public int Nights { get; set; }

        //[Prompt("What happened to your vehicle {||}")]
        //public MyOptions myoptions;

        [Prompt("Near which Airport")]
        
        public string AirportCode { get; set; }
    }
}