using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public float magnetForce = 100;
    List<Rigidbody> rigList = new List<Rigidbody>();

    private void FixedUpdate()
    {
        for (int i = 0; i < rigList.Count; i++)
        {
            rigList[i].velocity= (transform.position - (rigList[i].transform.position + rigList[i].centerOfMass)) * magnetForce * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Rigidbody>().gameObject.tag=="olive")
        {
            Rigidbody rig = collider.GetComponent<Rigidbody>();
            if (!rigList.Contains(rig))
            {                
                rigList.Add(rig);
            }
            //rig.constraints = RigidbodyConstraints.FreezeAll;
            //rig.isKinematic = true;
        }
    }
}
