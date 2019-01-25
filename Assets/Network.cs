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
    
    public List<NetworkNode> nodes = new List<NetworkNode>(0);

}
