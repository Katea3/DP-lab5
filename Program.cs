int select;

// Массив продуктов: напиток, первое блюдо, второе блюдо
MenuOption[] dictProduct = [
    new(){
        Name="Drink",
        Price=30
    },
    new(){
        Name="FirstEat",
        Price=40
    },
    new(){
        Name="SecondEat", 
        Price=50
    },
];

// Списки для выбора продуктов двумя клиентами
List<int> client1 = new();
List<int> client2 = new();

while (true)
{
    // Главное меню программы
    Console.WriteLine("Выберите пункт: \n 1. Заполнить первого клиента \n 2. Заполнить второго клиента \n 3. Посчитать счет \n 0. Завершить программу");

    // Проверка корректности ввода меню
    while (true)
    {
        bool isOk = int.TryParse(Console.ReadLine(), out select);
        if (isOk)
        {
            break;
        }

        Console.WriteLine("You didn't enter a number.");
    }

    switch (select)
    {
        case 0:
            // Завершение программы
            return;

        case 1:
            {
                // Ввод выбора продуктов для клиента 1
                Console.WriteLine("Выберите 2 продукта (0 = Drink, 1 = FirstEat, 2 = SecondEat):");
                for (int i = 0; i < 2; i++)
                {
                    int selectProd;
                    int.TryParse(Console.ReadLine(), out selectProd);
                    client1.Add(selectProd); // Сохраняем выбор продукта
                }
            }
            break;

        case 2:
            {
                // Ввод выбора продуктов для клиента 2
                Console.WriteLine("Выберите 2 продукта (0 = Drink, 1 = FirstEat, 2 = SecondEat):");
                for (int i = 0; i < 2; i++)
                {
                    int selectProd;
                    int.TryParse(Console.ReadLine(), out selectProd);
                    client2.Add(selectProd);
                }
            }
            break;

        case 3:
            {
                // Подсчет и вывод заказа клиента 1
                {
                    int totalClient = 0;
                    Console.WriteLine("Заказ клиента 1:");
                    foreach (int id in client1)
                    {
                        Console.WriteLine(dictProduct[id].Name);
                        totalClient += dictProduct[id].Price;
                    }
                    Console.WriteLine("Итого " + totalClient);
                }

                // Подсчет и вывод заказа клиента 2
                {
                    int totalClient = 0;
                    Console.WriteLine("Заказ клиента 2:");
                    foreach (int id in client2)
                    {
                        Console.WriteLine(dictProduct[id].Name);
                        totalClient += dictProduct[id].Price;
                    }
                    Console.WriteLine("Итого " + totalClient);
                }
            }
            break;
    }
}


// Структура для хранения данных меню: название и цена
struct MenuOption
{
    public required string Name;
    public required int Price;   
}
