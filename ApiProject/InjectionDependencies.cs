namespace ApiProject
{
    public static class InjectionDependencies
    {
        public static void Repositorys(IServiceCollection collection)
        {
        }

        public static void Interface(IServiceCollection collection)
        {
            
        }

        public static void RegisterRepos(this IServiceCollection collection)
        {
            Repositorys(collection);
            Interface(collection);
        }
    }
}
