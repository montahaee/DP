namespace Generator.components;

/// <summary>
///     The SemiAutomaticTransmission class represents an semi-automatic transmission.
/// </summary>
internal class SemiAutomaticTransmission : Transmission
{
    public override string Type => "Semi-Automatic";

    public override bool IsAutomated => true;
}