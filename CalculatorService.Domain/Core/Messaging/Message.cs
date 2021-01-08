namespace CalculatorService.Domain.Core.Messaging
{
    public abstract class Message 
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }
        public string MessageType { get; protected set; }        
    }
}