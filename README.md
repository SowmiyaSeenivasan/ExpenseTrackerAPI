# Expense Tracker API

This project is a simple Expense Tracker API built using ASP.NET Web API.

## Features

- Add new expense
- View all expenses
- Filter expenses by category
- Calculate total and average expense
- Supports JSON input and output

## Technologies Used

- ASP.NET Web API
- C#
- SQL Server
- Entity Framework

 ## Project Structure
 
ExpenseTrackerAPI/
├── ExpenseTrackerAPI.sln
├── ExpenseTrackerAPI/
│   ├── App_Start/
│   │   └── WebApiConfig.cs
│   ├── Controllers/
│   │   └── ExpenseController.cs
│   ├── Models/
│   │   ├── Expense.cs
│   │   └── ExpenseDbContext.cs
│   ├── Properties/
│   │   └── AssemblyInfo.cs
│   ├── Web.config
│   ├── Global.asax
│   └── packages.config
├── .gitignore
├── README.md
└── .vs/   (auto-generated — ignore in git)


## How to Run

1. Open project in Visual Studio
2. Restore NuGet packages
3. Run the project (IIS Express)
4. Test API using Postman or browser

## API Endpoints

- GET    /api/expense
- GET    /api/expense/{id}
- POST   /api/expense
- PUT    /api/expense/{id}
- DELETE /api/expense/{id}

## Sample JSON for POST

[
  {
    "Description": "Tea",
    "Amount": 20,
    "Category": "Food",
    "Date": "2025-12-30"
  }
]



