An e-learning website was developed using an Azure SQL database and .NET Core C# MVC by following these steps:

1. Project Setup:
- Created an ASP.NET Core Web Application project in Visual Studio.
- Selected the MVC template based on requirements.

2. Database Configuration:
- Set up an Azure SQL database and created a password to ensure secure connectivity.
- Defined the database schema, including tables for users (Students, Administrators), courses, and unverified users.
- Configured the connection string in the appsettings.json file to connect the application to the SQL database.

3. User Authentication and Authorization:
- Implemented user authentication and authorization using ASP.NET packages.
- Utilized password hashing to protect sensitive information from cybercriminals.
- Defined user roles and permissions to manage access levels for different features of the e-learning platform.

4. Cookie Management:
- Login Cookies: Created cookies upon user login to maintain sessions and ensure a seamless user experience.
- Website Cookies: Used cookies to enhance website functionality and track user preferences.
  
5. Learning Experience:
- Designed user interfaces that allow learners to browse and search for courses to enroll in.
  
6. Account Management:
- Developed account management features, including starting courses, enabling two-factor authentication (2FA), and implementing email verification.
  
7. Administrative Functions:
- Created administrative panels to manage users, courses, content, and other aspects of the platform.
  
8. Course Search Feature:
- Developed a search functionality to help users easily find courses using keywords.
- Ensured the search feature provided quick and relevant results to enhance the user experience.
  
9. Testing and Deployment:
- Conducted thorough testing to ensure functionality, security, and performance.
- Deployed the e-learning website to Microsoft Azure service.
