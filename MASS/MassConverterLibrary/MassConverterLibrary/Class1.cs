using System;

namespace MassConverterLibrary
{
    public abstract class Mass
    {
        public abstract double ConvertMass(string unitFrom, string unitTo);
    }

    public class MassVariable : Mass
    {
        private double _result;

        public double Result
        {
            get => _result;
            set => _result = value;
        }

        public MassVariable(double result) => Result = result;
        /// <summary>
        /// Convert mass unitFrom unitTo
        /// </summary>
        /// <param name="unitFrom">Youre actualy mass</param>
        /// <param name="unitTo">The mass you want to convert to</param>
        /// <returns>converted mass for a given type</returns>
        public override double ConvertMass(string unitFrom, string unitTo)
        {
            if (unitFrom == unitTo)
                return _result;
            if (unitFrom == "g")
            {
                switch (unitTo)
                {
                    case "lbs":
                        _result = _result * 0.0022046226;
                        break;
                    case "oz":
                        _result = _result * 0.0352739619;
                        break;
                    case "mg":
                        _result = _result * 1000;
                        break;
                    default:
                        throw new Exception("An invalid value was entered!");
                }
            }
            else if (unitFrom == "lbs")
            {
                switch (unitTo)
                {
                    case "g":
                        _result = _result * 453.59237;
                        break;
                    case "oz":
                        _result = _result * 16;
                        break;
                    case "mg":
                        _result = _result * 453592.37;
                        break;
                    default:
                        throw new Exception("An invalid value was entered!");
                }
            }
            else if (unitFrom == "oz")
            {
                switch (unitTo)
                {
                    case "g":
                        _result = _result * 28.349523125;
                        break;
                    case "lbs":
                        _result = _result * 0.0625;
                        break;
                    case "mg":
                        _result = _result * 28349.523125;
                        break;
                    default:
                        throw new Exception("An invalid value was entered!");
                }
            }
            else if (unitFrom == "mg")
            {
                switch (unitTo)
                {
                    case "g":
                        _result = _result * 0.001;
                        break;
                    case "lbs":
                        _result = _result * 0.0000022046;
                        break;
                    case "oz":
                        _result = _result * 0.000035274;
                        break;
                    default:
                        throw new Exception("An invalid value was entered!");
                }
            }
            return _result;
        }
    }
}
