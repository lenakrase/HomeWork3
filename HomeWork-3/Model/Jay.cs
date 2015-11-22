using Helper;


namespace Model
{
    public class Jay : Gambler
    {       
        public Jay() : base("Jay") { }

        public override void FetchNewNumber(object sender, EventArgsNewNumber args)
        {
           if (args.Number.IsEven()) Score++;
        }
    }
}
