using Structural.Composite.Nodes;
using System;

namespace Structural.Composite
{
    /**
     * 
     *  Composite: 
     *      Compose objects into tree structures to represent 
     *      part-whole hierarchies. Composite lets clients treat 
     *      individual objects and compositions of objects uniformly.
     *      
     *  Component   (DrawingElement)
     *      declares the interface for objects in the composition.
     *      implements default behavior for the interface common to all classes, as appropriate.
     *      declares an interface for accessing and managing its child components.
     *      (optional) defines an interface for accessing a component's parent in 
     *      the recursive structure, and implements it if that's appropriate.
     *      
     *  Leaf   (PrimitiveElement)
     *      represents leaf objects in the composition. A leaf has no children.
     *      defines behavior for primitive objects in the composition.
     *      
     *  Composite   (CompositeElement)
     *      defines behavior for components having children.
     *      stores child components.
     *      implements child-related operations in the Component interface.
     *
     *  Client  (CompositeApp)
     *      manipulates objects in the composition through the Component interface.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new LeafPrimitiveElement("Red Line"));
            root.Add(new LeafPrimitiveElement("Blue Circle"));
            root.Add(new LeafPrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new LeafPrimitiveElement("Black Circle"));
            comp.Add(new LeafPrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            LeafPrimitiveElement pe = new LeafPrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }
}
