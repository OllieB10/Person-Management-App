using System;
using System.Windows.Forms;
using Autofac;
using DataAccess;
using PersonModel;

namespace PersonUI
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create the container instance
            ContainerBuilder builder = new ContainerBuilder();

            // Register all our types.
            builder.RegisterType<HomePage>().InstancePerLifetimeScope().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
            builder.RegisterType<NewPerson>().As<INewPerson>().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
            builder.RegisterType<ViewPersonPage>().As<IViewPersonPage>().PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);
            builder.RegisterType<DataManager>().As<IDataManager>();
            builder.RegisterType<DatabaseConnection>().As<IDatabaseConnection>();
            builder.RegisterType<DatabaseOperations>().As<IDatabaseOperations>();
            builder.RegisterType<Person>().As<IPerson>();     
            builder.RegisterType<ExitApplication>().As<IExitApplication>();
            builder.RegisterType<MessagesToUser>().As<IMessagesToUser>();
            builder.RegisterType<NewPersonChecks>().As<INewPersonChecks>();
            builder.RegisterType<ControlColours>().As<IControlColours>();
            builder.RegisterType<TextboxHighlighter>().As<ITextboxHighlighter>();
            builder.RegisterType<GenderSelectionHandler>().As<IGenderSelectionHandler>();
            builder.RegisterType<PeopleLoader>().As<IPeopleLoader>();

            // Build the container
            IContainer container = builder.Build();

            // Begin the lifetime scope of the container
            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                // Resolve means new instance.
                HomePage homePage = scope.Resolve<HomePage>();

                // Run the application starting at homepage.
                Application.Run(homePage);
            }                 
        }
    }
}
