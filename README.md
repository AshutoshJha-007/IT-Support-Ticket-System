# IT Support Ticket Management System

## 📌 Project Overview
An IT Support Ticket Management System built using **ASP.NET Core, C#, SQL Server, and Azure**. This system allows users to create, track, and resolve IT support requests efficiently.

## 🛠️ Technologies Used
- **Backend:** ASP.NET Core MVC, C#
- **Database:** SQL Server, Entity Framework
- **API:** RESTful API for ticket operations
- **Cloud:** Deployed on Azure for scalability

## 🎯 Features
- **Ticket Creation & Management**: Users can create, update, and close support tickets.
- **Role-Based Access**: Admins manage tickets while users submit requests.
- **REST API**: Exposes endpoints for integration with other systems.
- **Database Integration**: Uses SQL Server with Entity Framework.
- **Authentication & Authorization**: Secure user access.

## 📂 Project Structure
```
ITSupportSystem/
│── ITSupportSystem.sln       # Solution File
│── ITSupportSystem/
│   │── Controllers/
│   │   │── TicketController.cs
│   │── Models/
│   │   │── Ticket.cs
│   │── Data/
│   │   │── ApplicationDbContext.cs
│   │── appsettings.json
│   │── Program.cs
│   │── Startup.cs
```

## ⚙️ Setup Instructions
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/it-support-ticket.git
   ```
2. Navigate to the project directory:
   ```sh
   cd ITSupportSystem
   ```
3. Set up the database:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
4. Run the application:
   ```sh
   dotnet run
   ```

## 📡 API Endpoints
| Method | Endpoint         | Description         |
|--------|----------------|---------------------|
| GET    | /api/tickets   | Get all tickets    |
| POST   | /api/tickets   | Create a new ticket |
| PUT    | /api/tickets/{id} | Update ticket status |
| DELETE | /api/tickets/{id} | Delete a ticket |

## 🚀 Deployment
The system is deployed on **Azure App Services** for scalability and accessibility.

## 🔒 Authentication & Security
- Uses **JWT-based authentication**.
- Secure **role-based access control (RBAC)**.

## 📝 License
This project is open-source under the **MIT License**.

---
Let me know if you need modifications or additional features! 🚀
