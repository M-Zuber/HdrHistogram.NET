﻿using NUnit.Framework;

namespace HdrHistogram.UnitTests
{
    [TestFixture]
    public class LongConcurrentHistogramTests : ConcurrentHistogramTestBase
    {
        protected override int WordSize => sizeof(long);

        protected override HistogramBase Create(long highestTrackableValue, int numberOfSignificantValueDigits)
        {
            return new LongConcurrentHistogram(1, highestTrackableValue, numberOfSignificantValueDigits);
        }

        protected override HistogramBase Create(long lowestTrackableValue, long highestTrackableValue, int numberOfSignificantValueDigits)
        {
            return new LongConcurrentHistogram(lowestTrackableValue, highestTrackableValue, numberOfSignificantValueDigits);
        }
    }
}