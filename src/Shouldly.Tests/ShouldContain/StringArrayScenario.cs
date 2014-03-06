﻿namespace Shouldly.Tests.ShouldContain
{
    public class StringArrayScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            new[]{"a", "b", "c"}.ShouldContain("d");
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return " new[]{\"a\", \"b\", \"c\"} should contain \"d\" but was [\"a\", \"b\", \"c\"]"; }
        }

        protected override void ShouldPass()
        {
            new[] { "a", "b", "c" }.ShouldContain("b");
        }
    }
}