namespace Generator.components;

/// <summary>
///     The SingleSpeedTransmission class represents an single
///     speed transmission.
/// </summary>
internal class SingleSpeedTransmission : Transmission
{
    public override string Type => "Single Speed";

    public override bool IsAutomated => true;
}