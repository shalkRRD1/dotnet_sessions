namespace CircleAbstractionApp.Models
{
     class Circle
    {

        public int radius;

        public float CalculateArea()
        {
            return (float)(radius * radius * 3.14);
        }
    }
}
