# Student-gradebook

## Overview

Student-Gradebook is a Windows Forms application designed to manage core elements of a school catalog system. It provides a clean, role-based login experience for both students and professors, each with access to tools tailored to their responsibilities.
Students can view their academic information, while professors can manage grades, absences, and student records through an intuitive interface.

This project was developed using C#, Windows Forms, and a SQL Server local database, following a clear separation between UI and data logic.
## Features Implemented
**Role-Based Login**
- Secure login using credential validation
- Automatically detects if the user is a student or a professor
- Redirects each role to its dedicated dashboard

**Student Dashboard**
- Displays personal student information
- Shows absences and grades in an organized table
- Lists subjects associated with the student’s class
- Organizes academic details in an intuitive layout

**Professor Dashboard**
- Search for students by name
- View grades, absences, subjects, and class information
- Add new grades or new absences
- Update and delete existing grades or absences
    - These operations require selecting the desired entry from the table before editing or deleting.
- Manage student academic records in a structured, tab-based interface

## Technical Details
**Frontend**
- Created using Visual Studio Windows Forms
- Uses DataGridView controls for displaying tables

**Backend**

- Written entirely in C#
- Uses event-driven logic for:
  - Login verification
  - Role switching
  - Student search
  - Grade and absence handling
  - Data formatting and display
- Backend interacts with the database using typed adapters and program logic

## Screenshots
<img width="986" height="515" alt="image" src="https://github.com/user-attachments/assets/18674721-0426-402b-8ade-e6fad1f58eb4" />
<img width="1219" height="609" alt="image" src="https://github.com/user-attachments/assets/1e85ec16-a28c-4ee0-ac83-20fb85f92a8d" />
<img width="1204" height="609" alt="image" src="https://github.com/user-attachments/assets/1d12f9b6-1435-4cff-aea0-e4977b75df80" />
<img width="1210" height="608" alt="image" src="https://github.com/user-attachments/assets/094cc641-38bb-4e90-85db-18d1e14737b0" />
<img width="1158" height="560" alt="image" src="https://github.com/user-attachments/assets/b28f6ff1-26fd-4c19-9bca-f564aa9f44e2" />
<img width="1160" height="558" alt="image" src="https://github.com/user-attachments/assets/511aa821-1578-48c2-946f-2630cf2ce323" />
<img width="1156" height="556" alt="image" src="https://github.com/user-attachments/assets/b5435897-1be0-4e1a-a289-a25b6bff5821" />
<img width="1146" height="559" alt="image" src="https://github.com/user-attachments/assets/dd7cdce1-b708-4013-8d5b-3fc402b56f9c" />
<img width="1155" height="554" alt="image" src="https://github.com/user-attachments/assets/faa5da9e-3dca-479d-b769-50bc8ec0334a" />








