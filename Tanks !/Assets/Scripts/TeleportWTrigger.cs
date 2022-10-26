using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWTrigger : MonoBehaviour
{
    public Transform destination;


    public void Teleport(Transform target)
    {
        target.position = destination.position;
        target.rotation = destination.rotation;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.isTrigger == false)
            Teleport(other.transform);

    }





}




