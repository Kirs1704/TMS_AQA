using AbstractClasses;
using AbstractClasses.Game;

// создание объекта абстрактного класса как в примере ниже вызовет ошибку, т.к. нельзя создать объект абстрактного класса 
// AbstractClassTemplate abstractClassTemplate = new AbstractClassTemplate() ---- ошибка

Warrior warrior = new Warrior(); // создали экземпляр класса Warrior
Wizard wizard = new Wizard(); // создали экземпляр класса Wizard

warrior.Move();
warrior.Attack();
warrior.UseAbility();

wizard.Move();
wizard.Attack();
wizard.UseAbility();

warrior.name = "Tor"; // присвоили имя созданному выше экземпляру 
warrior.level = 25;   // присвоили уровень созданному выше экземпляру
warrior.PrintInfo();  // использовали метод PrintInfo, определенный в классе-шиблоне. Выведет в консоль: "Имя: Tor, Уровень: 25"

// Мы не можем создать экземпляр класса-шаблона, НО можем создать массив

Character[] characters = new Character[3];  // создали массив из 3 объектов (пока не определили каких именно - Warrior или Wizard)

characters[0] = new Wizard();               // первым объектов в массиве сделали Wizard
characters[1] = new Warrior();              // вторым объектов в массиве сделали Warrior
characters[2] = new Warrior();              // третьим объектов в массиве сделали Warrior

foreach (var character in characters)       // с помощью цикла прошлись по каждому объекту из массива
{
    character.Move();                      
    character.Attack();
    character.UseAbility();
}