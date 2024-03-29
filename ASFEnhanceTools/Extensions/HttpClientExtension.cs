﻿using ASFEnhanceTools.Data;

using System.Diagnostics;
using System.Text.Json;

namespace ASFEnhanceTools.Extensions
{
    /// <summary>
    /// HttpClient扩展
    /// </summary>
    public static class HttpClientExtension
    {
        internal static async Task<AbstractResponse?> SendToObj(this HttpClient httpClient, HttpRequestMessage message)
        {
            try
            {
#if DEBUG
                Debug.WriteLine(message.Content?.ToString());
#endif
                var response = await httpClient.SendAsync(message);
                var result = await ParseTpObj(response);
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        internal static async Task<T?> SendToObj<T>(this HttpClient httpClient, HttpRequestMessage message) where T : AbstractResponse
        {
            try
            {

#if DEBUG
                Debug.WriteLine(message.Content?.ToString());
#endif
                var response = await httpClient.SendAsync(message);
                var result = await ParseTpObj<T>(response);
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        internal static async Task<T?> ParseTpObj<T>(HttpResponseMessage response) where T : AbstractResponse
        {
            try
            {
                var json = await response.Content.ReadAsStringAsync();
#if DEBUG
                Debug.WriteLine(json);
#endif
                var obj = JsonSerializer.Deserialize<T>(json);
                return obj;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        internal static async Task<AbstractResponse?> ParseTpObj(HttpResponseMessage response)
        {
            try
            {
                var json = await response.Content.ReadAsStringAsync();
#if DEBUG
                Debug.WriteLine(json);
#endif
                var obj = JsonSerializer.Deserialize<AbstractResponse>(json);
                return obj;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }
    }
}
