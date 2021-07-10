using System;

namespace RegisterServicesWithReflectionStudy
{
    public class WhateverOne : IWhatever<Thing>
    {
        public void DoSomething(Thing thing)
        {
            Console.WriteLine(nameof(WhateverOne) + " I'm doing one thing: " + thing);
        }
    }
}