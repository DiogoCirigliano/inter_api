namespace sdk
{
    class ConfigSetup
    {
        static void Main(string[] args)
        {
            Config config = Config.Builder()
                .SetAmbiente("production")
                .SetClientId("your-client-id")
                .SetClientSecret("your-client-secret")
                .SetCertificado("path/to/certificate")
                .SetSenha("your-certificate-password")
                .SetDebug(true)
                .SetContaCorrente("1234567890")
                .SetControleRateLimit(true)
                .Build();
        }
    }
}
