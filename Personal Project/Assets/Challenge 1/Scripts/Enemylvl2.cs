using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylvl2 : MonoBehaviour
{
    public GameObject player;
    public float range;
    public float speed;

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
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
}
