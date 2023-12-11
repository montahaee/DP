namespace AdapterEngine.geometrical.elliptical;

public class RotatedEllipse
{   //TODO how to make rotated ellipse without knowledge of original axes (x and y).
    private double _angle;
    private double _height;
    private double _width;


    public RotatedEllipse(double angle, double height, double width)
    {
        AngleController(ref angle);
        _angle = angle;
        _width = width;
        _height = height;
    }

    private void AngleController(ref double angle)
    {
        if (angle <0 || angle >360)
        {
            Console.WriteLine($"The provided angle {angle} is not within the valid range" +
                              $"(0, 360).");
            double normalizedAngle = AngleNormalizer(angle);
            Console.WriteLine($"The possible angle is {normalizedAngle}. " +
                              $"Do you want it to use? (Y/N): ");

            try
            {
                string? response = Console.ReadLine();
                if (response != null)
                {
                    string answer = response.Trim().ToUpper();
                    if (answer.StartsWith('Y'))
                    {
                        angle = normalizedAngle;
                    } else if (answer.StartsWith('N'))
                    {
                        Console.WriteLine("Enter a new angle: ");
                        double newAngle = Convert.ToDouble(Console.ReadLine());
                        AngleController(ref newAngle);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    private double AngleNormalizer(double angle)
    {
        if (angle < 0)
        {
            angle *= -1;
        }

        return angle % 360.0;
    }
}