﻿using System;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.NUnit3;

namespace CSF
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(() => new Fixture().Customize(new AutoMoqCustomization()))
        {
        }
    }
}