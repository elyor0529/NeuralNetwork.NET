﻿namespace NeuralNetworkDotNet.APIs.Enums
{
    /// <summary>
    /// Indicates the pooling mode performed by a pooling layer
    /// </summary>
    public enum PoolingMode
    {
        /// <summary>
        /// Only the highest neuron in each input receptive field is propagated
        /// </summary>
        Max = 0,

        /// <summary>
        /// The average value in each input receptive field (including padding neurons) is propagated
        /// </summary>
        AverageIncludingPadding = 1,

        /// <summary>
        /// The average value in each input receptive field (excluding padding neurons) is propagated
        /// </summary>
        AverageExcludingPadding = 2
    }
}
