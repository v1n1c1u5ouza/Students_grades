int currentAssignments = 5;

int[] sophiaGrades = { 93, 87, 98, 95, 100 };
int[] nicolasGrades = { 80, 83, 82, 88, 85 };
int[] zahirahGrades = { 84, 96, 73, 85, 79  };
int[] jeongGrades = { 90, 92, 98, 100, 97 };

decimal CalculateAvarage(int[] grades)
{
  int sum = 0; 
    foreach (int grade in grades)
    {
      sum += grade;
    }
    return (decimal)sum / currentAssignments;
}

string GetGrade(decimal score)
{
  if (score >= 97) return "A+";
  if (score >= 93) return "A";
  if (score >= 90) return "A-";
  if (score >= 87) return "B+";
  if (score >= 83) return "B";
  return "F";
}

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t{CalculateAvarage(sophiaGrades)}\t{GetGrade(CalculateAvarage(sophiaGrades))}");
Console.WriteLine($"Nicolas:\t{CalculateAvarage(nicolasGrades)}\t{GetGrade(CalculateAvarage(nicolasGrades))}");
Console.WriteLine($"Zahirah:\t{CalculateAvarage(zahirahGrades)}\t{GetGrade(CalculateAvarage(zahirahGrades))}");
Console.WriteLine($"Jeong:\t\t{CalculateAvarage(jeongGrades)}\t{GetGrade(CalculateAvarage(jeongGrades))}");
