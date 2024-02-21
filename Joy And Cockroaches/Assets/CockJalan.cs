using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockJalan : MonoBehaviour
{

    public Waypoint waypoint;

    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint.transform.position, Speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, waypoint.transform.position) < 0.1f)
        {
            if (waypoint.waypoint == null)
            {

                Destroy(gameObject);

            } else
            {
                waypoint = waypoint.waypoint;
            }
           
        }

        
    }
}
