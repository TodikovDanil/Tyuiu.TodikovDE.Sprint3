using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TodikovDE.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char chr in value)
            {
                value = value.Replace(replaceable, replacement);
            }
            return value;
        }
    }
}
