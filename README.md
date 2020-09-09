# Code_Sharpener
(Individual Project) Website to explain Algorithms and Data Structure concepts and code walkthroughs in C#.
* Anticipated Completion Date: October 31, 2020
  
## <div align="center">Table of Contents</div>
  
1) [Concept Description](#concept-description)
2) [Wire-Frames (DRAFT)](#wire-frames)
3) [Database Diagram](#database-diagram)
4) [User Stories](#user-stories)
5) [Use Cases](#use-cases)
6) [Use Case Diagram](#use-case-diagram)
7) [Requirements](#requirements)
8) [Requirements Table](#requirements-table)
9) [Test Case Table](#test-case-table)
10) [Intitial Prototype](#Initial-Prototype)
  
## <div align="center">Concept Description</div>
[(back to top)](#table-of-contents)
  
* After researching throughout the internet, I found a lack of information on Algorithms and Data Structures solved in C#.
* For a person that chooses to learn C# as their first programming language, it would be more difficult to understand Algorithms and Data Structures in another language.
* I have decided to create a website that will explain concepts and walkthrough code utilizing the C# programming language.
* There will be two videos and multiple challenges for each chapter. 
* Each chapter will focus on a key concept.
* At the bottom of every chapter, there will be an embeded code editor with challenges and test cases so users can practice the chapter's key concept.
  
## <div align="center">Wire-Frames</div>
[(back to top)](#table-of-contents)
  
**THESE ARE INITIAL DRAFTS**
  
![WireFrames](https://github.com/richminlee/Code_Sharpener/blob/master/WireFrames_Code_Sharpener.JPG)
  
## <div align="center">Database Diagram</div>
[(back to top)](#table-of-contents)
  
**Initial database diagram draft**
  
![Database Diagram](https://github.com/richminlee/Code_Sharpener/blob/master/ERD_Diagram_Code_Sharpener.JPG)
  
## <div align="center">User Stories</div>
[(back to top)](#table-of-contents)
  
**1.** As a MSSA Student, I need to learn Algorithms and Data Structures in C#. So that I can do well in the Whiteboarding portion of the Technical Interview

**2.** As a School teaching C#, I need a resource for my students for whiteboard practice. So that more students are competent and confidant during whiteboarding challenges.

**3.** As a Company utilizing C#, I need a way to screen candidates. So that I can spend less time screening and more time interviewing the right candidates.

**4.** As an administrator, I need a simple way to add more and change content. So that information can be updated or added as technologies change or better ideas are available.
  
## <div align="center">Use Cases</div>
[(back to top)](#table-of-contents)
  
Scenario #1: <Student/ Employee> accesses website content.  
Given: < Student/ Employee > is a subscriber.  
When: < Student/ Employee > Logs in.  
Then: Content is viewable to the < Student/ Employee > based on where they left off.  
  
Scenario #2: <Student/ Employee> wants to check content before subscribing.  
Given: <Student/ Employee> is not a subscriber.  
	And: <Student/ Employee> wants to learn Algorithms and Data Structures in C#.  
When: <Student/ Employee> enters website.  
Then: A preview of the course is available to the <Student/ Employee>.  
  
Scenario #3: <Student/ Employee> wants to send their progress to a <School/ Company>.  
Given: <Student/ Employee> is subscriber.  
	And: <Student/ Employee> has completed at least one subject.  
When: <Student/ Employee> requests a progress report be sent to their <School/ Company>.  
Then: <School/ Company> will receive an email with the completed code challenges, student’s submitted code and percent of course complete.  
  
Scenario #4: <School/ Company> wants to check content before recommendation.  
Given: < School/ Company > is not a subscriber.  
	And: < School/ Company > wants to recommend website to students.  
When: < School/ Company > enters website.  
Then: A preview of the course is available to the < School/ Company >.  
  
Scenario #5: Instructor wants to add content.  
Given: Instructor has admin username and password.  
When: Instructor logs in.  
Then: Instructor will be taken to an “Add Content” page where they can add videos, code challenges and test cases.  
  
Scenario #6: <Student/ Employee> is stuck on a coding challenge and needs help.  
Given: <Student/ Employee> is a subscriber.  
	And: <Student/ Employee> wants help with a coding challenge or concept.  
When: <Student/ Employee> explains their issue in the message board.  
Then: Instructor and other <Student/Employee>s are able to comment to explain.  
  
Scenario #7: < Student/ Employee > find a bug in the website or incorrect test case.  
Given: < Student/ Employee > found a bug.  
When: <Student/ Employee> selects the bug icon.  
Then: A form will pop up to describe the bug and will be emailed to instructor when submitted.  
  
Scenario #8: < Student/ Employee > Finds the content useful.  
Given: < Student/ Employee > wants to register.  
When: <Student/ Employee> selects the register link.  
Then: The <Student/ Employee> will be directed to the registration page.  
  
## <div align="center">Use Case Diagram</div>
[(back to top)](#table-of-contents)

![Use Case Diagram](https://github.com/richminlee/Code_Sharpener/blob/master/Code%20Sharpener%20Use%20Case%20Diagram.jpeg)


## <div align="center">Requirements</div>
[(back to top)](#table-of-contents)

* 1. Create User: System shall allow users to be created
	*1.1. User Form: System shall allow users to input their personal information
	*1.2 Password Encryption: System shall encrypt password that has been input
	*1.3 Form Validations: System shall check to see if input data is correct type and length
*2. Authenticate User: System shall ensure the user is created
*3. Login User: System shall login users with email and password
	*3.1 Check Subscription: System shall check to see if user is subscriber or past subscriber
*4. Upload Content: System shall allow Admin to upload videos and code challenges
*5. Check Solutions: System shall check user solution against test cases
	*5.1 Return result: System shall tell user how many test cases passed
*6. Check expiration: System shall check expiration date
	*6.1 Charge User: System shall charge user for another month 
	*6.2 Unsubscribe User: System shall disable subscription content
*7. Preview Content: System shall allow unregistered User to preview the Website.

## <div align="center">Requirements Table</div>
[(back to top)](#table-of-contents)

| Requirement ID | Requirement Description                                                                                                                                 | Test Method   |
|----------------|---------------------------------------------------------------------------------------------------------------------------------------------------------|---------------|
| 1.0            | Create User: System shall allow users to be created                                                                                                     | Demonstration |
| 1.1            | User Form: System shall allow users to input their personal information                                                                                 | Demonstration |
| 1.2            | Password Encryption: System shall encrypt password that has been input                                                                                  | Inspection    |
| 1.3            | Form Validations: System shall check to see if input data is correct type and length                                                                    | Inspection    |
| 2.0            | Authenticate User: System shall ensure the user is created                                                                                              | Demonstration |
| 3.0            | Login User: System shall login users with email and password                                                                                            | Demonstration |
| 3.1            | Check Subscription: System shall check to see if user is subscriber or past subscriber                                                                  | Demonstration |
| 4.0            | Upload Content: System shall allow Admin to upload videos and code challenges                                                                           | Demonstration |
| 5.0            | Check Solutions: System shall check user solution against test cases                                                                                    | Inspection    |
| 5.1            | Return result: System shall tell user how many test cases passed                                                                                        | Inspection    |
| 6.0            | Check expiration: System shall check expiration date                                                                                                    | Inspection    |
| 6.1            | Charge User: System shall charge user for another month                                                                                                 | Inspection    |
| 6.2            | Unsubscribe User: System shall disable subscription content                                                                                             | Inspection    |
| 7.0            | Preview Content: System shall allow unregistered User to preview the Website.                                                                           | Inspection    |


## <div align="center">Test Case Table</div>
[(back to top)](#table-of-contents)


| Test ID | Req ID                   | Test Procedure                                                                                                         | Current Status | Time Stamp |
|---------|--------------------------|------------------------------------------------------------------------------------------------------------------------|----------------|------------|
| TC001   | 1.0                      | Check if home page displays Countries, Tank Classes, and Compare features.                                             | Not Tested |            |
| TC002   | 1.1                      | User will be able to swipe through given selection on  the home page.                                                  | Not Tested |            |
| TC003   | 1.2                      | While on the tank class page, tier selection and tank selection should be displayed.                                   | Not Tested |            |
| TC004   | 1.3                      | Choose a certain tier and only tanks of that tier will  be displayed.                                                  | Not Tested |            |
| TC005   | 2.0                      | On the Countries page, selection of available countries  should display.                                               | Not Tested |            |
| TC006   | 3.0                      | User should be able to swipe through and select a certain  country on the Countries Page.                              | Not Tested |            |
| TC007   | 3.1                      | After tank selection, the tank description page should  display the information for that tank.                         | Not Tested |            |
| TC008   | 4.0                      | On the Compare page, User should be able to select a  minimum of two tanks to compare.                                 | Not Tested |            |
| TC009   | 5.0                      | Directed through tank selection process and redirected  to the Compare page.                                           | Not Tested |            |
| TC010   | 5.1                      | All of the chosen tanks statistics should be displayed  in order to effectively compare the values against each other. | Not Tested |            |
| TC011   | 6.0                      | Tank selection(s) should clear when the home page is clicked.                                                          | Not Tested |            |
| TC012   | 6.1                      | Tank selection(s) should clear when the home page is clicked.                                                          | Not Tested |            |
| TC013   | 6.2                      | Tank selection(s) should clear when the home page is clicked.                                                          | Not Tested | 
| TC014   | 7.0                      | Tank selection(s) should clear when the home page is clicked.                                                          | Not Tested |
## <div align="center">Initial Prototype</div>
[(back to top)](#table-of-contents)

**THESE ARE INITIAL DRAFTS**

[Prototypes](https://github.com/richminlee/Code_Sharpener/tree/master/Prototype)
