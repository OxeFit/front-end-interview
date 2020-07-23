# Welcome 
This repository contains the resources needed to complete programming exercises that demonstrate skills in various technical disciplines.  This is an offline exercise intended to be completed within a few hours over the course of a few days.  

## Instructions
The goal of this exercise is to produce a basic JavaScript application that matches the style and behavior of a design provided by a UI designer.  Screen shots and a video demonstration of the mocked up UI have been provided for reference, along with fonts, images, and other assets required to complete the UI implementation.

To perform this exercise:

 1. **Clone this repository**. This can either be a fork on your personal GitHub account or a local working copy.
 2. **Implement a basic application**.  Spend a few hours implementing as much of the application as you can, using your judgement to prioritize the most important aspects.
 3. **Commit changes**.  Commit changes at appropriate intervals with explanatory comments.
 4. **Submit the completed application**.  When complete, reply to the E-mail you received with either a link to a public repository hosting your solution or some other means of accessing the completed code.     

The completed exercise will be discussed during a follow up technical interview.

### Acceptance Criteria
A successful implementation will:

 * Use a JavaScript UI framework such as Angular, React, or Vue
 * Demonstrate effective use of component composition and state management
 * Reproduce the visuals in the mock-ups and demo as closely as possible
 * Perform the demonstrated navigations and transitions with the requested animations and effects
 
### Additional Considerations
In addition to the core acceptance criteria, the following details demonstrate the additional skills needed to produce a complete solution.

 * Population of UI state using calls to the provided API
 * Unit or integration tests using test automation frameworks such as Jasmine, Jest, or Cypress
 * Mobile-first or mobile-friendly implementations using responsive design or hybrid mobile application development frameworks such as Ionic or React Native 

## Getting Started

### UI Design and Assets
Design artifacts provided by the UI designer can be found in the `design` directory in the root of the repository.  A video walk through named `demo.mp4` is provided to demonstrate how the application is intended to behave. 

#### Screen Shots
The `design/screenshots` directory features screen shots that capture the visual design of the app in various states:

|Filename|Description|
|--------|-----------|
|`launch.png`|A blank screen displayed as soon as the app is launched|
|`splash.png`|A splash page displayed while the login screen is loading|
|`login.png`|The login screen|
|`home.png`|The home screen displayed after successful login|
|`strike`|A page showing the different types of strikes to select from|
|`menu.png`|The application menu screen| 

#### Images
The `design/images` directory contains the application logo image `logo.png`.

#### Fonts
The Google Roboto font has been provided in the `design/fonts` directory for convenience.

## Running the API
The included API can be run either as a Docker container or directly on the host.

#### Docker
To run the API as a Docker container, Docker must be installed.  From the root of the repository, run the following command:

```shell script
docker-compose up
```

#### .NET Core
The API can also be compiled and executed directly using the .NET Core 3.1 SDK with the following commands:

```shell script
cd api/PounceFitness.Api
dotnet run
```

### API URLs
Whether the API is run within a Docker container or directly on the host, the following URL should be bound:

 * `http://localhost:5000`
 
#### Swagger Schema
The Swagger schema for the API can be accessed at the following URLs:

 * `http://localhost:5000/swagger/v1/swagger.json`
