using Event;

CollegeClassModel history = new CollegeClassModel("History 101", 3);
CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

history.EnrollmentFull += CollegeClass_EnrollmentFull;


history.SignUpStudent("Tad Pole").PrintToConsole();
history.SignUpStudent("Joy Pole").PrintToConsole();
history.SignUpStudent("Laluu Hu").PrintToConsole();
history.SignUpStudent("Lisa Lao").PrintToConsole();
history.SignUpStudent("J Wen").PrintToConsole();
Console.WriteLine();

math.EnrollmentFull += CollegeClass_EnrollmentFull;

void CollegeClass_EnrollmentFull(object? sender, string e)
{
    CollegeClassModel model = (CollegeClassModel)sender;
    Console.WriteLine();
    Console.WriteLine($"{model.CourseTitle}: Full");
    Console.WriteLine();
}

math.SignUpStudent("Laluu Hu").PrintToConsole();
math.SignUpStudent("Lisa Lao").PrintToConsole();
math.SignUpStudent("J Wen").PrintToConsole();



Console.ReadLine();
