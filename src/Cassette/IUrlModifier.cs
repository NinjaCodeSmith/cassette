﻿namespace Cassette
{
    /// <summary>
    /// Modifies the URLs generated by Cassette.
    /// </summary>
    public interface IUrlModifier
    {
        /// <summary>
        /// Modifies a URL.
        /// </summary>
        /// <param name="url">The URL to modify.</param>
        /// <returns>The modified URL.</returns>
        string Modify(string url);
    }
}