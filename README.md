# dotnet-design-patterns
Dotnet design patterns

1. Creational.AbstractFactory:
	- Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
	- Usage: Report Engine & conctere Report Factories:
		> We know that any report have shared engine (data/footer etc), but they are completely different in view (Factories):
		> PdfReports, share dependencies among report family, ConcreteFacotry1
		> XlsReports, share dependencies among report family, ConcreteFacotry2
		> PlainReports, share dependencies among report family, ConcreteFacotry3
		
2. Creational.Builder:
	- Separate the construction of a complex object from its representation so that the same construction process can create different representations.
	- Usage: vehicle factory:
		> Runs always 3 steps: Plan / Build / Tests (building methods)
		> In our case we would like to have a possibility to build a Car, Scooter and Motorcyckle. Builder seems to be the best option in here.
		
3. Creational.FactoryMethod:
	- Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
	- Usage: web application views engine, let the concrete wizards display what is really needed:
		> ReportSection (FactoryMethod) will build Report-related pages (decide internally which ones)
		> UserSection (FactoryMethod) will build User-related pages (decide internally which ones)
		> AdminPanelSection (FactoryMethod) will build Admin-Panel pages (decide internally which ones)
	