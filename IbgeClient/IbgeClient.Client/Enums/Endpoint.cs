using System.ComponentModel;

namespace IbgeClient.Client.Enums
{
    public enum Endpoint
    {
        #region Autenticação e Autorização
        [Description("https://localhost:7122/v1/accounts")]
        Account,
        [Description("https://localhost:7122/v1/login")]
        Login,
        #endregion

        #region Localidades
        [Description("https://localhost:7122/v1/ibges")]
        GetIbges,
        [Description("https://localhost:7122/v1/ibges")]
        PostIbges,
        [Description("https://localhost:7122/v1/ibges")]
        PutIbges,
        [Description("https://localhost:7122/v1/ibges/city")]
        GetIbgesCity,
        [Description("https://localhost:7122/v1/ibges/state")]
        GetIbgesState,
        [Description("https://localhost:7122/v1/ibges/codeIbge")]
        GetCodeIbges,
        [Description("https://localhost:7122/v1/ibges/id")]
        DeleteIbges
        #endregion
    }
}
