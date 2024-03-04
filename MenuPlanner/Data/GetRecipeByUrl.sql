SELECT [t].[Id], [t].[ChildRecipeSortOrder], [t].[CountryCode], [t].[DateCreated], [t].[DateUpdated], [t].[Description], [t].[DifficultyLevel], [t].[IsPublished], [t].[Name], [t].[ParentRecipeId], [t].[PrepTime], [t].[RatingAverage], [t].[Url], [t].[UserId], [t].[Id0], [t].[AccessFailedCount], [t].[ConcurrencyStamp], [t].[DateRegistered], [t].[Email], [t].[EmailConfirmationExpiryDate], [t].[EmailConfirmed], [t].[Facebook], [t].[FirstName], [t].[HasBackgropImage], [t].[HasProfileImage], [t].[Instagram], [t].[Introduction], [t].[IsProtectedSystemUser], [t].[LastName], [t].[LockoutEnabled], [t].[LockoutEnd], [t].[NormalizedEmail], [t].[NormalizedUserName], [t].[PasswordHash], [t].[PhoneNumber], [t].[PhoneNumberConfirmed], [t].[SecurityStamp], [t].[TwitterX], [t].[TwoFactorEnabled], [t].[UserName], [t].[Website], [t].[ISO3166_2], [t].[Name0], [t0].[RecipeId], [t0].[IngredientId], [t0].[Amount], [t0].[Notes], [t0].[SortOrder], [t0].[Unit], [t0].[Id], [t0].[Alias], [t0].[DateCreated], [t0].[DateUpdated], [t0].[DateVerified], [t0].[Description], [t0].[EnergyKcalPer100g], [t0].[HasImage], [t0].[IsNutritionallyVerified], [t0].[IsPublished], [t0].[Name], [t0].[Type], [t0].[Url], [t0].[VerificationAuthority], [t0].[VerificationAuthorityPerson], [r1].[Id], [r1].[Image], [r1].[RecipeId], [r1].[SortOrder], [r1].[Text], [r1].[Title], [r2].[Id], [r2].[Image], [r2].[RecipeId], [r2].[SortOrder], [r2].[Text], [r2].[Title], [t1].[Id], [t1].[ChildRecipeSortOrder], [t1].[CountryCode], [t1].[DateCreated], [t1].[DateUpdated], [t1].[Description], [t1].[DifficultyLevel], [t1].[IsPublished], [t1].[Name], [t1].[ParentRecipeId], [t1].[PrepTime], [t1].[RatingAverage], [t1].[Url], [t1].[UserId], [t1].[Id0], [t1].[AccessFailedCount], [t1].[ConcurrencyStamp], [t1].[DateRegistered], [t1].[Email], [t1].[EmailConfirmationExpiryDate], [t1].[EmailConfirmed], [t1].[Facebook], [t1].[FirstName], [t1].[HasBackgropImage], [t1].[HasProfileImage], [t1].[Instagram], [t1].[Introduction], [t1].[IsProtectedSystemUser], [t1].[LastName], [t1].[LockoutEnabled], [t1].[LockoutEnd], [t1].[NormalizedEmail], [t1].[NormalizedUserName], [t1].[PasswordHash], [t1].[PhoneNumber], [t1].[PhoneNumberConfirmed], [t1].[SecurityStamp], [t1].[TwitterX], [t1].[TwoFactorEnabled], [t1].[UserName], [t1].[Website], [t1].[ISO3166_2], [t1].[Name0], [t1].[RecipeId], [t1].[IngredientId], [t1].[Amount], [t1].[Notes], [t1].[SortOrder], [t1].[Unit], [t1].[Id1], [t1].[Alias], [t1].[DateCreated0], [t1].[DateUpdated0], [t1].[DateVerified], [t1].[Description0], [t1].[EnergyKcalPer100g], [t1].[HasImage], [t1].[IsNutritionallyVerified], [t1].[IsPublished0], [t1].[Name1], [t1].[Type], [t1].[Url0], [t1].[VerificationAuthority], [t1].[VerificationAuthorityPerson], [t1].[Id2], [t1].[Image], [t1].[RecipeId0], [t1].[SortOrder0], [t1].[Text], [t1].[Title], [t1].[Id3], [t1].[Image0], [t1].[RecipeId1], [t1].[SortOrder1], [t1].[Text0], [t1].[Title0]
      FROM (
          SELECT TOP(2) [r].[Id], [r].[ChildRecipeSortOrder], [r].[CountryCode], [r].[DateCreated], [r].[DateUpdated], [r].[Description], [r].[DifficultyLevel], [r].[IsPublished], [r].[Name], [r].[ParentRecipeId], [r].[PrepTime], [r].[RatingAverage], [r].[Url], [r].[UserId], [a].[Id] AS [Id0], [a].[AccessFailedCount], [a].[ConcurrencyStamp], [a].[DateRegistered], [a].[Email], [a].[EmailConfirmationExpiryDate], [a].[EmailConfirmed], [a].[Facebook], [a].[FirstName], [a].[HasBackgropImage], [a].[HasProfileImage], [a].[Instagram], [a].[Introduction], [a].[IsProtectedSystemUser], [a].[LastName], [a].[LockoutEnabled], [a].[LockoutEnd], [a].[NormalizedEmail], [a].[NormalizedUserName], [a].[PasswordHash], [a].[PhoneNumber], [a].[PhoneNumberConfirmed], [a].[SecurityStamp], [a].[TwitterX], [a].[TwoFactorEnabled], [a].[UserName], [a].[Website], [c].[ISO3166_2], [c].[Name] AS [Name0]
          FROM [Recipes] AS [r]
          LEFT JOIN [AspNetUsers] AS [a] ON [r].[UserId] = [a].[Id]
          LEFT JOIN [Countries] AS [c] ON [r].[CountryCode] = [c].[ISO3166_2]
          WHERE [r].[Url] = @__url_0
      ) AS [t]
      LEFT JOIN (
          SELECT [r0].[RecipeId], [r0].[IngredientId], [r0].[Amount], [r0].[Notes], [r0].[SortOrder], [r0].[Unit], [i].[Id], [i].[Alias], [i].[DateCreated], [i].[DateUpdated], [i].[DateVerified], [i].[Description], [i].[EnergyKcalPer100g], [i].[HasImage], [i].[IsNutritionallyVerified], [i].[IsPublished], [i].[Name], [i].[Type], [i].[Url], [i].[VerificationAuthority], [i].[VerificationAuthorityPerson]
          FROM [RecipeIngredients] AS [r0]
          INNER JOIN [Ingredients] AS [i] ON [r0].[IngredientId] = [i].[Id]
      ) AS [t0] ON [t].[Id] = [t0].[RecipeId]
      LEFT JOIN [RecipeSteps] AS [r1] ON [t].[Id] = [r1].[RecipeId]
      LEFT JOIN [RecipeNotes] AS [r2] ON [t].[Id] = [r2].[RecipeId]
      LEFT JOIN (
          SELECT [r3].[Id], [r3].[ChildRecipeSortOrder], [r3].[CountryCode], [r3].[DateCreated], [r3].[DateUpdated], [r3].[Description], [r3].[DifficultyLevel], [r3].[IsPublished], [r3].[Name], [r3].[ParentRecipeId], [r3].[PrepTime], [r3].[RatingAverage], [r3].[Url], [r3].[UserId], [a0].[Id] AS [Id0], [a0].[AccessFailedCount], [a0].[ConcurrencyStamp], [a0].[DateRegistered], [a0].[Email], [a0].[EmailConfirmationExpiryDate], [a0].[EmailConfirmed], [a0].[Facebook], [a0].[FirstName], [a0].[HasBackgropImage], [a0].[HasProfileImage], [a0].[Instagram], [a0].[Introduction], [a0].[IsProtectedSystemUser], [a0].[LastName], [a0].[LockoutEnabled], [a0].[LockoutEnd], [a0].[NormalizedEmail], [a0].[NormalizedUserName], [a0].[PasswordHash], [a0].[PhoneNumber], [a0].[PhoneNumberConfirmed], [a0].[SecurityStamp], [a0].[TwitterX], [a0].[TwoFactorEnabled], [a0].[UserName], [a0].[Website], [c0].[ISO3166_2], [c0].[Name] AS [Name0], [t2].[RecipeId], [t2].[IngredientId], [t2].[Amount], [t2].[Notes], [t2].[SortOrder], [t2].[Unit], [t2].[Id] AS [Id1], [t2].[Alias], [t2].[DateCreated] AS [DateCreated0], [t2].[DateUpdated] AS [DateUpdated0], [t2].[DateVerified], [t2].[Description] AS [Description0], [t2].[EnergyKcalPer100g], [t2].[HasImage], [t2].[IsNutritionallyVerified], [t2].[IsPublished] AS [IsPublished0], [t2].[Name] AS [Name1], [t2].[Type], [t2].[Url] AS [Url0], [t2].[VerificationAuthority], [t2].[VerificationAuthorityPerson], [r4].[Id] AS [Id2], [r4].[Image], [r4].[RecipeId] AS [RecipeId0], [r4].[SortOrder] AS [SortOrder0], [r4].[Text], [r4].[Title], [r5].[Id] AS [Id3], [r5].[Image] AS [Image0], [r5].[RecipeId] AS [RecipeId1], [r5].[SortOrder] AS [SortOrder1], [r5].[Text] AS [Text0], [r5].[Title] AS [Title0]
          FROM [Recipes] AS [r3]
          LEFT JOIN [AspNetUsers] AS [a0] ON [r3].[UserId] = [a0].[Id]
          LEFT JOIN [Countries] AS [c0] ON [r3].[CountryCode] = [c0].[ISO3166_2]
          LEFT JOIN (
              SELECT [r6].[RecipeId], [r6].[IngredientId], [r6].[Amount], [r6].[Notes], [r6].[SortOrder], [r6].[Unit], [i0].[Id], [i0].[Alias], [i0].[DateCreated], [i0].[DateUpdated], [i0].[DateVerified], [i0].[Description], [i0].[EnergyKcalPer100g], [i0].[HasImage], [i0].[IsNutritionallyVerified], [i0].[IsPublished], [i0].[Name], [i0].[Type], [i0].[Url], [i0].[VerificationAuthority], [i0].[VerificationAuthorityPerson]
              FROM [RecipeIngredients] AS [r6]
              INNER JOIN [Ingredients] AS [i0] ON [r6].[IngredientId] = [i0].[Id]
          ) AS [t2] ON [r3].[Id] = [t2].[RecipeId]
          LEFT JOIN [RecipeSteps] AS [r4] ON [r3].[Id] = [r4].[RecipeId]
          LEFT JOIN [RecipeNotes] AS [r5] ON [r3].[Id] = [r5].[RecipeId]
          WHERE [r3].[ParentRecipeId] <> [r3].[Id]
      ) AS [t1] ON [t].[Id] = [t1].[ParentRecipeId]
      ORDER BY [t].[Id], [t].[Id0], [t].[ISO3166_2], [t0].[SortOrder], [t0].[RecipeId], [t0].[IngredientId], [t0].[Id], [r1].[SortOrder], [r1].[Id], [r2].[SortOrder], [r2].[Id], [t1].[ChildRecipeSortOrder], [t1].[Id], [t1].[Id0], [t1].[ISO3166_2], [t1].[SortOrder], [t1].[RecipeId], [t1].[IngredientId], [t1].[Id1], [t1].[SortOrder0], [t1].[Id2], [t1].[SortOrder1]