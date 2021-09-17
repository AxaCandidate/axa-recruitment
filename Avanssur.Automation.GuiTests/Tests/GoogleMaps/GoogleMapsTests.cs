using Avanssur.Automation.GuiTests.PageObjects;
using Avanssur.Automation.Utils;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Avanssur.Automation.GuiTests.Tests.GoogleMaps
{
    public class GoogleMapsTests : BaseTest
    {
        [Test]
        public void GoogleMaps_CheckDistanceFromChlodna51ToPlacDefilad1_WalkingLessThan40MinAndLessThan3KmAndCyclingLessThan15MinAndLessThan3Km()
        {
            Pages.Create<CookieInfoPage>()
                .IAgree.Click();

            Pages.Create<EntryPage>()
                .Directions.Click();

            var directionsPage = Pages.Create<DirectionsPage>();

            var walkingTime =
                directionsPage
                .ChooseStartingPoint.EnterText("Plac Defilad 1 Warszawa")
                .ChooseDestination.EnterText("Chłodna 51 Warszawa" + Keys.Enter)
                .Walking.Click()
                .FirstResultTime.GetText();

            var walkingDistance =
                directionsPage
                .FirstResultDistance.GetText();

            walkingTime.TrimUnit().Should().BeLessThan(40);
            walkingDistance.TrimUnit().Should().BeLessThan(3);

            directionsPage
                .Cycling.Click();

            var cyclingTime =
                directionsPage
                .FirstResultTime.GetText();

            var cyclingDistance =
                directionsPage
                .FirstResultDistance.GetText();

            cyclingTime.TrimUnit().Should().BeLessThan(15);
            cyclingDistance.TrimUnit().Should().BeLessThan(3);
        }

        [Test]
        public void GoogleMaps_CheckDistanceFromPlacDefilad1ToChlodna51_WalkingLessThan40MinAndLessThan3KmAndCyclingLessThan15MinAndLessThan3Km()
        {
            Pages.Create<CookieInfoPage>()
                .IAgree.Click();

            Pages.Create<EntryPage>()
                .Directions.Click();

            var directionsPage = Pages.Create<DirectionsPage>();

            var walkingTime =
                directionsPage
                .ChooseStartingPoint.EnterText("Chłodna 51 Warszawa")
                .ChooseDestination.EnterText("Plac Defilad 1 Warszawa" + Keys.Enter)
                .Walking.Click()
                .FirstResultTime.GetText();

            var walkingDistance =
                directionsPage
                .FirstResultDistance.GetText();

            walkingTime.TrimUnit().Should().BeLessThan(40);
            walkingDistance.TrimUnit().Should().BeLessThan(3);

            directionsPage
                .Cycling.Click();

            var cyclingTime =
                directionsPage
                .FirstResultTime.GetText();

            var cyclingDistance =
                directionsPage
                .FirstResultDistance.GetText();

            cyclingTime.TrimUnit().Should().BeLessThan(15);
            cyclingDistance.TrimUnit().Should().BeLessThan(3);
        }
    }
}
