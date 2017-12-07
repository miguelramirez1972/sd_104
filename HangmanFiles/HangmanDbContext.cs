namespace Hangman_GUI_app
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HangmanDbContext : DbContext
    {
        // Your context has been configured to use a 'HangmanDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hangman_GUI_app.HangmanDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HangmanDbContext' 
        // connection string in the application configuration file.
        public HangmanDbContext()
            : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-Hangman_webforms-20171204073328.mdf;Initial Catalog=aspnet-Hangman_webforms-20171204073328;Integrated Security=True")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<HangManGamer> HangManGamers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}