using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class RestClient
{
    public static async Task<string> Get(string url, string token, Action errorHandllingAction)
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        //header
        request.SetRequestHeader("Accept", "application/json");
        request.SetRequestHeader("Authorization", "Bearer " + token);
#if UNITY_EDITOR
     //   request.SetRequestHeader("x-device-id", SystemInfo.deviceUniqueIdentifier); // get from android

#else
       // request.SetRequestHeader("x-device-id", FP11.GameData.deviceId); // get from android
#endif
        //calling
        await request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            errorHandllingAction?.Invoke();
            Debug.Log("[RestClient] " + request.error);
            //Debug.Log("[RestClient] " + request.downloadHandler.text);
        }
        Debug.Log("[RestClient] " + request.downloadHandler.text);
        if (JsonUtility.FromJson<WebResponse>(request.downloadHandler.text).IsUnauthorized())
        {
            errorHandllingAction?.Invoke();
            //SceneLoader.Instance.Logout();
        }
        return request.downloadHandler.text;
    }

    public static async Task<WebResponse> Get(string url)
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        //header
        request.SetRequestHeader("Accept", "application/json");
        //calling
        await request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("[RestClient] " + request.error);
            //Debug.Log("[RestClient] " + request.downloadHandler.text);            
        }
        Debug.Log("[RestClient] " + request.downloadHandler.text);
        if (JsonUtility.FromJson<WebResponse>(request.downloadHandler.text).IsUnauthorized())
        {
            //SceneLoader.Instance.Logout();
        }
        return JsonUtility.FromJson<WebResponse>(request.downloadHandler.text);
    }

    public static async Task<string> Post(string url, string token, Dictionary<string, string> form)
    {
        UnityWebRequest request = UnityWebRequest.Post(url, form);
        //header
        //request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Accept", "application/json");
        request.SetRequestHeader("Authorization", "Bearer " + token);

        Debug.Log("Token = " + token);
        //calling

        await request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("[RestClient] " + request.error);
            //Debug.Log("[RestClient] " + request.downloadHandler.text);            
        }
        Debug.Log("[RestClient] " + request.downloadHandler.text);
        if (JsonUtility.FromJson<WebResponse>(request.downloadHandler.text).IsUnauthorized())
        {
            // SceneLoader.Instance.Logout();
        }
        return request.downloadHandler.text;
    }

    public static async Task<string> Post(string url, Dictionary<string, string> form)
    {
        Debug.Log("Request url : " + url);
        UnityWebRequest request = UnityWebRequest.Post(url, form);
        //header
        //request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Accept", "application/json");
        //request.SetRequestHeader("Authorization", "Bearer " + token);
        //calling
        await request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("[RestClient] " + request.error);
            //Debug.Log("[RestClient] " + request.downloadHandler.text);
        }
        Debug.Log("[RestClient] " + request.downloadHandler.text);
        if (JsonUtility.FromJson<WebResponse>(request.downloadHandler.text).IsUnauthorized())
        {
            // SceneLoader.Instance.Logout();
        }

        return request.downloadHandler.text;
    }

    public static async Task<string> Post(string url, string token, WWWForm form)
    {
        UnityWebRequest request = UnityWebRequest.Post(url, form);
        //header
        //request.SetRequestHeader("Content-Type", "application/json");
        request.SetRequestHeader("Accept", "application/json");
        request.SetRequestHeader("Authorization", "Bearer " + token);
        //calling
        await request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log("[RestClient] " + request.error);
            //Debug.Log("[RestClient] " + request.downloadHandler.text);            
        }
        Debug.Log("[RestClient] " + request.downloadHandler.text);
        if (JsonUtility.FromJson<WebResponse>(request.downloadHandler.text).IsUnauthorized())
        {
            // SceneLoader.Instance.Logout();
        }
        return request.downloadHandler.text;
    }
}
