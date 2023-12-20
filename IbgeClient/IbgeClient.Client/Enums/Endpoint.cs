using System.ComponentModel;

namespace IbgeClient.Client.Enums
{
    public enum Endpoint
    {
        #region Autenticação e Autorização
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/accounts")]
        Account,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/login")]
        Login,
        #endregion

        #region Localidades
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges")]
        GetIbges,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges")]
        PostIbges,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges")]
        PutIbges,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges/city")]
        GetIbgesCity,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges/state")]
        GetIbgesState,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges/codeIbge")]
        GetCodeIbges,
        [Description("https://desafiobaltaibge.azurewebsites.net/v1/ibges/id")]
        DeleteIbges
        #endregion
    }
}
