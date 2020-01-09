using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireing : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Instantiate(bullet, transform.position + new Vector3(0, 0.1f, 3), transform.rotation);
        }
    }
}
