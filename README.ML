- this repo is created for labs from csdt cource
- details about task:
I'm making a demo project for a graduate work.
Leading professor is Galyna Klym.
Task is to make a digital synth.

Task 1. Initiate GIT repository (BEF)
Task 2. Create simple game (BEF)
Task 3. Create tests (BEF)
Task 4 (20 extra points). Create pipelines
Task 5. Create new version (FEF)
Task 6. Implement AI (FEF)
Task 7. Implement DB (FEF)

- student number - 12, student name - Nazar Koval

- task 2 update
! To build project u need a .NET Framework 4.7.2 that comes with vs studio 2019.
! This project is using a thing called Reflection. There're two others solutions that creates
.dll files that supposed to be in this path Synthesizer\Synthesizer\Extensions.
I've made folder that contains that dll (Builded dlls) so u can use them without building other solutions.
! Version number is 1.0.0.

- task 3 update
! I've created tests for each note.
It is just a test that checks if note calculation is valid. (wave calculation to be correct)

- task 7 update
! I've made an SQL db that has two tables with NOTEID ,NOTENAME and NOTEFREQUENCE
! Every two projects have hepler class and SQLConnector class that allows me pull data from DB.
! AFter everything done there's a method that assign data from DB to my class fields. 

-task 5 update
! I've created git tag for my project.
! New version description(what was added) :
!: pulling info(note frequency) from DB to app. 
!: playing notes with the pc keybord.
!: unit test for pojects that builds dll.
!: created GIT TAG is "synthesizer_v1.1.2_WW21515".