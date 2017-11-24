namespace DesignPatterns.Adapter
{
    public class Adapter :  IOldSocket
    {
        
        private readonly NewSocket adapteeNew;
       
        public Adapter(NewSocket adaptee)
        {
            this.adapteeNew = adaptee;
        }
       
        public string MatchOldSocket()
        {
            return this.adapteeNew.MatchNewSocket();
        }
    }
}
