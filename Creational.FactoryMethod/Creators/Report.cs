using Creational.FactoryMethod.AbstractCreators;
using Creational.FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.Creators
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
        //Factory method implementation
        public override void CreatePages()
        {
            this.Pages.Add(new IntroductionPage());
            this.Pages.Add(new ResultsPage());
            this.Pages.Add(new SummaryPage());
            this.Pages.Add(new BibliographyPage());
        }
    }
}
