Code Challenge
Challenge Title: Legacy Application Refactoring
Overview


As a Senior Full Stack Developer, you will be tasked with modernizing a legacy Classic ASP application. This challenge will assess your ability to analyze legacy code, identify security vulnerabilities, and implement a simple refactoring using modern technologies.

Task
- Analyze the provided legacy code snippet (simulated here as a simple Classic ASP code).
- Identify potential security vulnerabilities and suggest improvements.
- Refactor the code into a modern ASP.NET Core format (C#) with an emphasis on security best practices.



Legacy Code Snippet (Classic ASP)
<%
Response.Write("Welcome to the Employer Portal")
Dim username
username = Request("username")
' Potential SQL Injection vulnerability
sql = "SELECT * FROM Users WHERE username = '" & username & "'"
Set rs = conn.Execute(sql)
If Not rs.EOF Then
    Response.Write("Hello, " & rs("name"))
Else
    Response.Write("User not found.")
End If
%>



Requirements
- Identify at least two security vulnerabilities in the code.
- Refactor the code into a C# ASP.NET Core controller method.
- Use parameterized queries to prevent SQL injection.
- Ensure that the refactored code follows best practices for error handling and response formatting.

