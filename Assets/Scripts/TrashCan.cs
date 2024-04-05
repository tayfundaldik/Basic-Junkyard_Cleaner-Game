using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >15){
            transform.position = new Vector3(transform.position.x,transform.position.y,15);
        }
        if(transform.position.z <-15){
            transform.position = new Vector3(transform.position.x,transform.position.y,-15);
        }
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Junk")){
            Destroy(other.gameObject);
        }
    } 
}
