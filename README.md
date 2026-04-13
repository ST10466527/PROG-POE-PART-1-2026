# CyberSecurity Awareness Bot – PROG POE Part 1 (2026)

## Project Overview
The **CyberSecurity Awareness Bot** is a console-based application built in **C# with .NET 8.0**.  
It is designed to educate users about essential cybersecurity practices through an interactive and user-friendly interface.  

The bot simulates a conversational experience by greeting the user, requesting their name, and responding to selected questions.  
Its goal is to make cybersecurity education engaging and accessible, especially for users with limited technical knowledge.

---

## Purpose
The primary objective of this project is to **promote cybersecurity awareness** in an interactive manner.  
Instead of presenting static information, the bot allows users to actively engage with key concepts.

Through this interaction, users are able to:
- Understand fundamental online safety practices  
- Recognize common threats such as phishing attacks  
- Develop safer digital habits  
- Learn in a simple, engaging, and conversational way  

---

## Features
- **Interactive Question Menu** – Users select from predefined questions and receive informative responses.  
- **Personalized User Experience** – The bot prompts for the user’s name and responds directly to them.  
- **Audio Greeting** – A welcome sound (`greeting.wav`) is played using the `SoundPlayer` class.  
- **Typing Effect Simulation** – Messages are displayed with a typewriter effect for engagement.  
- **Color-Coded Console Output** – Prompts, responses, and errors are displayed in different colors for readability.  

---

## Technical Implementation

### Project Configuration (`.csproj`)
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

- Target Framework: **.NET 8.0**  
- Output Type: **Console Application (Exe)**  
- Audio functionality via **System.Windows.Extensions**  
- Automatic copying of audio file to output directory  

---

### GitHub Actions Workflow
This project includes a **CI workflow** to ensure successful builds whenever changes are pushed.

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

## System Requirements
- **.NET 8.0 SDK**  
- **Windows OS** (required for audio playback using `SoundPlayer`)  

---

## How to Run the Application
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository-name.git
   ```
2. Navigate to the project directory:
   ```bash
   cd PROG-POE-PART-1
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. Follow the on-screen prompts to interact with the bot.

---

## Screenshot

<img width="1573" height="857" alt="Screenshot 2026-04-13 195835" src="https://github.com/user-attachments/assets/8acd42c5-1d1a-4ad5-ba3f-39ba55f38d9a" />
<img width="1919" height="1023" alt="Screenshot 2026-04-13 200607" src="https://github.com/user-attachments/assets/2fbf864e-ee9f-4136-b9f9-db05b1f76903" />

---

## Challenges and Learning Outcomes
During development, several challenges were encountered:
- Initial build failures due to incorrect file paths and missing project references.  
- Integration of audio functionality required understanding external package dependencies.  

**Resolutions:**
- Correctly setting the working directory  
- Ensuring dependencies were restored before building  
- Aligning the project with the correct .NET 8.0 configuration  

**Skills Developed:**
- Debugging build and configuration errors  
- Understanding CI/CD workflows  
- Managing project dependencies  
- Writing cleaner, structured code  

---

## Impact
This project contributes to improving **digital safety awareness** by presenting cybersecurity concepts in an interactive format.  
It demonstrates how simple software solutions can educate users and encourage safer online behavior.

---

## Future Enhancements
- Expanding the range of cybersecurity topics  
- Implementing a quiz or scoring system  
- Developing a graphical user interface (GUI)  
- Integrating external educational resources  
- Enhancing audio and interaction features  
- Introducing AI-driven responses for dynamic conversations  

---

## Author
**Silindokuhle Makunga**  
Second-Year Diploma in Software Development  
Cape Town, South Africa  

---

## 🏁 Final Notes
This project demonstrates the **practical application of C# programming, user interaction design, and basic automation using GitHub Actions**.  
It highlights both technical implementation and problem-solving skills developed throughout the assignment.

---

