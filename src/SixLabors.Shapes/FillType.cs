// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.Shapes
{
    /// <summary>
    /// The fill type method used when filling a polygon.
    /// </summary>
    public enum FillType
    {
        /// <summary>
        /// Even-Odd rule.
        /// </summary>
        EvenOdd = 0,

        /// <summary>
        /// Non-Zero rule.
        /// </summary>
        NonZero = 1,

        /// <summary>
        /// Positive rule.
        /// </summary>
        Positive = 2,

        /// <summary>
        /// Negative rule.
        /// </summary>
        Negative = 3,
    }
}