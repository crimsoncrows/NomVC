Important:
This project uses Guna.UI2 WinForms, installed through NuGet Package Manager. We installed this because we want the program to have organized, few functional forms. This helped us save time in coding. For the application to load correctly and avoid designer errors, the solution must be opened properly using the steps below.
Clone LatestUpdate branch (https://github.com/crimsoncrows/NomVC) or extract the project folder.


Open the .sln (Solution) file using Visual Studio 2022 or later.


You might see an error displayed, this is because the solution wasn’t built yet. Do not ignore and continue as the design will vanish completely. Before opening any form in Design View:


Go to
 Build → Build Solution,
 or press Ctrl + Shift + B.


After the build, Visual Studio will automatically:


Restore the required NuGet packages, including Guna.UI2.WinForms


Load all UI components properly


Once the build succeeds, you can now open forms in Design View without errors.
