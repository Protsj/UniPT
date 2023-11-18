namespace ClassLibrary1
{
    public class ModSinX
    {
        double x;
        double min = 0.001;
        public ModSinX(double x) { this.x = x; }
        public ModSinX() { this.x = 0; }
        public double X() { return x; }
        public double ModSinXLoop()
        {
            double sum = 0;
            double current = 1;
            int n = 0;
            do
            {
                current = Math.Cos(2 * (n + 1) * x) / ((2 * n + 1) * (2 * n + 3));
                sum += current;
                n++;
            } while (current > min || current < -min);
            return 2 / Math.PI - 4 / Math.PI * sum;
        }
        public double ModSinXRec(double current, double n, double sum)
        {
            if (current > min || current < -min)
            {
                current = Math.Cos(2 * (n + 1) * x) / ((2 * n + 1) * (2 * n + 3));
                sum += current;
                n++;
                return ModSinXRec(current, n, sum);
            }
            return 2 / Math.PI - 4 / Math.PI * sum;
        }
    }
}
