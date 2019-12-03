namespace PolymorfTerning
{
    sealed class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {
        }
        public LudoTerning (int vaerdi) : base(vaerdi)
        {
        }

        public bool ErGlobus()
        {
            return this.Vaerdi == 3;
        }
        public bool ErStjerne()
        {
            if (Vaerdi == 5)
                return true;
            else
                return false;
        }
        public override void Skriv()
        {
            if(ErGlobus())
            {
                System.Console.WriteLine("[G]");
                return;
            }
            if (ErStjerne())
            {
                System.Console.WriteLine("[S]");
                return;
            }
            base.Skriv();
            
        }

    }
}
