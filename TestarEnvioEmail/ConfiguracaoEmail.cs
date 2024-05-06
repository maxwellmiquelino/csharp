public class ConfiguracaoEmail
{
    public string Domain { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public string EmailAdress { get; set; }
    public int Port { get; set; }
    public bool SecuritySSL { get; set; }
    public bool HtmlBody { get; set; }
    public string From { get; set; }
    public string Subject { get; set; }
}