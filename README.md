### MyMvcApp-Contact-Database-Application Documentation

#### Overview
MyMvcApp is an ASP.NET Core MVC application designed to manage a contact database. It allows users to perform CRUD (Create, Read, Update, Delete) operations on user data.

#### Project Structure
```
.vscode/
    launch.json
    tasks.json
MyMvcApp-Contact-Database-Application/
    appsettings.Development.json
    appsettings.json
    bin/
        Debug/
        Release/
    Controllers/
        UserController.cs
    deploy.json
    deploy.parameters.json
    Models/
        ErrorViewModel.cs
        User.cs
    MyMvcApp.csproj
    MyMvcApp.sln
    obj/
        Debug/
        Release/
    Program.cs
    Properties/
    README.md
    scriptcs_bin/
    Views/
    wwwroot/
MyMvcApp.Tests/
    bin/
    MyMvcApp.Tests.csproj
    obj/
    UserControllerTests.cs
```

#### Configuration Files
- **appsettings.json**: Contains configuration settings for the application.
- **appsettings.Development.json**: Contains development-specific configuration settings.
- **deploy.json**: Deployment configuration file.
- **deploy.parameters.json**: Deployment parameters file.

#### Controllers
- **UserController.cs**: Manages user-related actions such as viewing, creating, editing, and deleting users.

#### Models
- **ErrorViewModel.cs**: Represents error information.
- **User.cs**: Represents a user in the application.

#### Views
Contains Razor views for rendering HTML pages.

#### wwwroot
Contains static files such as CSS, JavaScript, and images.

#### Program.cs
The entry point of the application.

#### Properties
Contains project properties.

#### Tests
- **UserControllerTests.cs**: Contains unit tests for User Controller

### UserController

#### Methods
- **Index**: Displays a list of users.
- **Details**: Displays details of a specific user.
- **Create (GET)**: Displays the form to create a new user.
- **Create (POST)**: Handles the form submission to create a new user.
- **Edit (GET)**: Displays the form to edit an existing user.
- **Edit (POST)**: Handles the form submission to update an existing user.
- **Delete (GET)**: Displays the confirmation page to delete a user.
- **Delete (POST)**: Handles the deletion of a user.

### Deployment
The application can be deployed using the [`deploy.json`] and [`deploy.parameters.json`] files. These files contain the necessary configuration and parameters for deploying the application to Azure.

### Running Tests
To run the tests, use the following command:
```sh
dotnet test MyMvcApp.Tests/MyMvcApp.Tests.csproj
```

### Example Usage
1. **View Users**: Navigate to `/User` to view the list of users.
2. **View User Details**: Navigate to `/User/Details/{id}` to view details of a specific user.
3. **Create User**: Navigate to `/User/Create` to create a new user.
4. **Edit User**: Navigate to `/User/Edit/{id}` to edit an existing user.
5. **Delete User**: Navigate to `/User/Delete/{id}` to delete a user.


### Conclusion
MyMvcApp is a simple yet powerful contact management application built with ASP.NET Core MVC. It provides all the necessary functionalities to manage user data efficiently.