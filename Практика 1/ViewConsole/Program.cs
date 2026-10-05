using BusinessLogic;

using var logic = Logic.Create();
Console.WriteLine("Добро пожаловать в ДеканатPRO");
bool markerToWhile = true;
while (markerToWhile)
{
    Console.Clear();
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
                Console.WriteLine("Имя студента не может быть пустым или содержать специальные символы. Пожалуйста, попробуйте снова.");
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
            Console.WriteLine("Студент успешно добавлен.");
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Введите ID студента для удаления:");
            if (int.TryParse(Console.ReadLine(), out int id) && id > 0)
            {
                try
                {
                    logic.DeleteStudent(id);
                    Console.WriteLine("Студент удалён.");
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            else
            {
                Console.WriteLine("Неверный ID.");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Список студентов:");
            var students = logic.GetStudents();
            foreach (var student in students)
            {
                Console.WriteLine($"ID {student.Id}: {student}");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            break;
        case "4":
            Console.Clear();
            var histogram = logic.CreateHistogram();
            Console.WriteLine("Гистограмма специальностей:");
            foreach (var entry in histogram.GetHistogram())
            {
                Console.WriteLine($"{entry.Key,-25}: {new string('#', entry.Value)}");
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
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