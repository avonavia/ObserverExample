using System.Collections.Generic;

namespace ObserverExample
{
    //Объект, за которым наблюдают Observer'ы
    public class Subject
    {
        //Список Observer'ов
        public List<IObserver> observersList = new List<IObserver>();

        //Метод добавления Observer'ов
        public void AddObserver(IObserver observer)
        {
            observersList.Add(observer);
        }

        //Изначальное состояние
        public string SubjectState = "Изначальное стстояние";

        //Метод смены состояния объекта
        public void ChangeState(string state)
        {
            SubjectState = state;

            //Если длина названия состояния больше 10, то уведомляем всех Observer'ов
            if (state.Length > 10)
            {
                NotifyObservers();
            }
        }

        //Метод, которым уведомляем всех Observer'ов
        public void NotifyObservers()
        {
            State state = new State();
            state.SubjectState = SubjectState;

            foreach (IObserver o in observersList)
            {
                o.Update(this, state);
            }
        }
    }
}
