namespace StructandEnums
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new  Television();
        }
    }
}