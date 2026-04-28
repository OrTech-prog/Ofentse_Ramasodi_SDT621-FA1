// ============================================================
// SDT621 – Section A, Question 1: Student Results Console App
// ============================================================

using System;

class StudentMarks
{
    static void Main(string[] args)
    {
        // ── Step 1: Ask for the student's name ──────────────────────
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        // ── Step 2: Collect three subject marks with validation ──────
        // We store the three marks in an array of doubles
        double[] marks = new double[3];

        for (int i = 1; i <= 3; i++)
        {
            // Keep asking until a valid numeric mark is entered
            while (true)
            {
                Console.Write($"Enter mark for Subject {i}: ");
                string input = Console.ReadLine();

                // double.TryParse returns true if conversion succeeded
                if (double.TryParse(input, out marks[i - 1]))
                {
                    break; // Valid number – exit the while loop
                }
                else
                {
                    // Numeric validation failure message
                    Console.WriteLine("  ⚠ Invalid input. Please enter a numeric value.");
                }
            }
        }

        // ── Step 3: Calculate total and average ─────────────────────
        double totalMarks = marks[0] + marks[1] + marks[2];
        double averageMarks = totalMarks / 3.0;

        // ── Step 4: Determine PASS or FAIL ──────────────────────────
        // Rule: average >= 50 is a PASS
        string result = averageMarks >= 50 ? "PASS" : "FAIL";

        // ── Step 5: Get the current date and time for the timestamp ──
        string issuedAt = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

        // ── Step 6: Display the results ─────────────────────────────
        Console.WriteLine();
        Console.WriteLine("===== STUDENT RESULTS =====");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Total Marks: {totalMarks}");

        // {averageMarks:F1} formats to 1 decimal place, e.g. 93,7
        Console.WriteLine($"Average Marks: {averageMarks:F1}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Result Issued At: {issuedAt}");
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");

        // Pause the console so the window stays open
        Console.ReadKey();
    }
}