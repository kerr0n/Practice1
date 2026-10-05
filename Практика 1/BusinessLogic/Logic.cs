using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DataAccessLayer;

namespace BusinessLogic
{
    public class Logic : IDisposable
    {
        private static readonly string _databasePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,"..", "..", "..", "..","DataAccessLayer","Database.mdf"));
        private static readonly string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_databasePath};Integrated Security=True;Encrypt=False;";
        private readonly IRepository<Student> _repository;

        public Logic(IRepository<Student> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Создаёт экземпляр класса Logic с репозиторием для работы с базой данных
        /// </summary>
        /// <returns></returns>
        public static Logic Create()
        {
            var repository = new StudentDapperRepository(_connectionString);
            return new Logic(repository);
        }

        /// <summary>
        /// Возвращает список студентов из базы данных
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudents()
        {
            return _repository.ReadAll().ToList();
        }

        /// <summary>
        /// Возвращает студента по id из базы данных
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student? GetStudentById(int id)
        {
            return _repository.ReadById(id);
        }

        /// <summary>
        /// Добавляет студента в базу данных
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speciality"></param>
        /// <param name="group"></param>
        public void AddStudent(string name, string speciality, string group)
        {
            ValidateStudentData(name, speciality, group);
            var student = new Student(name, speciality, group);
            _repository.Create(student);
        }

        /// <summary>
        /// Удаляет студента из базы данных по id
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentException"></exception>
        public void DeleteStudent(int id)
        {
            var student = _repository.ReadById(id);
            if (student is null)
            {
                throw new ArgumentException("Студент с таким id не существует");
            }
            _repository.Delete(id);
        }

        /// <summary>
        /// Обновляет данные студента в базе данных по id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="speciality"></param>
        /// <param name="group"></param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdateStudent(int id, string name, string speciality, string group)
        {
            ValidateStudentData(name, speciality, group);
            var student = _repository.ReadById(id);
            if (student is null)
            {
                throw new ArgumentException("Студент с таким ID не существует");
            }
            student.Name = name;
            student.Speciality = speciality;
            student.Group = group;
            _repository.Update(student);
        }

        /// <summary>
        /// Создаёт гистограмму по специальностям студентов
        /// </summary>
        /// <returns></returns>
        public Histogram CreateHistogram()
        {
            var histogram = new Histogram();
            histogram.CreateDictionary(GetStudents());
            return histogram;
        }

        /// <summary>
        /// Проверяет правильность данных студента перед добавлением или обновлением
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speciality"></param>
        /// <param name="group"></param>
        /// <exception cref="ArgumentException"></exception>
        private static void ValidateStudentData(string name, string speciality, string group)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Введите имя студента");
            }
            if (string.IsNullOrWhiteSpace(speciality))
            {
                throw new ArgumentException("Введите специальность");
            }
            if (string.IsNullOrWhiteSpace(group))
            {
                throw new ArgumentException("Введите группу");
            }
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
