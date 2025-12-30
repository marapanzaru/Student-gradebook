# Student-gradebook

## Overview

Student-Gradebook is a Windows Forms application designed to manage core elements of a school catalog system. It provides a clean, role-based login experience for both students and professors, each with access to tools tailored to their responsibilities.
Students can view their academic information, while professors can manage grades, absences, and student records through an intuitive interface.
Implemented in C#, Windows Forms, and a local SQL Server database, emphasizing a clear separation between UI and data logic.

Developed as part of the professional competency certification completed before high school graduation.

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
<img width="985" height="522" alt="image" src="https://github.com/user-attachments/assets/25582c74-e442-4958-892d-e636ad093519" />
<img width="1213" height="611" alt="image" src="https://github.com/user-attachments/assets/a72705d7-73e6-42a0-85d1-64c1c2fc9fe3" />
<img width="1209" height="607" alt="image" src="https://github.com/user-attachments/assets/e38d77fe-2778-4204-80f8-dbac0b58b53a" />
<img width="1207" height="608" alt="image" src="https://github.com/user-attachments/assets/eb1011ca-9333-4046-9e6b-26a160fa26b2" />


<img width="1157" height="553" alt="image" src="https://github.com/user-attachments/assets/73e66bee-aa8c-4571-a79b-4e9813ffa586" />
<img width="1161" height="562" alt="image" src="https://github.com/user-attachments/assets/3ceb0ed5-5381-4124-b4be-d917a6fd32fb" />

<img width="1153" height="558" alt="image" src="https://github.com/user-attachments/assets/c710fe0f-1cf3-4fcc-9f69-a527e7c21aa3" />
<img width="1145" height="553" alt="image" src="https://github.com/user-attachments/assets/5a9703d9-75bb-4cda-93ee-0cf866134687" />
<img width="1149" height="556" alt="image" src="https://github.com/user-attachments/assets/81e9dca3-8b2f-47fb-931c-e3eb2dab5beb" />










