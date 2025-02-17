using HomeWork_Collections.Task2.Exceptions;

namespace HomeWork_Collections.Task2;

public class University
{
    public List<Student> students;

    public University()
    {
        students = new List<Student>();
    }

    public void AddNewStudent()
    {
        Student student = new Student();
        bool successEntered = false;
        try
        {
            Console.WriteLine("Введите имя студента:");
            student.Name = Console.ReadLine();
            if (string.IsNullOrEmpty(student.Name) || string.IsNullOrWhiteSpace(student.Name))
            {
                throw new EmptyNameAndSurenameException(student);
            }

            Console.WriteLine("Введите возраст студента: ");
            student.Age = int.Parse(Console.ReadLine());
            if (student.Age < 17 || student.Age > 60)
            {
                throw new WrongAgeException(student);
            }

            Console.WriteLine("Введите курс студента:");
            student.Course = int.Parse(Console.ReadLine());
            if (student.Course < 1 || student.Course > 6)
            {
                throw new WrongCourseValueException(student);
            }

            Console.WriteLine("Средний бал студента:");
            student.Score = int.Parse(Console.ReadLine());
            if (student.Score < 0 || student.Score > 100)
            {
                throw new WrongScoreValueException(student);
            }

            successEntered = true;
        }
        catch (EmptyNameAndSurenameException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WrongAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Недопустимый формат ввода");
        }
        catch (WrongCourseValueException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WrongScoreValueException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Возникла ошибка: {ex.Message}");
        }
        finally
        {
            if (successEntered)
            {
                students.Add(student);
                Console.WriteLine($"Информация о студенте '{student.Name}' успешно добавлена в реестр университета!");
            }
        }

    }
        public void ShowAllStudents(List<Student> students)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Список всех студентов в реестре университета:");
            students.ForEach(eachStudent => Console.WriteLine(eachStudent));

        }

        public void SearchStudent(List<Student> students)
        {
            Console.WriteLine("Введите имя студента, которого нужно найти в реестре:");
            string nameToSearch = Console.ReadLine();
            foreach (var student in students)
            {
                if (nameToSearch == student.Name)
                {
                    var foundStudent = student;
                    Console.WriteLine("======= Результаты поиска ==========");
                    Console.WriteLine(foundStudent);
                }
                else
                {
                    Console.WriteLine("Такого студента в реестре нет");
                }
            }
        }
}