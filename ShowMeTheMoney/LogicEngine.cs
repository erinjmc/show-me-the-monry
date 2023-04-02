using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeTheMoney
{
    public class LogicEngine
    {
        private const decimal max = 10000.00M;
        private const decimal min = .01M;
        private IDictionary NumbersInEnglish = new Dictionary<string, string>();
        private enum Denomination
        {

        }

        public LogicEngine()
        {
            BuildDictionary();
        }

        public string ResponseBuilder(string amount)
        {
            try
            {
                //Restict leading zeros
                if (amount.Substring(0, 1) == "0" && amount.Substring(1, 1) != ".")
                {
                    return "The amount entered can only have 1 leading zero before the decimal point!";
                }

                //Try to covert input string to decimal number 
                decimal amountAsDecimal = Convert.ToDecimal(amount);
                if (amountAsDecimal > max || amountAsDecimal < min || amountAsDecimal == 0)
                {
                    return $"The amount entered \'{amountAsDecimal}\' is outside of the limits - 0.01 to 10000";
                }

                return Compute(amountAsDecimal);
            }
            catch (FormatException fex)
            {
                //Trap error if decimal conversion fails
                return $"Your entry is not valid number! Error message: {fex.Message}";
            }
            catch (Exception ex)
            {
                //Catch all for any other logic error
                return $"Ooops! - Error message: {ex.Message}";

            }
        }

        public string Compute(decimal amountAsDecimal)
        {
            StringBuilder result = new StringBuilder();
            string amountAsString = amountAsDecimal.ToString("0.00");

            if (amountAsDecimal == max || amountAsDecimal == min)
            {
                if (amountAsDecimal == max)
                    result.Append($"{NumbersInEnglish["10"]} Thousand Dollars");

                if (amountAsDecimal == min)
                    result.Append($"{NumbersInEnglish["1"]} Cent");
            }
            else
            {
                string tens = string.Empty;
                string hundreds = string.Empty;
                string thousands = string.Empty;
                string dollars = string.Empty;
                string coins = string.Empty;

                var parts = amountAsString.Split('.');
                amountAsString = parts[0];
                var cents = parts[1];

                if (amountAsString == "0")
                {
                    amountAsString = string.Empty;
                }

                if (cents == "0")
                {
                    cents = string.Empty;
                }

                switch (amountAsString.Length)
                {
                    case 0:
                        break;
                    case 1:
                        tens = "0" + amountAsString;
                        break;
                    case 2:
                        tens = amountAsString;
                        break;
                    case 3:
                        tens = amountAsString.Substring(1, 2);
                        hundreds = amountAsString.Substring(0, 1);
                        break;
                    case 4:
                        tens = amountAsString.Substring(2, 2);
                        hundreds = amountAsString.Substring(1, 1);
                        thousands = amountAsString.Substring(0, 1);
                        break;
                    default:
                        break;
                }

                if (thousands != "")
                {
                    result.Append(SingleDigit(thousands));
                    result.Append("Thousand ");
                }

                if (hundreds != "" && hundreds != "0")
                {
                    result.Append(SingleDigit(hundreds));
                    result.Append("Hundred ");
                }

                if (tens != "" && tens != "00")
                {
                    if (thousands != "")
                    {
                        result.Append("and ");

                    }
                    else
                    {
                        if (hundreds != "" && hundreds != "0")
                        {
                            result.Append("and ");
                        }
                    }
                }

                if (tens != "" && tens != "00")
                {
                    result.Append(DoubleDigits(tens));
                }

                if (thousands != "" || !(hundreds == "" || hundreds == "0") || !(tens == "" || tens == "00"))
                {
                    if (tens != "" || tens != "00")
                    {
                        dollars = "Dollars";
                        if (tens == "01")
                        {
                            dollars = "Dollar";
                        }
                        result.Append(dollars + " ");
                    }

                }

                if (cents != "" && cents != "00")
                {
                    if (dollars != string.Empty)
                    {
                        result.Append("and ");
                    }
                    result.Append(DoubleDigits(cents));
                    coins = "Cents";
                    if (cents == "01")
                    {
                        coins = "Cent";
                    }
                    result.Append(coins);
                }
            }

            return result.ToString().Trim();
        }

        private string SingleDigit(string digit)
        {
            string s = string.Empty;
            s += NumbersInEnglish[digit] + " ";
            return s;
        }

        private string DoubleDigits(string digits)
        {
            string s = string.Empty;
            var digitsNum = Convert.ToInt32(digits);
            if (digitsNum < 20)
            {
                s += NumbersInEnglish[digits] + " ";
            }
            else
            {
                var first = digits.Substring(0, 1) + "0";
                var second = digits.Substring(1, 1);

                s += NumbersInEnglish[first] + " ";
                if (second != "0")
                {
                    s += NumbersInEnglish[second] + " ";
                }

            }

            return s;
        }

        private void BuildDictionary()
        {
            NumbersInEnglish = new Dictionary<string, string>()
            {
                {"0",""},{"1","One"},{"2","Two"},{"3","Three"},{"4","Four"},{"5","Five"},{"6","Six"},{"7","Seven"},{"8","Eight"},{"9","Nine"},
                {"00",""},{"01","One"},{"02","Two"},{"03","Three"},{"04","Four"},{"05","Five"},{"06","Six"},{"07","Seven"},{"08","Eight"},{"09","Nine"},{"10","Ten"},
                {"11","Eleven"},{"12","Tweleve"},{"13","Thirteen"},{"14","Fourteen"},{"15","Fifteen"},{"16","Sixteen"},{"17","Seventeen"},{"18", "Eighteen"},{"19", "Nineteen"},
                {"20","Twenty"},{"30","Thirty"},{"40","Forty"},{"50","Fifty"},{"60","Sixty"},{"70","Seventy"},{"80","Eighty"},{"90","Ninety"}
            };
        }
    }
}

