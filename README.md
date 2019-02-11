# PatternsWinFormsHW2
ITStep(Gomel)-Patterns WinForms Home work 2

Task 1.

Develop a class system that implements the Singleton and Alternate patterns.

Class Head (RealSubject in the Proxy pattern). 

Composition of the class: 
the Name and Bonus Fund properties, 
the method for creating orders for awarding the award 
(parameters - the name of the employee being rewarded, the percentage of the bonus, the result - the text of the order). 
There should be only one boss in the system.

The Secretary (Proxy) class must contain the Name property, 
a method for creating orders for awarding a prize, in which the standard header, 
the current date and the secretary’s signature are added to the order of the chief.

In the client (in the Program class of the console application or in the Form class of the Windows Forms application), 
you must enter the employee's last name and bonus percentage, after which an order issued by the secretary should be issued.

Task 2.

Implement the Repository pattern in the application that manages the information about the patients of the veterinary clinic. As a data warehouse use a database, xml-document, a collection of objects in memory, a text file in csv format. Create implementations for Dog and Cat objects.
