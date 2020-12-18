using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using FluentAssertions;
using Moq;
using Xunit;

namespace Brownbags.Test
{
    public class JourneyServiceTests
    {
        [Theory]
        [MemberData(nameof(GetList))]
        public void given_any_journeys_when_listing_then_return_the_count(List<Journey> journeys, int expectedCount)
        {
            Mock<IJourneyRepository> mockRepository = new Mock<IJourneyRepository>();
            mockRepository.Setup(x => x.List()).Returns(journeys);

            IJourneyRepository journeyRepository = mockRepository.Object;
            JourneyService sut = new JourneyService(journeyRepository);
            List<Journey> journeyList = sut.List();

            Assert.Equal(expectedCount, journeyList.Count);
        }

        [Fact]
        public void given_no_journey_when_listing_then_there_is_no_journey_message_should_be_thrown()
        {
            Mock<IJourneyRepository> mockRepository = new Mock<IJourneyRepository>();
            mockRepository.Setup(x => x.List()).Returns((List<Journey>) null);

            IJourneyRepository journeyRepository = mockRepository.Object;
            JourneyService sut = new JourneyService(journeyRepository);
            Action action = () => sut.List();

            string thereIsNoJourneyMessage = "There is no journey"; 

            action.Should().Throw<ThereIsNoJourneyException>().And.Message.Should().Be(thereIsNoJourneyMessage);
        }
        
        public static IEnumerable<object[]> GetList =>
            new List<object[]>
            {
                new object[] { new List<Journey>() { new Journey()}, 1 },
                new object[] { new List<Journey>() { new Journey(), new Journey()}, 2 },
            };
    }
}