using System;

namespace StrongholdFinder
{
    class Line
    {
        double _slope;
        double _intercept;

        public void Intercept(Line other, out double x, out double z)
        {
            double slopeDiff = _slope - other._slope;
            double interceptDiff = other._intercept - _intercept;

            x = interceptDiff / slopeDiff;
            z = _slope * x + _intercept;
        }

        public Line(double x, double z, double angle)
        {
            _slope = -1 / Math.Tan(angle);
            _intercept = z - _slope * x;
        }
    }
}
