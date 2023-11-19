

namespace src.components
{
    internal class ManualTransmission : Transmission
    {
        public override string Type => "Manual";

        public override bool IsAutomated => false;
    }
}
