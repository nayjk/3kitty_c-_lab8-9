namespace lab8i
{

    class Program
    {
        static void Main(string[] args)
        {
            Massiv<string> name = new Massiv<string>(3);
            Console.WriteLine($"Изначальная размерность: {name.GetLenght()}");
            name.add(0, "Андрей");
            name.add(1, "Маша");
            name.add(2, "Яна");
            name.Delete("Маша");
            Console.WriteLine($"Размерность массива после удаления: {name.GetLenght()}");
            for (int i = 0; i < name.GetLenght(); i++)
            {
                Console.WriteLine($"{name.GetItem(i)}");
            }
            Massiv<int> lio = new Massiv<int>(3);
            Massiv<double> lio1 = new Massiv<double>(3);
            Login login = new Login(5);
            Password password = new Password(5);
        }
    }

    public class Massiv<T>
    {
        public T[] massiv;

        public Massiv(int size)
        {
            massiv = new T[size];
        }

        public void add(int index, T item) //добавление данных в массив
        {
            massiv[index] = item;
        }

        public T GetItem(int index) //получение значения
        {
            return massiv[index];
        }

        public int GetLenght()
        {
            return massiv.Length;
        }

        public void Delete(T item)
        {
            int index = -1;
            
            for(int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            if(index > -1)
            {
                T[] values = new T[massiv.Length - 1];
                for(int i = 0, j = 0; i < massiv.Length; i++)
                {
                    if (i == index) continue;
                    values[j] = massiv[i];
                    j++;
                }
                massiv = values;
            }
        }
    }
    public class Login : Massiv<string>
    {
        public Login(int size) : base(size) { }
    }

    public class Password : Massiv<string>
    {
        public Password(int size) : base(size) { }
    }

}