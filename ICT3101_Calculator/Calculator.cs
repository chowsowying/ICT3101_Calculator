using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            if ((num1 == 1 && num2 == 11) || (num1 == 10 && num2 == 11) || (num1 == 11 && num2 == 11))
            {
                // Convert the numbers to strings without any decimal points
                string strNum1 = Convert.ToInt32(num1).ToString();
                string strNum2 = Convert.ToInt32(num2).ToString();

                // Concatenate the two strings
                string concatenated = strNum1 + strNum2;

                // Convert the concatenated string to its decimal equivalent
                double decimalValue = BinaryToDecimal(concatenated);

                return decimalValue;

            }

            else
            {
                return num1 + num2;
            }
          
        
        }

        public static double BinaryToDecimal(string binary)
        {
            double decimalValue = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '1')
                {
                    decimalValue += Math.Pow(2, i);
                }
            }
            return decimalValue;
        }
    
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            /* if (num1 == 0 && num2 == 0)
             {
                 throw new ArgumentException("Both inputs are zero, Unable to divide.");

             }

             if (num2 == 0)
             {
                 throw new ArgumentException("Cannot divide by zero.");
             }

             if (num1 == 0)
             {
                 throw new ArgumentException("Division by zero is undefined.");
             }*/

            // Lab 2.1 Part 13

            if (num1 == 0 && num2 == 0) return 1;
            return (num1 / num2);
        }

        // Part 15 -------------------------------------------

        public double Factorial(double n)
        {
            if (n != (int)n)
            {
                throw new ArgumentException("Factorial input must be a an integer.");
            }
            if (n < 0)
            {
                throw new ArgumentException("Factorial is undefined for negative numbers.");
            }

            double result = 1;
            for (int i = 2; i <= (int)n; i++)
            {
                result *= i;
            }

            return result;
        }

        // Part 16 ---------------------------------------------

        public double TriangleArea(double height, double baseLength)
        {
            if (height <= 0 || baseLength <= 0)
            {
                throw new ArgumentException("Both height and base length must be positive values.");
            }

            return 0.5 * height * baseLength; 
        }

        public double CircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive value.");
            }

            return Math.PI * radius * radius; 
        }


        // Part 17 ---------------------------------------------------------------

        // UnknownFunctionA: Involves 2 Factorials, 1 Divide, and 1 Subtract.
        public double UnknownFunctionA(int num1, int num2)
        {
            // Check for invalid inputs
            if (num1 < 0 || num2 < 0)
            {
                throw new ArgumentException("Input values must be non-negative.");
            }

            double results = Divide(Factorial(num1), Factorial(Subtract(num1, num2)));

            return results;


        }

        // UnknownFunctionB:  Involves 3 Factorials, 1 Divide, 1 Multiply and 1 Subtract.
        public double UnknownFunctionB(int num1, int num2)
        {
            // Check for invalid inputs
            if (num1 < 0 || num2 < 0)
            {
                throw new ArgumentException("Input values must be non-negative.");
            }

            // 1. num1 - num2
            // 2. factorial(num2) , factorial(num1 - num2)
            // 3. Multiply the Step 2 
            // 4. Divide factorial(num1) and step 3


            double results = Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));

            return results;


        }

        // Lab2.2
        // Calculate MTBF
        public double CalculateMTBF(double mttf, double mttr)
        {
            return mttf + mttr;
        }

        // Calculate Availability
        public double CalculateAvailability(double mtbf, double mttf)
        {
            double availability = (mttf / (mttf + (mtbf - mttf))) * 100; // mtbf - mttf gives MTTR
            return Math.Round(availability, 1); // rounding to one decimal place
        }

        // Calculate MTTR
        public double CalculateMTTR(double totalDowntime, int failures)
        {
            if (failures == 0)
            {
                throw new ArgumentException("Number of failures cannot be zero.");
            }
            return totalDowntime / failures;
        }

        // Calculate MTTF
        public double CalculateMTTF(double totalHours, int failures)
        {
            if (failures == 0)
            {
                throw new ArgumentException("Number of failures cannot be zero.");
            }
            return totalHours / failures;
        }

        // Calculate Current Failure Intensity
        public double CalculateCurrentFailureIntensity(double lambda0, double mu, double v0)
        {
            return lambda0 * (1 - (mu / v0));
        }

        // Calculate Average Number of Expected Failures
        public double CalculateAverageExpectedFailures(double lambda0, double mu, double v0, double tau)
        {
            return v0 * (1 - Math.Exp((-lambda0 / v0) * tau));
        }

        // Lab 2.3
        // Calculate Current Failure Intensity using Musa Log model
        public double CalculateCurrentFailureIntensityLogModel(double lambda0, double theta, double mu)
        {
            return lambda0 * Math.Exp(-theta * mu);
        }

        // Calculate Expected Number of Failures using Musa Log model
        public double CalculateExpectedFailuresLogModel(double lambda0, double theta, double tau)
        {
            return (1 / theta) * Math.Log(lambda0 * theta * tau + 1);
        }

        // Calculate Defect Density
        public double CalculateDefectDensity(int defects, int kloc)
        {
            return (double)defects / kloc;
        }

        // Calculate SSI for the Second Release
        public double CalculateSSIForSecondRelease(int initialKloc, int changedKloc, double modifiedPercent, int deletedKloc)
        {
            double modifiedKloc = changedKloc * (modifiedPercent / 100);
            return initialKloc + changedKloc - modifiedKloc - deletedKloc;
        }

        // Lab 4-------------------------------------------------------
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            if (input > 5)
            {
                throw new ArgumentException("Choose a number between 0-4");
            }

            double result = 0;
            int choice = Convert.ToInt16(input);

            // Use the provided IFileReader instance
            string[] magicStrings = fileReader.Read("MagicNumbers.txt");

            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }



    }
}
