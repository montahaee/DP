namespace Generator.components;

/// <summary>
///     The _transmission class is an abstract base class
///     for different types of transmissions.
/// </summary>
internal abstract class Transmission
{
    /// <summary>
    ///     Gets the type of the transmission.
    /// </summary>
    public abstract string Type { get; }

    /// <summary>
    ///     Gets a value indicating whether the transmission is automated.
    /// </summary>
    public abstract bool IsAutomated { get; }
}