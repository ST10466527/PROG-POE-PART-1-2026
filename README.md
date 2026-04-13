# CyberSecurity Awareness Bot – PROG POE Part 1 (2026)

## Project Overview
This repository contains my Programming POE Part 1 project, developed in **C#** using the **.NET 8.0 framework**. The project is a **CyberSecurity Awareness Bot**, designed to educate users about safe online practices in a simple and interactive way.  

The bot welcomes the user with a logo and greeting sound, asks for their name, and then provides a menu of questions. Through friendly responses, it raises awareness about important cybersecurity topics such as password safety, phishing, and safe browsing.

---

## Purpose of the Bot
The main goal of this bot is to make cybersecurity education more engaging. Instead of reading static information, users interact with a chatbot that responds in real time. This helps people:
- Understand basic online safety principles.
- Learn about common threats like phishing.
- Build awareness of secure habits in a fun and approachable way.

---

## Features
- **Interactive Menu**: Users can ask questions and receive tailored responses.
- **Personalized Greeting**: The bot asks for the user’s name and responds directly to them.
- **Audio Integration**: Plays a greeting sound (`greeting.wav`) using the `SoundPlayer` class.
- **Typing Effect**: Messages appear with a typewriter effect for a more human feel.
- **Colorful Console Output**: Uses different colors for questions, answers, and warnings to improve readability.

---

## Technical Setup
### Project File (`.csproj`)
The project is configured to:
- Target **.NET 8.0**.
- Output as an executable (`Exe`).
- Enable **implicit usings** and **nullable reference types**.
- Include the **System.Windows.Extensions** package (required for `SoundPlayer`).
- Copy the `greeting.wav` file to the output directory so it is always available when the program runs.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="System.Windows.Extensions" Version="8.0.0" />
  </ItemGroup>

  <ItemGroup>
    <Content Include="greeting.wav">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
</Project>
```

---

## GitHub Workflow
A **workflow** is an automated process that runs on GitHub whenever code is pushed or a pull request is made. It ensures the project builds correctly in a clean environment.  

My workflow is called **.NET Build** and it:
1. Checks out the repository.
2. Sets up **.NET 8.0**.
3. Restores dependencies.
4. Builds the project.

```yaml
name: .NET Build

on:
  push:
    branches: [ "main" ]
  pull_request:
    branches: [ "main" ]

jobs:
  build:
    runs-on: windows-latest

    steps:
    - name: Checkout repository
      uses: actions/checkout@v3

    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '8.0.x'

    - name: Restore dependencies
      working-directory: "./PROG-POE-PART-1"
      run: dotnet restore "PROG-POE-PART-1.csproj"

    - name: Build project
      working-directory: "./PROG-POE-PART-1"
      run: dotnet build "PROG-POE-PART-1.csproj" --no-restore
```

---

## Challenges and Learning
Setting up the workflow was one of the most challenging parts of this project. At first, the workflow failed because the `.csproj` file could not be found. I had to carefully adjust the working directory paths and make sure the dependencies were restored before building. I also struggled with specifying the correct .NET version, but after trial and error, I successfully configured it to run on **.NET 8.0**.  

Through these struggles, I learned the importance of debugging automation scripts, paying attention to detail, and being patient when things don’t work the first time.

---

## How to Run
1. Clone the repository.
2. Ensure you have **.NET 8.0 SDK** installed.
3. Build and run the project:
   ```bash
   dotnet build
   dotnet run
   ```
4. Interact with the bot through the console.

---

## Impact
This project benefits people by making cybersecurity awareness more accessible. Instead of reading long documents, users can interact with a bot that teaches them safe online practices in a conversational way. It’s a small step toward promoting digital safety in everyday life.

---

## Future Improvements
While the current version is functional, there are several ways to expand the project:
- Add more questions and answers covering wider cybersecurity topics.
- Include a scoring or quiz system to test user knowledge.
- Integrate a graphical user interface (GUI) for a more modern experience.
- Provide links to external resources for deeper learning.
- Expand audio features with different sound effects for responses.

---

## Author
Developed by **Silindokuhle**, second‑year Diploma in Software Development student, Cape Town, South Africa.  
