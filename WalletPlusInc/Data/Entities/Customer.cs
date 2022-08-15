namespace WalletPlusInc.Data.Entities
{
    public class Customer : BaseEntity<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public GenderEnum Gender { get; set; }

        public MaritalStatusEnum2 MaritalStatus { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        //public string Address { get; set; }

        public bool Active { get; set; }
    }
}
