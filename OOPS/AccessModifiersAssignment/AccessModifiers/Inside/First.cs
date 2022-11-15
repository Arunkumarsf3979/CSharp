using Outside;
namespace Inside
{
    public class First:Third
    {
        public int PublicNumber=10;
        private int PrivateNumber=10;
        public int PrivateOutNumber { get{return PrivateNumber;}}
        protected int ProtectedNumber=20;
        public int ProtectedOutNumber{get{return ProtectedNumber;}}
        internal int InternalNumber=40;
    }
}