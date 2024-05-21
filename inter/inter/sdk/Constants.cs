namespace sdk
{
    public static class Constants
    {
        public const string URL_BASE = "https://cdpj.partners.AMBIENTE.com.br";
        public const string URL_TOKEN = URL_BASE + "/oauth/v2/token";
        public const string CALLBACKS = "callbacks";
        public const string URL_BANKING_SALDO = URL_BASE + "/banking/v2/saldo";
        public const string URL_BANKING_EXTRATO = URL_BASE + "/banking/v2/extrato";
        public const string URL_BANKING_EXTRATO_ENRIQUECIDO = URL_BASE + "/banking/v2/extrato/completo";
        public const string URL_BANKING_EXTRATO_PDF = URL_BASE + "/banking/v2/extrato/exportar";
        public const string URL_BANKING_WEBHOOK = URL_BASE + "/banking/v2/webhooks";
        public const string DOC_CERTIFICADO = "https://developers.bancointer.com.br/v4/docs/onde-obter-o-certificado";
        public const string ESCOPO_EXTRATO_READ = "extrato.read";
        public const string ESCOPO_LOCATION_READ = "payloadlocation.read";
        public const string ESCOPO_LOCATION_WRITE = "payloadlocation.write";
        public const string ESCOPO_WEBHOOK_READ = "webhook.read";
        public const string ESCOPO_WEBHOOK_WRITE = "webhook.write";
        public const string ESCOPO_WEBHOOK_BANKING_READ = "webhook-banking.read";
        public const string ESCOPO_WEBHOOK_BANKING_WRITE = "webhook-banking.write";
        public const int DAYS_TO_EXPIRE = 30;
        public const string CERTIFICATE_EXCEPTION_MESSAGE = "Erro no Certificado!";
        public const string GENERIC_EXCEPTION_MESSAGE = "Erro durante execução do SDK!";
    }
}
