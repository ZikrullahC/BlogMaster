# BlogMaster

## Overview
A comprehensive blogging platform built using ASP.NET MVC, offering users the ability to create, edit, and manage blog posts. This application supports rich text formatting, image uploading, and user authentication.

## Features
- **Blog Management**
  - Create, read, update, and delete blog posts
  - Rich text formatting support
  - Post categorization and tagging
  
- **User Authentication**
  - Secure login and registration system
  - Role-based access control
  - User profile management
  
- **Responsive Design**
  - Mobile-first approach
  - Optimized for all screen sizes
  - Consistent user experience across devices
  
- **Image Uploads**
  - Integrated image handling for blog posts
  - Support for multiple image formats
  - Secure storage and retrieval

## Technologies Used
- **Backend**
  - ASP.NET MVC
  - Entity Framework
  - SQL Server
  
- **Frontend**
  - HTML5
  - CSS3
  - JavaScript
  
## Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET SDK (version required)
- SQL Server (latest stable version recommended)

### Installation

1. Clone the repository
```bash
git clone https://github.com/ZikrullahC/BlogMaster.git
```

2. Navigate to the project directory
```bash
cd BlogMaster
```

3. Open the solution in Visual Studio

4. Update the database connection string in `appsettings.json`
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your_Connection_String_Here"
  }
}
```

5. Run the database migrations
```bash
Update-Database
```

6. Start the application using IIS Express

## Usage

### Admin Access
- Full access to all system features
- Manage user accounts and permissions
- Monitor and moderate blog content
- Access to analytics and reports

### Authenticated User Access
- Create new blog posts
- Edit and delete own posts
- Manage personal profile
- Interact with other users' content

## Contributing

We welcome contributions to the BlogMaster project! Here's how you can help:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
