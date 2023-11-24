namespace Generator.components;

/// <summary>
///     The AutomaticTransmission class represents an automatic transmission.
/// </summary>
internal class AutomaticTransmission : Transmission
{
    public override string Type => "Automatic";

    public override bool IsAutomated => true;
}