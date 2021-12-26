using AreaCalculatorLib.Interfaces;

namespace AreaCalculatorLib.Commands
{
    public abstract class Command : ICommand
    {
        public double Result { get; set; }
        public abstract void ExecuteCommand();
    }
}