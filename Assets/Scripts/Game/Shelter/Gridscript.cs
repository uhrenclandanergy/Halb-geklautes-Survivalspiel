using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUhrenBehaviour
{
    void Setup();
    void Reset();
}

public class Gridscript : MonoBehaviour, IUhrenBehaviour
{
    int widht = 18;
    int height = 10;

    public void Setup()
    {
        GameObject Grid = new GameObject("Grid");
        Grid.transform.position = new Vector2(-(widht / 2) + 0.5f, -(height / 2) + 0.5f);

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < widht; x++)
            {
                GameObject currentGridclone = new GameObject(x.ToString() + ";" + y.ToString());
                currentGridclone.transform.parent = Grid.transform;
                currentGridclone.transform.localPosition = new Vector2(x, y);
                BoxCollider BC = currentGridclone.AddComponent<BoxCollider>();
                currentGridclone.AddComponent<BoxScriptAuswahl>();
                BC.size = new Vector3(1, 1, 1);
            }
        }
    }

    public void Reset()
    {

    }
}
