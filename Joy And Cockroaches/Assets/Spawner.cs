using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float DelaySpawn;

    public float DelaySpawnCurrent;

    public GameObject Kecoa;

    public Waypoint waypoint;

    public Transform positionSpawn;

    public int BatasSpawn;

    public float speed;

    public StartEndGame DaftarKecoak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BatasSpawn >= 1){
            if (DelaySpawnCurrent < 0)
            {
                GameObject KecoaGaming = Instantiate(Kecoa, positionSpawn.position, positionSpawn.rotation);

                KecoaGaming.GetComponent<CockJalan>().waypoint = waypoint;
                KecoaGaming.GetComponent<CockJalan>().Speed = speed;

                DelaySpawnCurrent = DelaySpawn;

                DaftarKecoak.KecoaDaftar.Add(KecoaGaming);
            }
            else
            {
                DelaySpawnCurrent -= Time.deltaTime;
            }
        }
       
        

    }
}
