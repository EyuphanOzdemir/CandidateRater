using System.Reflection;

namespace Common
{
    public class Reflection
    {
        public static bool ArePropertiesEqual<T>(T obj1, T obj2)
        {
            // Get all public instance properties
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Iterate through each property
            foreach (var property in properties)
            {
                // Get property values for both objects
                object value1 = property.GetValue(obj1)!;
                object value2 = property.GetValue(obj2)!;

                // If values are not equal, return false
                if (!Equals(value1, value2))
                {
                    return false;
                }
            }

            // All properties match, return true
            return true;
        }
    }
}
