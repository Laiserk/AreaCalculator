using AreaCalculatorLib.Figures;

namespace AreaCalculatorLib.Commands
{
    public class CalculatingAreaCommand : Command
    {
        private readonly IFigure _figure;
        public CalculatingAreaCommand(IFigure figure)
        {
            _figure = figure;
        }
        public override void ExecuteCommand()
        {
            Result = _figure.Area();
        }
    }
}