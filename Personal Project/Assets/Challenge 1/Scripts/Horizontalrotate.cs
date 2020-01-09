using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Horizontalrotate : MonoBehaviour
{
    public GameObject player;
    public float plyrX;
    //public float plyrY;
    public float plyrZ;
    public float range;
    public float xl;
    public float zl;
    public float rotatepoint;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        plyrX = player.transform.position.x;
        //plyrY = player.transform.position.y;
        plyrZ = player.transform.position.y;
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < range)
        {
            if (gameObject.transform.rotation.z > rotatepoint)
            {
                gameObject.transform.Rotate(Vector3.up, gameObject.transform.rotation.z - rotateSpeed);
            }
            else if (gameObject.transform.rotation.z > rotatepoint)
            {
                gameObject.transform.Rotate(Vector3.up, gameObject.transform.rotation.z + rotateSpeed);
            }


            if(plyrX > gameObject.transform.position.x)
            {
                xl = plyrX - gameObject.transform.position.x;
            }
            else if (plyrX < gameObject.transform.position.x)
            {
                xl = gameObject.transform.position.x - plyrX;
            }
            else
            {
                xl = 0;
            }


            if (plyrZ > gameObject.transform.position.z)
            {
                zl = plyrZ - gameObject.transform.position.z;
            }
            else if (plyrZ < gameObject.transform.position.z)
            {
                zl = gameObject.transform.position.z - plyrZ;
            }
            else
            {
                zl = 0;
            }


            rotatepoint = Mathf.Atan(xl/zl); 
        }
    }
}
