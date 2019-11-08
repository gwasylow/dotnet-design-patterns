# Dotnet-Design-Patterns
## Let's do that in a proper manner.

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
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-adapter.PNG)

		
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


10. Structural.Facade:
	- Main reason: `Single class that represents an entire subsystem(s)`
	- Façade defines a higher-level interface that makes the subsystem easier to use.
	- `Façade see all sub systems, but sub systems don't see/interact with a Façade` & other sub systems (simple composition)
	- Usage: Bank system (Mortgage Facade) that checks other sub-systems is Customer eligble to take a mortgage. 
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-facade.PNG)	


11. Structural.Flyweight:
	- Pattern used for a `fine-grained instance used for efficient sharing`
	- Use sharing to support large numbers of fine-grained objects efficiently - simply: `memory optimisation/object normalization technique`
	- The Flyweight pattern conserves memory by sharing large numbers of fine-grained objects efficiently. 
	- Shared flyweight objects are immutable, that is, they cannot be changed as they represent the characteristics that are shared with other objects.
	- Usage: Always when memory optimisation process is required.
	- Usage: You will find flyweights mostly in utility type applications such as word processors, graphics programs, and network apps; they are less often used in data-driven business type applications.
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-flyweight.PNG)


12. Structural.Proxy:
	- Provide a surrogate or `placeholder for another object to control access to it`. We have several kind of proxies:
		- `remote proxies` are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space.
		- `virtual proxies` may cache additional information about the real subject so that they can postpone accessing it. For example, the ImageProxy from the Motivation caches the real images's extent.
		- `protection proxies` check that the caller has the access permissions required to perform a request.
	- Usage: Always when we do not want to expose the classes/objects `called Subjects` to a Client, we can hide the implementation by a Proxy.
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dp-proxy.PNG)	


13. Architecures Review:
	- MVC (Web Apps - CORE / ASP.NET / SPA)
	- MVP (Windows Forms)
	- MVVM (WPF apps)
	
![alt text](https://github.com/gwasylow/dotnet-design-patterns/blob/master/Images/dg-mvc-mvp-mvvm.PNG)