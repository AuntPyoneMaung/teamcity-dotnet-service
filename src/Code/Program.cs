namespace Project
{
    using Topshelf;

    public static class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<Web>(s =>
                {
                    s.ConstructUsing(() => new Web());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Web Demo");
                x.SetDisplayName("WebDemo");
                x.SetServiceName("WebDemo");
<<<<<<< HEAD

                // Jenkins Push job automated
=======
                // Testing Automation

>>>>>>> 19520dbcc2d83a49d7df04bcbc7784022589c8a1
            });
        }
    }
}