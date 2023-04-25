namespace ObserverExample
{
    class Program
    {
        static void Main()
        {
            //Создаём объект, за которым будем наблюдать
            Subject s = new Subject();

            //Добавляем трёх наблюдателей
            s.AddObserver(new Observer("Первый наблюдатель"));
            s.AddObserver(new Observer("Второй наблюдатель"));
            s.AddObserver(new Observer("Третий наблюдатель"));

            //Меняем состояние (>10 символов)
            s.ChangeState("Новое состояние");

            //Меняем состояние (<10 символов)
            s.ChangeState("Новое");

            //Меняем состояние (>10 символов)
            s.ChangeState("Прям супер новое состояние");
        }
    }
}
