Steps to run this sample:

1. Import Project DemoWebApp.Tests

2. Install NUnit within Visual Studio

3. Install NUnit.Console within Visual Studio

4. Install Selenium.WebDriver within Visual Studio

5. Install SpecFlow within Visual Studio

6. Install xunit.assert within Visual Studio

7. Build Project then run it within PowerShell
   nunit3-console.exe "DemoWebApp.Tests.dll" --where "cat == 'smoke'"
