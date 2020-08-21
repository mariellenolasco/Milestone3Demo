# Milestone 3
Milestone 3 base code for the corporate batch

## Overview
The Lodging API is almost complete! With the models and data access projects fully implemented, and the controllers set up, it's almost done. The controllers just need the required logic implemented to be able to return the proper responses to client requests.

### Goal
Your goal as a developer is to provide the missing controller method implementations such that they:
    <ol>
        <li> Comply with the behavior and design described in the solution design document </li>
        <li> Pass all the unit tests </li>
        <li> Pass all the integration tests </li>
    </ol>

### Hint
The ```GetAsync()``` method of the ```LodgingController``` is fully implemented to show you how to use the components to get the required response. 

## Checking your work
To test if your implementations work as intended run the command ``` dotnet test ``` while in the Milestone3 directory

## Running the Demo
To launch the API, go to the Milestone3 directory, run the command ```dotnet run --project Lodging.WebAPI --urls http://localhost:5001```
<br>
You can also go to https://reqbin.com/ to test making calls to your web API.
<br>
Enter in the url the api is being hosted in, for example https://5001-ebbdf2ff-f62c-4389-a495-33a7f7f56565.ws-us02.gitpod.io/api/lodging
