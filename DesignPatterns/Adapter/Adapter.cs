namespace DesignPatterns.Adapter
{
    public class Adapter : INewSocket, IOldSocket
    {
        private readonly OldSocket adapteeOld;
        private readonly NewSocket adapteeNew;
        public Adapter(OldSocket adaptee)
        {
            this.adapteeOld = adaptee;
        }
        public Adapter(NewSocket adaptee)
        {
            this.adapteeNew = adaptee;
        }
        public string MatchNewSocket()
        {
            return this.adapteeOld.MatchThinSocket();
        }
        public string MatchOldSocket()
        {
            return this.adapteeNew.MatchNewSocket();
        }
    }
}
