using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylvl1AI : MonoBehaviour
{
    public GameObject player;
    public float range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);

        if (dist <= range)
        {
            transform.LookAt(player.transform.position);
        }

    }
}
