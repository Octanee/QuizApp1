namespace QuizGUI1.Database
{
    using QuizGUI1.Source.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QuizContext : DbContext
    {
        public QuizContext()
            : base("name=QuizContext")
        {
        }

        public DbSet<Answer> Answers;
        public DbSet<Question> Questions;
        public DbSet<Quiz> Quizzes;
        public DbSet<Result> Results;
        public DbSet<User> Users;


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>().ToTable("Answers");
            modelBuilder.Entity<Question>().ToTable("Question");
            modelBuilder.Entity<Quiz>().ToTable("Quiz");
            modelBuilder.Entity<Result>().ToTable("Result");
            modelBuilder.Entity<User>().ToTable("User");

            base.OnModelCreating(modelBuilder);
        }
    }
}