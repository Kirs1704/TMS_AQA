// See https://aka.ms/new-console-template for more information

using Generics;


/*
var simplePerson = new SimplePerson(546, "Tom");
var objectPerson = new ObjectPerson("abc123", "Bob");
var objectPerson2 = new ObjectPerson(123, "Bob");        // здесь происходит "упаковка" значения int в объект
int intBobId = (int)objectPerson2.Id;                    // а здесь "распаковка" из объекта значения int

int tomId = simplePerson.Id;
string bobId = (string)objectPerson.Id;

Console.WriteLine($"Tom Id: {tomId}");
Console.WriteLine($"Bob Id: {bobId}");*/


// ===============================================  GENERICS ======================================================

var GP = new GenericPerson<int>(1, "Kirs"); // вот тут вместо <int> можно указать любой другой тип, например <string>. Тогда первый аргумент будет стринговый
GP.Print();
var GP2 = new GenericPerson<string>("-- 2 --", "Alex");
GP2.Print();
var GP3 = new GenericPerson<Guid>(Guid.NewGuid(), "Tomas"); // тут используется тип (класс) Guid, который с помощью метода Guid.NewGuid() генерит уникальное значение
GP3.Print();
var GP4 = new GenericPerson<Guid>(Guid.NewGuid(), "Dilan");
GP4.Print();

var company = new Company<GenericPerson<string>>(GP2);
var company2 = new Company<GenericPerson<int>>(GP);
var company3 = new Company<GenericPerson<Guid>>(GP3);

// ==============================================  Static =========================================================
StaticPerson<int>.code = 123;
StaticPerson<string>.code = "-- 123 --";

Console.WriteLine(StaticPerson<int>.code);
Console.WriteLine(StaticPerson<string>.code);

// ================================== Using 2 values of Generic (см. класс DoubleGeneric) =============================
var DG = new DoubleGeneric<Guid, int>(Guid.NewGuid(), 234, "TestName");


// ================================= Обобщенные методы ================================================================
int x = 10;
int y = 10;
Helper.Swap<int>(ref x, ref y);

string x2 = "Hello";
string y2 = "World";
Helper.Swap(ref x2, ref y2);


// =================================== Ограничения Generics ================================================

// ----------------------------------- Ограничения методов -------------------------------------------------
Helper.SendMessage(new Message("Hello, World!"));
Helper.SendMessage(new EmailMessage("Hello from Email"));
Helper.SendMessage(new SmsMessage("Hello from SMS"));
Helper.SendMessage<SmsMessage>(new SmsMessage("This is sms message"));


// --------------------------------- Ограничение обобщений в типах -----------------------------------------
// см. класс Messenger

var msg = new Messenger<Message>();
msg.SendMessage(new Message("Сообщение из мессенджера"));

var msg2 = new Messenger<EmailMessage>();
msg2.SendMessage(new EmailMessage("Сообщение из почты"));

var ms = new MessengerStruct<MessageStruct>();
