using System.Threading.Channels;

namespace name_of
{
    public static class nameOf_Practice_02
    {
        static string miVariable = "Hola, Mundo";

        public static string DevolverNameOf()
        {
            return (nameof(miVariable));
        }
    }
}
