using BF.Common;
using IdentityModel.Client;
using Microsoft.Extensions.Logging;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;

namespace BF.OpenIDConnectClient
{
    public class OpenIDClient
    {

        public string UrlServerBase { get; private set; }
        private HttpClient _httpClient;
        private DiscoveryDocumentResponse _document;
        private TokenResponse _token;
        private DateTime _tokenExpiration = DateTime.MinValue;
        private ILogger _logger;

        public string GrantType { get; private set; } = "client_credentials";
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public OpenIDClient(string server, string clientId, string clientSecret, ILogger logger)
        {
            this.UrlServerBase = server;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;

            _logger = logger;
            _httpClient = new HttpClient();

            _logger.LogDebug($"... creando OpenIDClient: {server}");
        }

        public ServiceResponse<DiscoveryDocumentResponse> GetDiscoveryDocument()
        {
            var sr = new ServiceResponse<DiscoveryDocumentResponse>();

            if (_document == null || _document.IsError)
            {

                var taskDisco = _httpClient.GetDiscoveryDocumentAsync(new DiscoveryDocumentRequest
                {
                    Address = this.UrlServerBase,
                    Policy = new DiscoveryPolicy
                    {
                        RequireHttps = false
                    }
                });

                taskDisco.Wait();

                _document = taskDisco.Result;
            }

            return new ServiceResponse<DiscoveryDocumentResponse>
            {
                Data = _document
            };
        }

        public ServiceResponse<TokenResponse> GetToken()
        {
            var sr = new ServiceResponse<TokenResponse>();

            if (_token == null || _tokenExpiration < DateTime.Now)
            {
                var srDisco = this.GetDiscoveryDocument();

                if (!sr.Attach(srDisco).Status)
                    return sr;

                if (srDisco.Data.IsError)
                    sr.AddError(srDisco.Data.Error);

                if (sr.Status)
                {
                    var task = _httpClient.RequestTokenAsync(new TokenRequest
                    {
                        Address = srDisco.Data.TokenEndpoint,
                        GrantType = this.GrantType,
                        ClientId = this.ClientId,
                        ClientSecret = this.ClientSecret
                    });

                    task.Wait();

                    var token = task.Result;

                    if (token.IsError)
                        return sr.AddError($"{token.Error}. {token.ErrorDescription}.");

                    _token = token;

                    if (token.ExpiresIn > 0)
                        _tokenExpiration = DateTime.Now + TimeSpan.FromSeconds(token.ExpiresIn - token.ExpiresIn * 0.1);
                    else
                        _tokenExpiration = DateTime.Now.AddYears(1);

                    sr.Data = _token;
                }
            }
            else
            {
                sr.Data = _token;
            }

            return sr;
        }

        public ServiceResponse<JwtSecurityToken> GetLoggedUser()
        {
            var sr = new ServiceResponse<JwtSecurityToken>();
            var srToken = GetToken();

            if (!sr.Attach(srToken).Status)
                return sr;

            var token = srToken.Data.AccessToken;
            var handler = new JwtSecurityTokenHandler();

            sr.Data = handler.ReadJwtToken(token);

            return sr;
        }
    }
}
