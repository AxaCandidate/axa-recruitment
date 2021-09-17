# axa-recruitment

Jakub Piaszczak

----

- Utilized libraries:
  - NUnit - for test structure
  - RestSharp - for HTTP communication
  - Selenium WebDriver - for GUI interaction
  - FluentAssertions - to make assertions easier
  - Serilog - for logging
- .NET Framework 4.7.2
- Verified for browsers:
  - Chrome 93. ChromeDriver is automatically taken (nuget package)
  - Edge 93. MicrosoftWebDriver is stored under Drivers directory
  - I chose these browsers because they're the most popular ones across the world in 2021, except for Safari, but I wanted to avoid cross-platform tests (source: https://en.wikipedia.org/wiki/Usage_share_of_web_browsers)
  - To change the browser, open solution in the Visual Studio -> expand Avanssur.Automation.GuiTests project -> double click on Properties -> Settings -> Set value for "Browser" (Chrome/Edge)
- Logs are by default stored under "C:\Temp\Logs". This can be adjusted in Settings of Avanssur.Automation.Utils project
- I wasn't sure about requirements for task 2, as a) and b) says actually the same thing (a - distance to Chlodna 51 from Plac Defilad 1, b - distance from Plac Defilad 1 to Chlodna 51), so I assumed that it was meant to invert those points in the second test.