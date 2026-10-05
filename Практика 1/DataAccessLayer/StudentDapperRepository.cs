using Dapper;
using Microsoft.Data.SqlClient;
using Model;

namespace DataAccessLayer;

public class StudentDapperRepository : IRepository<Student>
{
    private readonly string _connectionString;

    public StudentDapperRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    /// <summary>
    /// Получение всех студентов из БД
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Student> ReadAll()
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        const string sql = """
            SELECT [Id], [Name], [Speciality], [Group]
            FROM [dbo].[Students]
            ORDER BY [Id];
            """;
        return connection.Query<Student>(sql).ToList();
    }

    /// <summary>
    /// Получение студента по id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Student? ReadById(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        const string sql = """
            SELECT [Id], [Name], [Speciality], [Group]
            FROM [dbo].[Students]
            WHERE [Id] = @Id;
            """;
        return connection.QuerySingleOrDefault<Student>(sql, new { Id = id });
    }

    /// <summary>
    /// Создание нового студента в БД
    /// </summary>
    /// <param name="item"></param>
    public void Create(Student item)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        const string sql = """
            INSERT INTO [dbo].[Students]
                ([Name], [Speciality], [Group])
            OUTPUT INSERTED.[Id]
            VALUES (@Name, @Speciality, @Group);
            """;
        item.Id = connection.QuerySingle<int>(sql, item);
    }

    /// <summary>
    /// Удаление студента по id из БД
    /// </summary>
    /// <param name="id"></param>
    public void Delete(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        const string sql = """
            DELETE FROM [dbo].[Students]
            WHERE [Id] = @Id;
            """;
        connection.Execute(sql, new { Id = id });
    }

    /// <summary>
    /// Обновление данных студента в БД
    /// </summary>
    /// <param name="item"></param>
    public void Update(Student item)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Open();
        const string sql = """
            UPDATE [dbo].[Students]
            SET [Name] = @Name,
                [Speciality] = @Speciality,
                [Group] = @Group
            WHERE [Id] = @Id;
            """;
        connection.Execute(sql, item);
    }

    public void Dispose()
    {
    }
}