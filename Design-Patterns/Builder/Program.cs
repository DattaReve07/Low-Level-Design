// See https://aka.ms/new-console-template for more information

using Builder;

Console.WriteLine("=========== Builder Design Pattern ===========");


var bcaDirector = new StudentRegistrationDirector(new BCAStudentBuilder());
var mbaDirector = new StudentRegistrationDirector(new MBAStudentBuilder());


var bcaStudent = bcaDirector.createStudent();
var mbaStudent = mbaDirector.createStudent();

Console.WriteLine(bcaStudent!.ToString());
Console.WriteLine(mbaStudent!.ToString());

