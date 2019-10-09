using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector3 temp;
    public Vector3 obsPos;
    public Vector3 offSet = new Vector3(1, 0, 1);
    public static Jump instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void move()
    {
        obsPos = GvrReticlePointer.instance.getObPos();
        temp = obsPos;
        temp -= offSet;
        transform.position = temp;
    }
}
