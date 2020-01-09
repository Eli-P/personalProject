using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firingBullet : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public float range;
    public float dist;
    public float delay;
    public float delayMax;
    // Start is called before the first frame update
    void Start()
    {
        delayMax = delay;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < range)
        {
            if (delay == 0f)
            {
                Instantiate(bullet, transform.position + new Vector3(0, 0.1f, 3), transform.rotation + Vector3(0,90,0));
                delay = delayMax;
            }
            delay -= 1;
        }
    }
}
