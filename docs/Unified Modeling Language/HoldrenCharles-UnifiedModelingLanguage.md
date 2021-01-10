*Charles Holdren*<br>
*January 10, 2021*
# Unified Modeling Language

## Activity Diagrams
In UML, Activity Diagrams focus on a specific task or process of a project. Below are some common symbols found within UML Activity Diagrams.

### **Common Symbols.**

* **Diamond**: The diamond symbol indicates a **decision** activity. The initial diamond branches a decision into at least 2 branches. A second diamond, called a **merge**, is used to join the paths after the decision has been made.
* **Solid Circle**: Known as the **Initial state** (or **node**), indicates the starting point in the diagram.
* **Solid Line and Arrow**: A solid line and arrow represents the **control flow** of the diagram. The control flow illustrates to the reader the order in which the symbols are to be read.
* **Dotted Line and Text connecting to a Diamond**: This denotes a **decision label**, a short statement explaining what decision is being made.
* **Rectangle**: The rectangle symbol indicates what **action** is being performed in an activity diagram.
* **Solid Circle surrounded by another Circle**: Known as the **Final State** (or **End Node**), indicates the ending point in the diagram.
* **Fork/Join**: A **fork** is a solid line splits a single control flow into two control flows. Similar to a *decision*, a fork may also be followed by another solid line called a **join**, which joins the seperate control flows onto a single path.


### **Linear vs Non-Linear**

######*"What is the difference between a linear and non-linear process?"*

A **linear** process describes the series of steps that happen in a *sequential* order (i.e. *Step 1, Step 2, Step 3.. etc*). 

Contratily, a **non-linear** process describes a process that contain at least one non-linear process, meaning it can occur in any order.

## Class Diagrams

###### Example of a Class within a Class Diagram:

| Class Name |
| ---------- |
| - attribute : datatype[multiplicity]<br>+ attribute : datatype[multiplicity] |
| # behavior(parameters) : return type<br>+ behavior(parameters) : return type

<br>
#### **Common Accessibility (Visibility) Modifiers**

| Symbol 		  | Accessibility |
| ------------- |:------------- |
|**+** |  Public |
|**-** | Private |
|**#** | Protected |

<br>
#### **What are "Attributes" in a Class Diagram?**

In UML Class Diagrams, **Attributes** are the values stored within a class. In programming, these values would be the class' fields (or properties), which can be values of any datatype (including objects and collections).

######Examples:

| UML | <center>C#</center>|
| --- |:--- |
| - Name : String [1] | private string \_name; |
| + IsTrue : Bool [0..1] | public bool IsTrue { get; set; } |
| # Library : Books [0..*] | protected List\<Book> _library; |

<br>    
#### **What are "Behaviors" in a class diagram?**

In UML Class Diagrams, **Behaviors** are the methods that belong to that class. In programming, Methods are blocks of code that can perform processes and are typically designed to be flexibile for reusability.

######Examples:

| UML | <center>C#</center>|
| --- |:--- |
| - Calculate(Money amt) : Money | private Money Calculate(Money amt) { ... return amt; } |
| + ChangeName() : String | public string ChangeName() { ... return name; } |
| # ReturnBook(Book book) : Void | protected void ReturnBook(Book book) { ... }; |

<br>
#### **What is a "minimal viable product" (MVP) in project development?** 

A **minimal viable product (MVP)** is a concept borrowed from the *Lean startup* methodology, which aims to shorten development time and cost, while discovering if the product is viable to consumers. Creating a minimal viable product is a preferred method during the discovery phase of a project, as it allows developers to recieve feedback about a product at minimal cost.



<br>

# Reference Links

**Unified Modeling Language**

* [*UML Distilled: A Brief Guide to the Standard Object Modeling Language, Third Edition*] (https://learning.oreilly.com/library/view/uml-distilled-a/0321193687/)
* [*Programming Foundations*](https://www.linkedin.com/learning/programming-foundations-object-oriented-design-3) 


**Activity Diagram Symbols**  

* [UML Diagram Symbols | Wonderhsare EdrawMax](https://www.edrawsoft.com/uml-diagram-symbols.html)

* [UML Activity Diagram Tutorial | Lucidchart](https://www.lucidchart.com/pages/uml-activity-diagram)

**Linear vs Non-Linear**  

* [Linear Programming | Brilliant Math & Science Wiki](https://brilliant.org/wiki/linear-programming/)

* [Practical Optimization: a Gentle Introduction | Chapter 16: Introduction to Nonlinear Programming](https://www.sce.carleton.ca/faculty/chinneck/po/Chapter16.pdf)


**Class Diagrams:**  

* [OOAD - UML Basic Notations - Tutorialspoint](https://www.tutorialspoint.com/object_oriented_analysis_design/ooad_uml_basic_notation.htm)

 
* [Access Modifiers - C# Programming Guide | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)


**Minimal viable product:**

* [What is a Miminum Viable Product (MVP)? | Agile Alliance](https://www.agilealliance.org/glossary/mvp/#q=~(infinite~false~filters~(tags~(~'mvp))~searchTerm~'~sort~false~sortDirection~'asc~page~1))


