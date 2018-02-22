using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class BoxScriptAuswahl : PunBehaviour, IUhrenBehaviour {


    public void Setup()
    {

    }

    public void Reset()
    {

    }

    
    public void OnMouseDown()
    {
        GameObject kleinerCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        PhotonView PV = kleinerCube.AddComponent<PhotonView>();
        PV.ObservedComponents = new List<Component>();
        PV.ObservedComponents.Add(kleinerCube.transform);
        kleinerCube.transform.parent = gameObject.transform;
        kleinerCube.transform.localPosition = new Vector2(0, 0);
        print("pressed");
    }
}
