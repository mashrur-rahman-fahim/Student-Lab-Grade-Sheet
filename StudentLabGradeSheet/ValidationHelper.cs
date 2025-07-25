using System;
using System.Text.RegularExpressions;

namespace StudentLabGradeSheet
{
    public static class ValidationHelper
    {
        public static bool IsValidRollNumber(string rollNo)
        {
            if (string.IsNullOrWhiteSpace(rollNo))
                return false;

            // Pattern for roll numbers like 2019-SE-001, 2020-CS-123, etc.
            string pattern = @"^\d{4}-[A-Z]{2,4}-\d{3}$";
            return Regex.IsMatch(rollNo.ToUpper(), pattern);
        }

        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Name should contain only letters and spaces, at least 2 characters
            string pattern = @"^[a-zA-Z\s]{2,50}$";
            return Regex.IsMatch(name.Trim(), pattern);
        }

        public static bool IsValidMarks(int marks, int maxMarks)
        {
            return marks >= 0 && marks <= maxMarks;
        }

        // Specific validation methods for each component
        public static bool IsValidAttendance(int attendance)
        {
            return attendance >= 0 && attendance <= 20;
        }

        public static bool IsValidOnline(int online)
        {
            return online >= 0 && online <= 10;
        }

        public static bool IsValidAssignment(int assignment)
        {
            return assignment >= 0 && assignment <= 20;
        }

        public static bool IsValidProject(int project)
        {
            return project >= 0 && project <= 50;
        }

        // Method to validate and clamp marks to valid range
        public static int ClampAttendance(int attendance)
        {
            return Math.Max(0, Math.Min(attendance, 20));
        }

        public static int ClampOnline(int online)
        {
            return Math.Max(0, Math.Min(online, 10));
        }

        public static int ClampAssignment(int assignment)
        {
            return Math.Max(0, Math.Min(assignment, 20));
        }

        public static int ClampProject(int project)
        {
            return Math.Max(0, Math.Min(project, 50));
        }

        // Get validation error message for specific component
        public static string GetMarksValidationError(string component, int marks, int maxMarks)
        {
            if (marks < 0)
                return $"{component} cannot be negative";
            if (marks > maxMarks)
                return $"{component} cannot exceed {maxMarks}";
            return "";
        }

        public static string FormatRollNumber(string rollNo)
        {
            if (string.IsNullOrWhiteSpace(rollNo))
                return "";

            return rollNo.ToUpper().Trim();
        }

        public static string FormatName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "";

            // Capitalize first letter of each word
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower().Trim());
        }
    }
}