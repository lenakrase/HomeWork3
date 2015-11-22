using Helper;

namespace Model
{
    public class SilentBob: Gambler
    {
        public SilentBob() : base("SilentBob") { }
        public override void FetchNewNumber(object sender, EventArgsNewNumber args)
        {
           if(!args.Number.IsEven()) Score++;
        }
    }
}
