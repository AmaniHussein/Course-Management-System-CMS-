An e-learning website using Azure SQL database with .NET Core C# MVC, created by following these steps:
1.	Project Setup:
−	Created an ASP.NET Core Web Application project in Visual Studio.
−	Chose MVC template based on requirements.
2.	Database Configuration:
−	Set up Azure SQL database and creating the password for the connectivity and security.
−	Define database schema, including tables for users (Students, Administrators), courses,and unverified users.
−	Configure the connection string in the appsettings.json file to connect application to the SQL database.
3.	User Authentication and Authorization:
−	Implement user authentication and authorization using ASP.NET packages.
−	Password hashing to avoid and prevent cybercriminals from stealing information.
−	Define user roles and permissions to manage access levels for different features of the e-learning platform.
4. Cookie Management:
− Login Cookies: Cookies are created
once a user logs in to maintain the
session and ensure a seamless user
experience.
− Website Cookies: The website itself
uses cookies to enhance
functionality and track user
preferences.
5.	Learning Experience:
−	Design user interfaces for learners to browse and search for courses to enrol.
6.	Account Management:
−	Develop user account management features such as getting started at a course, two-factor authentication (2FA) and email verification, etc.
7.	Administrative Functions:
−	Create administrative panels for managing users, courses, content, and other aspects of the platform.
8. Course Search Feature:
− Develop a search functionality
allowing users to easily find courses
by keywords.
− Ensure the search feature provides
quick and relevant results to
enhance user experience.
9.	Testing and Deployment:
−	Test the application thoroughly to ensure functionality, security, and performance.
−	Deploy the e-learning website to a hosting environment using Microsoft Azure service to implement penetration testing.
