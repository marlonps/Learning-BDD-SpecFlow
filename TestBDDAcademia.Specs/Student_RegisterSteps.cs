using Gym;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace TestBDDAcademia.Specs
{
    [Binding]
    public class Student_RegisterSteps
    {
        private StudentRegister studentRegister = new StudentRegister();
        private string Name;
        [Given(@"""(.*)"" is registered")]
        public void GivenIsRegistered(string name)
        {
            studentRegister.Name = name;
        }
        
        [When(@"I consult ""(.*)""'s data")]
        public void WhenIConsultSData(string p0)
        {
            Name = studentRegister.GetName();
        }
        
        [Then(@"I should receive information about ""(.*)""'s Name")]
        public void ThenIShouldReceiveInformationAboutSName(string expectedName)
        {
            Assert.AreEqual(expectedName, Name);
        }
    }
}
