namespace MegaDesk_3_JeaninaLao
{
    class Desk
    {

        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public SurfaceMaterial DeskMaterial { get; set; }

    }

    //struct Desk1
    //{
    //    public int Width1;
    //    public int Depth1;
    //    public int NumberOfDrawers1;
    //    public getInput(int Width1, int Depth1, int NumberOfDrawers1)
    //    {
    //        this.Width1 = Width1;
    //        this.Depth1 = Depth1;
    //        this.NumberOfDrawers1 = NumberOfDrawers1;
    //    }
    //}
}
