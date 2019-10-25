#dotnet-design-patterns
##Dotnet design patterns

* Creational:
1. Creational.AbstractFactory:
	- Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
	- Usage: Report Engine & conctere Report Factories:
		- We know that any report have shared engine (data/footer etc), but they are completely different in view (Factories):
		- PdfReports, share dependencies among report family, ConcreteFacotry1,
		- XlsReports, share dependencies among report family, ConcreteFacotry2,
		- PlainReports, share dependencies among report family, ConcreteFacotry3.
		
2. Creational.Builder:
	- Separate the construction of a complex object from its representation so that the same construction process can create different representations.
	- Usage: vehicle factory:
		- Runs always 3 steps: `Plan / Build / Tests` (building methods),
		- In our case we would like to have a possibility to build a Car, Scooter and Motorcyckle. Builder seems to be the best option in here.
		
3. Creational.FactoryMethod:
	- Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
	- Usage I: web application views engine, let the concrete wizards display what is really needed:
		- ReportSection (FactoryMethod) will build Report-related pages (decide internally which ones),
		- UserSection (FactoryMethod) will build User-related pages (decide internally which ones),
		- AdminPanelSection (FactoryMethod) will build Admin-Panel pages (decide internally which ones).
	- Usage II: Webshop sells completely different products, but at the end of a day all products share common base. FactoryMethod would be a great improvement in here. 

4. Creational.Prototype:
	- Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype.
	- Usage: any time we need to Clone objects, we should follow the Prototype Design Pattern.
		- We need to implement `Clone()` method which will be exposed outside of a logic and perform real clonning on concrete prototype,
		- Copied class shoud be automatically initialised under specialised conditions, we would like to have a control over that process,
		- In a simple words: "Create and initialise an object by `Clone()` method basing on your statement".

5. Creational.Singleton:
	- A class of which only a single instance can exist
	- Usage: always when single intance of an object is required,
		- Info: `static readonly` fields are thread-safe in MS .NET Framework. No-Lock is needed.


* Structural:	
6. Structural.Adapter:
	- Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
	- Usage: use adapter pattern when classes should be compatible, however by default they are not able.
		- Use Adapter to adapt two different APIs to each other, for example: integration of WinApi and LinuxApi.
		- Main role is to create an adapter that would be able to interact between different types,
		- Adapter pattern maps the interface of one class onto another so that they can work together. These incompatible classes may come from different libraries or frameworks,
		- Example: compund of chemical structures could be `adapted` together.

		
7. Structural.Bridge:
	- Separates an object’s interface from its implementation,
	- Decouple an abstraction from its implementation so that the two can vary independently,
	- Usage: decouple different types (Book/Car/Plane) and separate them using abstract `Operation` method. Use to decompose absraction from implementation (value added: we can modify elements with no dependencies).
	- Usage: separate two different APIs, like WinApi and UnixApi and take the most important common part together.
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-bridge.PNG)
	
	
8. Structural.Composite:
	- Tree structure organisation,
	- Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
	- Usage: Directory tree
	- Usage: Corporate structure tree	
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-composite.PNG)	
	
	
9. Structural.Decorator:
	- Attach `additional responsibilities to an object dynamically`. Add additional behaviour to class without their code modification.
	- Decorator provide a flexible alternative to subclassing for extending functionality.
	- Use composition alternatively to inheritance. `SOLID principle => O => Open for extension, closed for modification`.
	- USe Decoarator when you are unable to modify the exisiting code, there's many combination of types (mixed) you'd like to use.
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-decorator.PNG)
	