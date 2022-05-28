# JuraAPI

This is run on the ASP.NET and uses the entityframework and SQLite to create the database. 

If you want to run this on your own device you will need to use the EF tools to create a new migration and update database I believe although I am not sure. 

If database doesnt work I also added with the controller an option to just use a list - it works the exact same as the database. 

If you find that the database is empty you can use this query string to fill it: 

INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (1, "Get Out of bed", "7:30 sharp", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (2, "Shower", "With new shampoo", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (3, "Brush Teeth", "30 seconds each side", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (4, "Hair routine", "HairBrush + tie", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (5, "Get Changed", "Drippiest clothes", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (6, "Make sandwich for lunch", "Ham and cheese", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (7, "grab your keys", "This will take longer than expected", "20/05/2022");
INSERT INTO Notes (Id, Title, Description, DueDate)
VALUES (8, "go back to bed", "Just not feeling it today", "20/05/2022");


The api URL should be:

https://localhost:7202/api/

Example search all tasks: 
https://localhost:7202/api/tasks/

Example Search specific task by ID:
https://localhost:7202/api/tasks/1

Example Search for strings within the titles:
https://localhost:7202/api/tasks/search/keys
