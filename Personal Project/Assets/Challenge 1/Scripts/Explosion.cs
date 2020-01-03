using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private int timer;
    public int maxSize = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        transform.localScale += new Vector3(1, 1, 1);
        if (timer == maxSize)
        {
            Destroy(gameObject);
        }
    }
}
