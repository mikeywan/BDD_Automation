Steps to run this sample:

1. Clone this project:

   git clone git@github.com:mikeywan/BDD_Automation.git
   
2. Import Project DemoWebApp.Tests

3. Install NUnit within Visual Studio

4. Install NUnit.Console within Visual Studio

5. Install Selenium.WebDriver within Visual Studio

6. Install SpecFlow within Visual Studio

7. Install xunit.assert within Visual Studio

8. Build Project then run it within PowerShell
   
   nunit3-console.exe "DemoWebApp.Tests.dll" --where "cat == 'smoke'"
