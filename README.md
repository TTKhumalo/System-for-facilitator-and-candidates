# System for Facilitator and Candidates

## 🌟 Overview
This is a **Windows desktop application** built with **VB.NET** and **.NET 6.0**. The system manages interactions between **facilitators** and **candidates** in a learning environment.  

It allows:
- Facilitators to manage courses, assignments, and assessments.
- Candidates to access course materials, submit assignments, and track progress.  

This project is **modular, user-friendly, and Windows-compatible**.

---

## 🛠 Features
- **Admin Module:** Manage courses, finances, dashboard overview, and login credentials.  
- **Facilitator Module:** Handle modules, practicals, summatives, formatives, and login functionality.  
- **Student Module:** Access portal, view grades, submit assignments, and take tests/exams.  
- **System Tools:** Connectivity, course tools, and system development support.  
- **Secure Login:** Role-based authentication for Admin, Facilitator, and Student.  
- **Resources:** Integrated images stored in `Resources/images/`.

---

## 🖥 Technology Stack
- **Language:** Visual Basic .NET  
- **Framework:** .NET 6.0 (Windows Forms)  
- **IDE:** Visual Studio 2022 or newer  
- **Database / Storage:** Local (via VB.NET connectivity)  
- **OS:** Windows 10 or newer

---

## ⚡ Getting Started

### 1. Clone the Repository
```powershell
git clone https://github.com/TTKhumalo/System-for-facilitator-and-candidates.git
cd Project

The terminal doesn’t recognize dotnet because the .NET SDK is not installed or it’s not added to your system PATH.

Since your project is a VB.NET Windows Forms app, you cannot run it in the terminal until the SDK/runtime is installed.

Here’s how to fix it step by step:

1️⃣ Install .NET 6 SDK (Windows)

Go to the official download page:
https://dotnet.microsoft.com/en-us/download/dotnet/6.0

Click “Download .NET 6 SDK” (not runtime, SDK is needed for building).

Run the installer and follow instructions.

This will allow you to use dotnet in your terminal.

2️⃣ Verify installation

After installation, restart your terminal (PowerShell) and run:

-  dotnet --version


You should see something like:

6.0.x


If yes ✅, the SDK is installed correctly.

Key things to notice:

The main solution file is here:

Login.sln


The main project file is here:

Login.vbproj


This is the project you want to build and run.

All the other .vb and .Designer.vb files are part of this project.

✅ Step-by-step commands to build and run this project in the terminal

Make sure you’re in the Project folder (you already are):

System-for-facilitator-and-candidates\Project>


Build the project:

- dotnet build Login.vbproj


You should see Build succeeded.

Run the project:

- dotnet run --project Login.vbproj


This will launch the Windows Forms GUI app.

You should see the login screen where you can choose Admin / Facilitator / Student.

⚡ Optional: Run the executable directly

After building, you can run the compiled .exe instead of dotnet run:

-  cd bin\Debug\net6.0-windows
-  .\Login.exe


This is useful if you don’t want to rebuild every time.

💡 Notes:

Windows Forms apps only run on Windows — can’t run on Mac/Linux.

VS Code is just an editor here; you’re actually using .NET CLI to build/run.

All your modules (Admin, Facilitator, Student) are part of Login.vbproj.
