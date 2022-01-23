using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{

    void start(){
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/20f;
    }
    void Update()
    {
        if(transform.position.y < -20f){
            Destroy(gameObject);
        }
    }
}
