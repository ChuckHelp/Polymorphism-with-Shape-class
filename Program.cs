namespace Coordinates {
   //Shapes class starts here
   public class Shape{

      // A few example members
      public int X { get; private set; }
      public int Y { get; private set; }
      public int Height { get; set; }
      public int Width { get; set; }

      // Virtual method
      public virtual void Draw()
      {
        Console.WriteLine("Performing base class drawing tasks");
      }

      public class Circle : Shape
      {
         public override void Draw()
         {
         // Code to draw a circle...
         Console.WriteLine("Drawing a circle");
         base.Draw();
         }
      }
      public class Rectangle : Shape
      {
         public override void Draw()
         {
         // Code to draw a rectangle...
         Console.WriteLine("Drawing a rectangle");
         base.Draw();
         }
      }  

   } //Shapes class ends by here

   class ExecuteShape {
      static void Main(string[] args) {

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Shape.Circle());
        shapes.Add(new Shape.Rectangle());

        foreach (Shape s in shapes)
        {
            s.Draw();
        }

        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
      }
   }
}