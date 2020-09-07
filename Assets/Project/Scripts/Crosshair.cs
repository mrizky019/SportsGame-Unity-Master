using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        setSize(100f);
    }

    public void setSize(float size)
    {
        if (size > 1)
        {
            size = size / 20f;
        }

        transform.localScale = new Vector3(size, size, size);
    }
}
