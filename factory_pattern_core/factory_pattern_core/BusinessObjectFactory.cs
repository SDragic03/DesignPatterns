namespace factory_pattern_core
{
    public static class BusinessObjectFactory
    {
        // BusinessObject "is a" IBusiness
        public static IBusiness Create()
        {
            // We can use a "config" operation to determine what object to instantiate
            if (Settings.UseOriginal)
            {
                return new BusinessObject();
            }

            return new NewerBusinessObject();
        }
    }
}