using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkNode
{
    public int id;
    public List<int> connections;
}


public class Network : MonoBehaviour
{
    public Sprite nodeSprite;
    public LineRenderer line;
    public NetworkNode[] nodes = new NetworkNode[1];

}
