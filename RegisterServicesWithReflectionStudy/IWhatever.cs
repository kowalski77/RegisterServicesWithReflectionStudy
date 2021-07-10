namespace RegisterServicesWithReflectionStudy
{
    public interface IWhatever<in T> where T : class
    {
        void DoSomething(T thing);
    }
}