using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private Bus bus;
    // Start is called before the first frame update
    void Start()
    {
       
        if (transform.parent.gameObject != null)
            Debug.Log("pap� � viv");
        else Debug.Log("pap� � muort");
        if (transform.parent.parent.gameObject != null)
            Debug.Log("o nonn � viv");
        else Debug.Log("o nonn � muort");
        bus = transform.parent.transform.parent.GetComponent<Bus>();
       
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "StopTrigger")
        {
            Debug.Log("Firmt");
            bus.isMooving = false;
            bus.GetComponent<PathFollower>().speed = 0;
        }
    }
    }
