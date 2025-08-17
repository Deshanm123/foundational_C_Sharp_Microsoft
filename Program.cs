using System;
// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

Console.WriteLine("Student\t\tGrade\n");
foreach (string studentName in studentNames)
{
    decimal averageScore = getAverageScore(sumOfScores(getScoresOfStudent(studentName)));
    Console.WriteLine($"{studentName}:\t\t {averageScore} \t{getAverageScoreGrade(averageScore)}");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


int[] getScoresOfStudent(string studentName)
{
    if (studentName == "Sophia")
        return sophiaScores;

    else if (studentName == "Andrew")
        return andrewScores;

    else if (studentName == "Emma")
        return emmaScores;

    else if (studentName == "Logan")
        return loganScores;
    else
        throw new NotImplementedException();
}


int sumOfScores(int[] scoreArr)
{
    int scoreCount = 1;
    int sumofScores = 0;
    foreach (int score in scoreArr)
    {   
        if (scoreCount <= currentAssignments)
        {
            sumofScores += score;
        }
        else
        {
           // sumofScores += score / 10;
            //sumofScores  += Convert.ToInt32( score * 0.1M);
        }
        scoreCount++;
    }
    return sumofScores;
}

decimal getAverageScore(int sumOfScores)
{
    return (decimal)sumOfScores / currentAssignments;
}


string getAverageScoreGrade(decimal averageScore)
{
    if (averageScore >= 97.0M && averageScore <= 100.0M)
        return "A+";
    else if (averageScore >= 93.0M)
        return "A";
    else if (averageScore >= 90.0M)
        return "A-";
    else if (averageScore >= 87.0M)
        return "B+";
    else if (averageScore >= 83.0M)
        return "B";
    else if (averageScore >= 80.0M)
        return "B-";
    else if (averageScore >= 77.0M)
        return "C+";
    else if (averageScore >= 73.0M)
        return "C";
    else if (averageScore >= 70.0M)
        return "C-";
    else if (averageScore >= 67.0M)
        return "D+";
    else if (averageScore >= 63.0M)
        return "D";
    else if (averageScore >= 60.0M)
        return "D-";
    else if (averageScore <= 59.0M && averageScore >= 0.0M)
        return "F";
    else
        throw new Exception("Cannot provide a grade due to Invalid Marks");
}