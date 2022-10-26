using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int health = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            TankHealth tankHealth = other.GetComponent<TankHealth>();
            if(tankHealth != null)
            {
                tankHealth.TakeDamage(-health);
            }
            Destroy(gameObject);
        }
    }
}
