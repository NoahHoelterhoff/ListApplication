using System.ComponentModel;

namespace ListApplication.Types
{
    public class Customer(string name, Membership membership)
    {
        public string Name { get; set; } = name;
        public Membership Membership { get; set; } = membership;
        public BindingList<ProductOrder> Basket { get; private set; } = [];
    }
}
