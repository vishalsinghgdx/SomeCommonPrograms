using System;

namespace CommonProgram
{
    public class Triangle : MyShape, Shape
    {
        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            Console.WriteLine("Print Triangle");
        }
    }

}
