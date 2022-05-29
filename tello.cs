using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public class tello : MonoBehaviour
{
    string telloip = "192.168.10.1";
    public int send = 8889;
    public int recv = 8890;
    IPEndPoint remoteEP = null;
    public float speed = 10;
    //public IPAddress address = IPAddress.Parse("192.168.10.1"); 

    byte[] data;
    private UdpClient client,recvclient;

    public float mid, x, y, z;
    //public float x, y, z, mid, a;
    // Start is called before the first frame update
    void Start()
    {
        client = new UdpClient();
        recvclient = new UdpClient(recv);
        byte[] command = Encoding.UTF8.GetBytes("command");
        int b = client.Send(command, command.Length, telloip, send);
        byte[] mon = Encoding.UTF8.GetBytes("mon");
        int c = client.Send(mon, mon.Length, telloip, send);

        byte[] go = Encoding.UTF8.GetBytes("go 0 0 0 20 m1");
        int d = client.Send(go, go.Length, telloip, send);
        Debug.Log("set");
        //
        //recvclient.Close();
    }

    void recvdata()
    {
        

    }
    void go(float x,float y , float z)
    {
        //byte[] go = Encoding.UTF8.GetBytes("go "+x+" "+y+" "+z+" "+"20 m1");
        byte[] go = Encoding.UTF8.GetBytes("go 30 30 80 30 m1");
        client.Send(go, go.Length, telloip, send);
        Debug.Log("0");
    }

    public void takeoff()
    {
        byte[] takeoff = Encoding.UTF8.GetBytes("takeoff");
        client.Send(takeoff, takeoff.Length, telloip, send);
        Debug.Log("0");
    }

    public void land()
    {
        byte[] land = Encoding.UTF8.GetBytes("land");
        client.Send(land, land.Length, telloip, send);
    }

    public void up(float x)
    {
        byte[] up = Encoding.UTF8.GetBytes("up " + x);
        client.Send(up, up.Length, telloip, send);
    }

    public void down(float x)
    {
        byte[] down = Encoding.UTF8.GetBytes("down " + x);
        client.Send(down, down.Length, telloip, send);
    }

    public void right(float x)
    {
        byte[] right = Encoding.UTF8.GetBytes("right " + x);
        client.Send(right, right.Length, telloip, send);
    }

    public void left(float x)
    {
        byte[] left = Encoding.UTF8.GetBytes("left " + x);
        client.Send(left, left.Length, telloip, send);
    }

    public void forward(float x)
    {
        byte[] forward = Encoding.UTF8.GetBytes("forward " + x);
        client.Send(forward, forward.Length, telloip, send);
    }

    public void back(float x)
    {
        byte[] back = Encoding.UTF8.GetBytes("back " + x);
        client.Send(back, back.Length, telloip, send);
    }
    public void Speed(float x)
    {
        byte[] Speed = Encoding.UTF8.GetBytes("speed " + x);
        client.Send(Speed, Speed.Length, telloip, send);
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey("1"))
        {
            Task.Run(() =>
            {
                //string status = "";
                IPEndPoint remoteEP = null;//任意の送信元からのデータを受信
                while (true)
                {
                    byte[] rcvBytes = recvclient.Receive(ref remoteEP);
                    //Interlocked.Exchange(ref status, Encoding.ASCII.GetString(rcvBytes));
                    string state = Encoding.ASCII.GetString(rcvBytes);
                    string[] iti = state.Split(';');
                    //Debug.Log("1");


                    //非同期処理内でfor文が使用できないため
                    string[] mids = iti[0].Split(':');
                    string[] xs = iti[1].Split(':');
                    string[] ys = iti[2].Split(':');
                    string[] zs = iti[3].Split(':');
                    //Debug.Log("2");
                    mid = float.Parse(mids[1]);
                    x = float.Parse(xs[1]);
                    y = float.Parse(ys[1]);
                    z = float.Parse(zs[1]);

                    Debug.Log(state);
                }

            });
        }

        if (Input.GetKeyDown("2"))
        {
            left(30);
        }

        if (Input.GetKeyDown("3"))
        {
            right(30);
        }

        if (Input.GetKeyDown("4"))
        {
            forward(30);
        }

        if (Input.GetKeyDown("5"))
        {
            back(30);
        }

        if (Input.GetKey("6"))
        {
           up(30);
        }
        if (Input.GetKey("7"))
        {
            down(30);
        }
        if (Input.GetKeyDown("8"))
        {
            takeoff();
        }
        if (Input.GetKeyDown("9"))
        {
            land();
        }

        if (Input.GetKeyDown("f"))
        {
            recvclient.Close();
        }
    }
}
