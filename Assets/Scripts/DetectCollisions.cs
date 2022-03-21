using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
            gameObject.SetActive(false);
        }
    }

}
