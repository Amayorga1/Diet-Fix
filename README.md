# This a Diet Program called : DietFix

### Table of Contents
1. [Concept](#Concept)
2. [User Stories](#User-Stories)
3. [Use Cases](#Use-Cases)
4. [Use Case Diagram](#Use-Case-Digram)
5. [UI Draft](#UI-Draft)
6. [Requirements](#Requirements)
7. [Test Table](#Test-Table)
8. [Prototype BMI](#Prototype-BMI)



## Concept
This diet appliction allows users to choose their own diet plan to include the cost to make it an affordable ideal diet. 
While monitoring their Diet and making it easy for the user to create a diet plan.

## User Stories 
User Stories (1)
User's Voice
As a Diet app user (role)
I need/want a BMI calculater (feature)
So that I can see my BMI and work towards a healthier BMI if needed (objective)


User Stories (2)
User's Voice
As a Diet app user (role)
I need/want Diet plans, with meal plans and descriptions (feature)
So that I can be properly informed of the diet plans and know how to make them (objective)

User Stories (3)
User's Voice
As a Diet app user (role)
I need/want Budget option for meal preps (feature)
So that I can still have a healthy diet without spending an absurd amount of money (objective)

### Use Cases
Scenario (1):
Given The user is on the login page
(and user inputs correct password and username)
When the user clicks on login button
Then user is directed into their account

Scenario (2)
Given The user selects a diet plan
(and user reads short description)
When the user clicks on the certain diet plan
Then user is directed to an informational guide 
for their diet plan 


Scenario (3)
Given The user is on the BMI portion of the page
(and user inputs incorrect height and weight such as centimeters and kilos instead of inches or pounds)
When the user clicks on the OK button
Then user is presented with an error page asking user to input information in pounds and inches

Scenario (4)
Given the user is on the macro chart page
(and user inputs current macros on the diagram)
When the user clicks on ENTER buttom
Then user is shown a diagram with his current Macros and three 
other diagrams for the reccomended diet plans' macros

Scenario (5)
Given the user is on the meal prep page 
(and user selects the budget option )
When the user clicks on Budget option buttom
Then user is directed to the budget meal plans and
ingredints for their selected diet plan


Scenario (6)
Given The user is on the account page
(and user wants to log out)
When the user clicks on log out button
Then user is re-directed into the login page 

## Use Case Diagram
![Use Case Diagram](https://github.com/Amayorga1/DietFix/blob/master/Use%20Case%20Diagram.PNG?raw=true)

## UI Draft
![UI-Draft](https://github.com/Amayorga1/DietFix/blob/master/DietFixWireframeDraft-page-001.jpg?raw=true)

## Database Diagram
![DatabaseDiagram](https://github.com/Amayorga1/Diet-Fix/blob/master/Info/Database%20Diagram.PNG?raw=true)

## Requirements Table
Req. ID | Description | Test Method | Test ID
--------|-------------|-------------|----------
1.1 | When user downloads app and creates username and password, system shall contain information on database| Test | T01.1
1.2 | When user logs in system shall verify credentials | Test | T01.2
1.3 | When user logs in, The system shall direct user to user account page | Usability Test |T01.3
1.4 | When user inputs incorrect information, system shall deny access | Security Test | T02.1
2.1 | When user inputs BMI information, the system shall calculate BMI then show user | Usability Test | T02.2
2.2 | When user inputs their current cost for food, the system shall calulate the savings per each diet plan| Test | T03.1
2.3 | When user selects certain diet plan, the system shall direct user to informational guide for that certain diet plan | Test | T03.2
2.4 | When user selects meal plans, the system shall direct user to meal plan for selected diet plan| Test| T08
2.5 | If user decides to change diet plan, system shall redirect to new meal plan| Test | T09


  ## Test Table

Test ID | Req. ID | Test Procedure | Current Status | TimeStamp | build/version
------------ | ------------ | ------------- | ------------- | ------------- | --------------
T01 | 1.1<br/>1.2<br/>1.3 |The program will Contain the user information and allow access for entry to account page | Passed | 01/Nov/2020 | 1.1
T02 | 1.4<br/>3.0 | Application verifies log in information and will restrict usage of app until an account is made | Passed | 01/Nov/2020 | 1.1
T03 | 2.1<br/>2.2 | The program will allow user to change user information | Passed | 01/Nov/2020 | 1.1
T04 | 2.2<br/>2.3 |Application will display and allow access to each diet type and calculate the savings per diet type.| Passed | 01/Nov/2020  | 1.1
T05 | 2.4 | Application displays information for selected diet type | Passed | 01/Nov/2020| 1.1
T06 | 2.5 | Application will change the diet plan to a new diet plan | Passed | 01/Nov/2020 | 1.1



 ## Requirements Traceability Matrix
 
 Req No | Req Desc | Testcase ID | Status 
------------ | ------------ | ------------- | ------------- |
1.1 | When user downloads app and creates username and password, system shall contain information on database| T01.1 | Pass
1.2 | When user logs in system shall verify credentials | T01.2 | Pass
1.3 | When user logs in, The system shall direct user to user account page | T01.3 | Pass
1.4 | When user inputs incorrect information, system shall deny access | T02.1 | Pass
2.1 | When user inputs BMI information, the system shall calculate BMI then show user output | T02.2 | Pass
2.2 | When user inputs their current cost for food, the system shall calulate the savings per each diet plan| T03.1 | Pass
2.3 | When user selects certain diet plan, the system shall direct user to informational guide for that certain diet plan | T03.2 | Pass 
2.4 | When user selects meal plans, the system shall direct user to meal plan for selected diet plan| T08 | Pass
2.5 | If user decides to change diet plan, system shall redirect to new meal plan| T09 | Pass

[(Back To Top)](#table-of-contents)

## Prototype BMI
![Prototype 1.1](https://github.com/Amayorga1/DietFix/blob/master/Project%209.1.PNG?raw=true)

![Protyotype 1.2](https://github.com/Amayorga1/DietFix/blob/master/Project%209.2.PNG?raw=true)


[(Back To Top)](#table-of-contents)

