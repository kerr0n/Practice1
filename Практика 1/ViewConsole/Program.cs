using BusinessLogic;

Logic logic = new Logic();
Console.WriteLine("Добро пожаловать в ДеканатPRO");
bool markerToWhile = true;
while (markerToWhile)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Добавить студента");
    Console.WriteLine("2. Удалить студента");
    Console.WriteLine("3. Просмотреть список студентов");
    Console.WriteLine("4. Просмотреть гистограмму специальностей");
    Console.WriteLine("5. Выход");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsSymbol)) 
            {
                Console.WriteLine("Имя студента не может быть пустым или содержать символы. Пожалуйста, попробуйте снова.");
                break;
            }
            Console.WriteLine("Введите специальность студента:");
            string speciality = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(speciality))
            {
                Console.WriteLine("Специальность студента не может быть пустой. Пожалуйста, попробуйте снова.");
                break;
            }
            Console.WriteLine("Введите группу студента:");
            string group = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(group))
            {
                Console.WriteLine("Группа студента не может быть пустой. Пожалуйста, попробуйте снова.");
                break;
            }
            logic.AddStudent(name, speciality, group);
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Введите номер студента в списке для удаления:");
            string studentNumber = Console.ReadLine();
            if (int.TryParse(studentNumber, out int index))
            {
                index--;
                logic.DeleteStudent(index);
            }
            else
            {
                Console.WriteLine("Неверный номер студента. Пожалуйста, попробуйте снова.");
            }
            break;
        case "5":
            markerToWhile = false;
            break;
        default:
            Console.WriteLine("Неверные данные. Пожалуйста, попробуйте снова");
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            break;
    }
}