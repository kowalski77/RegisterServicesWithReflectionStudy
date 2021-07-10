using System;

namespace RegisterServicesWithReflectionStudy
{
    public class WhateverTwo : IWhatever<OtherThing>
    {
        public void DoSomething(OtherThing thing)
        {
            Console.WriteLine(nameof(WhateverTwo) + " I'm doing one other thing: " + thing);
        }
    }
}