﻿namespace NutriSportPro.API.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Customizing the ASP.NET Identity model and overriding the defaults names.
        builder.Entity<ApplicationRole>().ToTable("Roles");
        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");

        builder.ApplyConfiguration(new ApplicationUserConfiguration());
        builder.ApplyConfiguration(new TrainingConfiguration());
        builder.ApplyConfiguration(new DietaryRecommendationConfiguration());
        builder.ApplyConfiguration(new TrainingPlanConfiguration());
        builder.ApplyConfiguration(new NutritionConfiguration());
        builder.ApplyConfiguration(new StatisticConfiguration());
        builder.ApplyConfiguration(new FoodProgramConfiguration());
        builder.ApplyConfiguration(new ChatCoachConfiguration());
        builder.ApplyConfiguration(new CoachProfileConfiguration());
        builder.ApplyConfiguration(new SportsProfileConfiguration());
        builder.ApplyConfiguration(new ExerciseConfiguration());
    }
}
