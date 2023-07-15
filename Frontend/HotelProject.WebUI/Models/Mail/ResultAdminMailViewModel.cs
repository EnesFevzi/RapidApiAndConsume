namespace HotelProject.WebUI.Models.Mail
{
    public class ResultAdminMailViewModel
    {
        public int MailID { get; set; }
        public string Name { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
