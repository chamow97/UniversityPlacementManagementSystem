<h1> University Placement Management System </h1>

<h2> Introduction </h2>:
<p>
University Placement Management System is an application which stores student's information appearing for placement and an admin account to 
control the data.
</p>

<h2> Languages/Technologies used </h2>:
<p> 
- C#.NET
- mySQL
- Visual Studio 2015
</p>
<h2> Using this Application </h2>: 

<h4> Pre-requisites </h4>:
<p> 
- Visual Studio 2015 with C# installed. 
- mySQL with Visual Studio Connector.
</p>
<h2> Things to know before running </h2>:
<p> 
- I have used database name as "universityDatabase".
- It has 2 Tables Student and Admin
- Student Table fields : 
studentName | studentID | studentPassword | studentDepartment | studentQualification | pictureURL
- Admin Table fields :  
Admin_Password | Admin_ID

- mySQL server : **localhost**

<h5> NOTE : You can change these according to your needs at "databaseConnection.cs" file.
Also change the username and password in "databaseConnection.cs" to your MySQL username and password.
</h5>
<h2> Things to do before running </h2>:
<p>
- Create a Database.
- Create 2 Tables using CREATE SQL COMMAND
- Create an admin record using INSERT INTO SQL COMMAND
</p>
<h2>Screenshots</h2>
<br>
<h4>About</h4>
<br>
<img src="/Screenshots/About.PNG" />
<br>
<br>
<h4>Admin Interface</h4>
<br>
<img src="/Screenshots/AdminArena.PNG" />
<br>
<br>
<h4>Admin Portal</h4>
<br>
<img src="/Screenshots/AdminCorner.PNG" />
<br>
<br>
<h4>Start Page</h4>
<br>
<img src="/Screenshots/Start Page.PNG" />
<br>
<br>
<h4>Student Portal</h4>
<br>
<img src="/Screenshots/StudentCorner.PNG" />
<br>
<br>
<h4>Deletion</h4>
<br>
<img src="/Screenshots/deleteRecord.PNG" />
<br>
<br>
<h4>Edit Record</h4>
<br>
<img src="/Screenshots/editRecord.PNG" />
<br>
<br>
<h4>New Record</h4>
<br>
<img src="/Screenshots/newStudentRecord.PNG" />
<br>
<br>
<h4>Validation</h4>
<br>
<img src="/Screenshots/wrongInput.PNG" />
<br>

<h5>NOTE : If you want different name for Database or Table change the name of them in the form accordingly at appropriate places.</h5>

<h5>NOTE : This is my first C# project so might contain many absurd and unwanted portions, feel free to notify me.</h5>
