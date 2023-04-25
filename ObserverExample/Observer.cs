using System;

namespace ObserverExample
{
    //Класс Observer
    public class Observer : IObserver
    {
        //Название
        public string name { get; set; }

        //Состояние
        public string observerState { get; set; }

        //Задаём имя в конструкторе
        public Observer(string name)
        {
            this.name = name;
        }

        //Метод для вывода обновлённого состояния
        public void Update(object s, State state)
        {
            observerState = (state.SubjectState);
            Console.WriteLine($"Новое состояния наблюдателя: '{name}' - {observerState}");
        }
    }
}
