# IFB Software Team Coding Guidelines and Standards

We follow best practices for each language and strive for consistancy
in our code base.  Below you will find sections that pertain to each
language that we currently use and other practices that we follow.

## Code

### C Sharp - .NET
 
 We follow Microsoft's coding guidelines and standards for our .NET
 code. We have references for thier documenation below. We do deviate from these in a few situations, but
 we follow 98% of these guidelines.  The biggest deviation is naming readonly variables with an underscore. We
 are very much a **SPACE** not tabs shop, so please don't use tabs.  Also please configure Visual Studio or your editor
 that if you use tabs that it inserts spaces, preferably 4.
 
- [Microsoft Coding Conventions](https://msdn.microsoft.com/en-us/library/ff926074.aspx)
- [Capitalization Conventions](https://msdn.microsoft.com/en-us/library/ms229043.aspx)
- [General Naming Conventions](https://msdn.microsoft.com/en-us/library/ms229045.aspx)
- [Names of Assemblies and DLLs](https://msdn.microsoft.com/en-us/library/ms229048.aspx)
- [Names of Namespaces](https://msdn.microsoft.com/en-us/library/ms229026.aspx)
- [Names of Classes, Structs, and Interfaces](https://msdn.microsoft.com/en-us/library/ms229040.aspx)
- [Names of Type Members](https://msdn.microsoft.com/en-us/library/ms229012.aspx)
- [Naming Parameters](https://msdn.microsoft.com/en-us/library/ms229004.aspx)
- [Naming Resources](https://msdn.microsoft.com/en-us/library/ms229037.aspx)

#### ReSharper

We have included a ReSharper file in this repostiory.  If you use ReSharper then it should help you follow 
our coding guidelines.

### JavaScript

There are plenty of different style guides available. We just focuse on consistency and that the tool you use either
uses a linter or follow ES standards.

### CSS

Sames applies to CSS.  Just be consistent and follow a standard.

### Other languages

Any other langauges used by this team, we strive to follow industry best practices and again we strive for consistency.      

## Version Control

This is a pretty straight forward topic to a point. 

- Commit early and commit often. 
- Only commit working code to develop branch.
- Any long lived features need to be on a feature branch.  
- Master is production code.
- Constanly push commits to our master repository in case of any hard drive failures.
- Write clear and concise commit messages.
- Don't check in commented out code.
- Do not check in compiled application files.
- Do not check in any compiled depedencies unless not available in the package manager.

### Repository Configuration

We have a preferred structure, but more of a general guideline. A README is required at the root of a repository
that explains the project, what it takes to configure a development environment and to actually build the applicaton.

We typically put all source code in a folder called src at the root of the project.

## Deployment

This depends on what type of project. If a .NET project, the following are the only acceptable methods.

- Desktop Application: Windows Store, Squirrel.Windows, or sparingly Microsoft ClickOnce with Web Deployment Strategy
- Web Application: Microsoft Web Deploy Package