# CustomerFeedbackPortal

## Table of Content
- [Introduction](#introduction)
- [Key Features](#Key-Features)
- [Technologies Used](#Technologies-Used)
- [Database Schema](#Database-Schema)
- [Project Setup Steps](#Project-Setup-Steps)
- [How-to-Use](#How-to-Use)
- [Conclusion](#Conclusion)
  
## Introduction:

The CustomerFeedbackPortal is a lightweight web application built to collect customer feedback and allow admins to manage it efficiently.

Objective: Enable customers to submit opinions, suggestions, or complaints, and provide admins with tools to view, edit, and delete feedback entries.

## Key Features:

- Submit Feedback: Customers can submit feedback with Name, Email, Rating (1-5), and Comments.

- View Feedback List: Admins can view all feedback entries in a tabular format.

- View Feedback Details: Admins can view details of a single feedback entry.

- Edit/Delete Feedback: Admin-only actions to edit or delete feedback entries (protected by role-based authorization).

## Technologies Used:

- ASP.NET Core MVC

- Entity Framework Core (EF Core)

- SQL Server

- Razor Views + Bootstrap

- Azure App Service (for deployment)

- Git (for version control)

## Database Schema:

**Feedback Table:**

Id: int (Primary Key)

Name: string

Email: string

Rating: int (1-5)

Message: string

SubmittedOn: DateTime

**Identity Tables:**

Managed by ASP.NET Core Identity (e.g., AspNetUsers, AspNetRoles).

## Project Setup Steps:

1. Create ASP.NET Core MVC Project:
  Selected "Individual Accounts" for authentication to enable ASP.NET Core Identity.

2. Set Up Database Contexts:
  Added ApplicationDbContext for Identity and CustomerFeedbackPortalContext for feedback data.
  Configured both to use SQL Server in Program.cs.

3. Define Feedback Model:
  Created Feedback.cs with fields: Id, Name, Email, Rating, Message, SubmittedOn.

4. Run Migrations:
  Generated and applied migrations for CustomerFeedbackPortalContext to create the Feedback table.

5. Create Feedback Controller and Views:
  Added FeedbackController.cs with actions: Index, Create, Edit, Details, Delete.
  Generated Razor views for each action using Bootstrap.

6. Set Up Roles and Admin User:
  Added code in Program.cs to create "Admin" and "User" roles.
  Assigned "Admin" role to user with email admin@example.com.

7. Protect Admin Actions:
  Applied [Authorize(Roles = "Admin")] to Edit and Delete actions in FeedbackController.

8. Customize Login Page:
  Scaffolded the Login page using ApplicationDbContext.

## How-to-Use:

**Access the Application**

- Open the application URL.

- The Customer Feedback homepage appears, featuring Register/Login buttons, and Submit Feedback options.

**Register as a User**

- Navigate to the "Register" page (/Identity/Account/Register).

- Create a user account with an email (e.g., ben@gmail.com) and password.

**Log In**

- Go to the "Login" page (/Identity/Account/Login).

- Log in using your registered email and password.

**Submit Feedback**

- Navigate to the "Submit Feedback" page (/Feedback/Create).

- Fill in the form:

  Name: Enter your name.

  Email: Enter your email address.

  Rating: Select a rating from 1 to 5.

  Message: Write your feedback or comments.

- Click "Create" to submit the feedback.

- You’ll be redirected to the feedback list page.

**Access Restriction for User**

- Users are only allowed to submit feedback.

- They are restricted from viewing the list of all feedback entries, viewing individual feedback, editing feedback, and deleting feedback.

**Admin Log In**

- The admin can create a user account using an email (e.g., admin@example.com) and a password, and then log in with those credentials.

**Viewing Feedback (Admin)**

- Navigate to the "Feedback List" page (/Feedback).

- View all feedback entries in a table with columns: Name, Email, Rating, Submitted On, and Actions (Details, Edit, Delete).

- Click "Details" to view a specific feedback entry (/Feedback/Details/{id}).

**View a Single Feedback (Admin)**

- The admin can view the details of a single feedback entry by entering the Feedback ID.

- The admin can also enter the Feedback ID to edit or delete a specific feedback entry.

**Admin Actions (Edit/Delete)**

- Edit Feedback:

  On the feedback list page, click "Edit" next to a feedback entry (/Feedback/Edit/{id}).

  Update the fields and click "Save".

- Delete Feedback:

  On the feedback list page, click "Delete" next to a feedback entry (/Feedback/Delete/{id}).

  Confirm the deletion on the next page.

## Conclusion

The CustomerFeedbackPortal provides a simple and secure way for customers to submit feedback and for admins to manage it.

Key features include role-based authorization, a clean UI with Bootstrap, and deployment-ready code

Future enhancements could include advanced feedback filtering and options to view the top or most recent feedback entries.











