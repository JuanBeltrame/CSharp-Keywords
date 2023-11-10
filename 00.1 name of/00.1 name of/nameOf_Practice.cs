using System.Threading.Channels;

namespace _00._1_name_of
{
    public static class nameOf_Practice
    {
        static string miVariable = "Hola, Mundo";

        public static string DevolverNameOf()
        {
            return (nameof(miVariable));
        }
    }
}
