/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall\tGrace\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumExamScore= 0;
    int sumExtraCredit = 0;

    decimal currentStudentOverall = 0;
    decimal currentStudentExamScore = 0;
    int currentStudentExtraCredit = 0;
    decimal currentStudentPTS = 0;

    int gradedAssignments = 0;
    int extraCreditAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {       
            sumExamScore += score;
        }
        else
        {
            extraCreditAssignments++;
            sumExtraCredit += score;
        }
    }

    currentStudentExamScore = (decimal)(sumExamScore) / examAssignments;
    currentStudentExtraCredit = (sumExtraCredit) / extraCreditAssignments;
    currentStudentOverall = (sumExamScore + ((decimal)sumExtraCredit / 10)) / examAssignments;
    currentStudentPTS = (decimal)sumExtraCredit / 10 / examAssignments;

    if (currentStudentOverall >= 97)
        currentStudentGrade = "A+";

    else if (currentStudentOverall >= 93)
        currentStudentGrade = "A";

    else if (currentStudentOverall >= 90)
        currentStudentGrade = "A-";

    else if (currentStudentOverall >= 87)
        currentStudentGrade = "B+";

    else if (currentStudentOverall >= 83)
        currentStudentGrade = "B";

    else if (currentStudentOverall >= 80)
        currentStudentGrade = "B-";

    else if (currentStudentOverall >= 77)
        currentStudentGrade = "C+";

    else if (currentStudentOverall >= 73)
        currentStudentGrade = "C";

    else if (currentStudentOverall >= 70)
        currentStudentGrade = "C-";

    else if (currentStudentOverall >= 67)
        currentStudentGrade = "D+";

    else if (currentStudentOverall >= 63)
        currentStudentGrade = "D";

    else if (currentStudentOverall >= 60)
        currentStudentGrade = "D-";

    else
        currentStudentGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    
    Console.Write($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentOverall}\t{currentStudentGrade}\t");
    Console.WriteLine($"{currentStudentExtraCredit} ({currentStudentPTS} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();
