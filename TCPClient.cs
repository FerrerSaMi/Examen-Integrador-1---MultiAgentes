using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using UnityEngine;

public class TCPClient : MonoBehaviour
{
    public string host = "127.0.0.1";
    public int port = 5005;

    public GameObject agentCube;

    private TcpClient client;
    private StreamReader reader;

    private float receivedX = 0f;

    void Start()
    {
        Thread t = new Thread(ConnectAndListen);
        t.IsBackground = true;
        t.Start();
    }

    void ConnectAndListen()
    {
        try
        {
            client = new TcpClient(host, port);
            reader = new StreamReader(client.GetStream());

            while (true)
            {
                string line = reader.ReadLine(); 
                if (line != null)
                {
                    float x;
                    if (float.TryParse(line, out x))
                    {
                        receivedX = x;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log("Error TCP: " + e);
        }
    }

    void Update()
    {
        if (agentCube != null)
        {
            agentCube.transform.position = new Vector3(receivedX, 0, 0);
        }
    }
}
