using System;
using UnityEngine;
using UnityEngine.Networking;

public class LogToRemote : MonoBehaviour {

    public string logUrl;

    // Use this for initialization
    void Start () {
        Application.logMessageReceived += OnLog;
    }

    private void OnLog(string logString, string stackTrace, LogType type)
    {
        DateTime date = DateTime.Now;
        string message = date.ToString() + " " + type.ToString() + ": " + logString + "\nTraceback: " + stackTrace;
        Send(message);
    }

    private async void Send(string message)
    {
        UnityWebRequest www = UnityWebRequest.Post(logUrl, message);
        www.SendWebRequest();
    }
}
