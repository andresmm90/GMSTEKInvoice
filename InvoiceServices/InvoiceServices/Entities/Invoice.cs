using System;

namespace InvoiceServices.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
    }
}
