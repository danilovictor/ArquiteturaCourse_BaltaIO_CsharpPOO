using ArqPayments.NotificationContext;
namespace ArqPayments.ContentContext{

    public abstract class Base : Notifiable{

        public Base() {
            Id = Guid.NewGuid();
         }

        public Guid Id { get; set; }
    }
}