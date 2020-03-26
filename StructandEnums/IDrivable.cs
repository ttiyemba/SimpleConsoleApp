namespace StructandEnums
{
    interface IDrivable
    {
        public int Wheels { get; set; }
        public double   Speed { get; set; }

        void Move();
        void Stop();
    }
}