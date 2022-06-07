using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace first_attempt.StepDefinotions
{
    [Binding]
    public class TMFeatureStepDefinition
    {
        [Given(@"I login to turnup portal successfully")]
        public void GivenILoginToTurnupPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Time&Material page")]
        public void WhenINavigateToTimeMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new time/material record")]
        public void WhenICreateANewTimeMaterialRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"A new T&M record should be create successfully")]
        public void ThenANewTMRecordShouldBeCreateSuccessfully()
        {
            throw new PendingStepException();
        }




    }
}
