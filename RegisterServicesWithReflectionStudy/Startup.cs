namespace RegisterServicesWithReflectionStudy
{
    public class Startup
    {
        private readonly IWhatever<Thing> whateverThing;
        private readonly IWhatever<OtherThing> whateverOtherThing;

        public Startup(IWhatever<Thing> whateverThing, IWhatever<OtherThing> whateverOtherThing)
        {
            this.whateverThing = whateverThing;
            this.whateverOtherThing = whateverOtherThing;
        }

        public void Run()
        {
            this.whateverThing.DoSomething(new Thing
            {
                Id = 1, Name = "thing"
            });

            this.whateverOtherThing.DoSomething(new OtherThing
            {
                Id = 2, Name = "other"
            });
        }
    }
}