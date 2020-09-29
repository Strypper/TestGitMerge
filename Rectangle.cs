namespace TestGit
{
 public class Rectangle
 {
   public int Width { get; set; }
   public int Height { get; set; }

   public int CalculateArea()
   {
     return this.Width*this.Height;
   }
 } 
}
