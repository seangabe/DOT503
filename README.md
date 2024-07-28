## Welcome!
This DOT503 Assesment repository demonstrates the implementation of the first three stages of a DevOps CI/CD pipeline, within the DevOps ecosystem.

## Project Overview:
Application: Simple web-based calculator application  
Development Framework: ASP.NET Core C# .NET 8  
Version Control: Git and GitHub  
CI/CD Pipeline: CircleCI  
Deployment Target: Azure Web App Service (PAAS)  

## Development Workflow:
Development: The application was developed using Visual Studio 2022 IDE.  
Version Control: Git commands were used to commit changes to a local repository and push them to the master branch on GitHub. Other branches exist.  
Test Cases are present in the [DOT503TestProject Test File](https://github.com/seangabe/DOT503/blob/master/DOT503TestProject/UnitTest1.cs)   

## Other Branches 
[Feature-x](https://github.com/seangabe/DOT503/tree/feature-x)  
[Feature-y](https://github.com/seangabe/DOT503/tree/feature-y)  
[Feature-z](https://github.com/seangabe/DOT503/tree/feature-z)  
[Unit-Test](https://github.com/seangabe/DOT503/tree/unit-test)  

## Unit Test
Test Cases were designed using the MSTest Unit Testing framework and can be run from the Visual Studio IDE.
Currently 3 Test pass, while 2 Tests fail

## Passed Unit Tests:
Calculate_Addition_ReturnsCorrectResult()  
Calculate_Subtraction_ReturnsCorrectResult()  
Calculate_Multiplication_ReturnsCorrectResult()  

## Failed Unit Tests:
Calculate_Division_ReturnsCorrectResult()  
Calculate_Modulo_ReturnsCorrectResult()   
        
## Automated Build and Deploy: 
The .circleci folder in the project root contains a config.yml file. This file defines the scripts for the CircleCI pipeline, which automatically builds and deploys the application to Azure Web App Service upon every commit to the master branch.

Once the changes are committed or pushed to the master branch, CircleCI will automatically trigger the build and deploy pipeline according to the `config.yml` configuration.

The pipeline will build the application and deploy it to the Azure Web App service endpoint specified in the configuration and also in the configuration report.

## The deployment endpoint is: 
assessment503-hhhkachwbzgag8hs.eastus-01.azurewebsites.net   
Copy and paste endpoint link to a browser to view the calculator application.

## Getting Started:
Make changes to any of the files in the DOT503/Controllers or any other files within the master branch will automatically trigger the circleCI build and deploy process.

## CircleCI Pipeline Configuration

The CircleCI pipeline is configured to automate the build and deployment process. The configuration is defined in the [.circleci/config.yml](https://github.com/seangabe/DOT503/blob/master/.circleci/config.yml) file located in the root directory of the master branch.
The config.yml file defines the CircleCI pipeline stages. This file can be reviewed for a detailed understanding of the build and deployment process.

## Conclusion
This project demonstrates the implementation of a simple calculator application using the ASP.NET Core C# .NET 8 framework, along with a CI/CD pipeline using CircleCI and Azure Web Apps. By following the instructions provided in this `Readme.md` file, you can set up and deploy the application efficiently.

## Notice:
This project is for Torrens University DOT503 Assessment purposes only.  
Learning facilitator  
Kalaivany Natarajan


