# Hexx
Project written as BEng Thesis in years 2017-2019. This is my adaptation of Hexxagon game developed by Argo Games in 1993. Main diffrence is the ability to handle network game (without local multiplayer and AI game options).
Main objectives of the project is:
- to create adapter to SDL2 graphics library working fine in .NET environment, which can handle this project (design patterns: fasade, adapter)
- allowing hosts to communicate with each other via a central server
- to create a multi-threaded server application with saving the state in the database (MS SQL)
- to secure data transmission (in this project with tokens re-generated with every request)
- to use a lot of design patterns but wisely

Conclusions:
- If I were writing this project now, I would use REST API instead of my own TCP sockets based solution
- The SDL2 library used in project has a small memory leak in screen refreshing methods :)

After defending of BEng thesis:
Project is no longer developed. Interesting fact is server part of this project was used commercially after changes as print server (PDF generator).
