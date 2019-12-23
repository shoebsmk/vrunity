using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Jump : MonoBehaviour
{
    public Vector3 temp;
    public Vector3 obsPos;
    public Vector3 offSet = new Vector3(-1, -1, -1);
    public static Jump instance;
    private float step = 0.1f;
    private float distance;
    [SerializeField]
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    public void move()
    {
        obsPos = GvrReticlePointer.instance.getObPos();
        distance = GvrReticlePointer.instance.getObDistance();
        //   temp = obsPos;
        //   temp -= offSet;
        //  transform.position = temp;
        navMeshAgent.destination = obsPos;
    }
        
}
