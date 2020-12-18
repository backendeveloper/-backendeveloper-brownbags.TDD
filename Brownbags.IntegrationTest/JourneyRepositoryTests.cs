using System;
using System.Collections.Generic;
using Brownbags.Test;
using FluentAssertions;
using Xunit;

namespace Brownbags.IntegrationTest
{
    public class JourneyRepositoryTests
    {
        public JourneyRepositoryTests()
        {
            JourneyRepositoryHelper.InitiliazeJourneyTable();
        }
        
        [Fact]
        public void given_one_journey_when_listing_then_the_count_of_list_should_be_one()
        {
            JourneyRepositoryHelper.InsertOneJourney();

            JourneyRepository sut = new JourneyRepository();
            List<Journey> list = sut.List();

            list[0].Id.Should().Be("1");
        }

        [Fact]
        public void given_two_journey_when_listing_then_the_count_of_list_should_be_two()
        {
            JourneyRepositoryHelper.InsertTwoJourney();

            JourneyRepository sut = new JourneyRepository();
            List<Journey> list = sut.List();

            list[0].Id.Should().Be("1");
            list[1].Id.Should().Be("2");
        }
    }
}