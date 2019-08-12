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
    class Admin : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsetPage());
            Pages.Add(new EducationPage());
            Pages.Add(new SummaryPage());
        }
    }
}
