namespace ObserverExample
{
    //Интерфейс Observer'а
    public interface IObserver
    {
        void Update(object subject, State state);
    }
}
