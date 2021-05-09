using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Agent : MonoBehaviour
{
    // Start is called before the first frame update
    AIDestinationSetter destinationSetter;
    public Pullman pullman;
  
    void Start()
    {
        destinationSetter = GetComponent<AIDestinationSetter>();

        if (!pullman.isMooving && pullman.freeTarget() != null)
            setDestination(pullman.freeTarget());
    }

    // Update is called once per frame
    void Update()
    {


        }

    public void setDestination(Target t){
        destinationSetter.target=t.transform;
        t.isOccupied=true;
    }
}
