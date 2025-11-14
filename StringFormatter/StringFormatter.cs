using System.Text;

namespace PointsBet_Backend_Online_Code_Test {

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote)
        {

            if (items?.Length == 0) return "";

            if (items?.Length > 1) return string.Join(quote, items);

            return items == null ? "" : items.First();
        }
    }
}
