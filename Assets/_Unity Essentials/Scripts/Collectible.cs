using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update



    public float rotationSpeed;
    
    public GameObject onCollectEffect;





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        transform.Rotate (0, rotationSpeed, 0);
    
    }


/// <summary>
/// OnTriggerEnter is called when the Collider other enters the trigger.
/// </summary>
/// <param name="other">The other Collider involved in this collision.</param>
private void OnTriggerEnter(Collider other)
{


    //destroy the collectible


    Destroy(gameObject);

    
}


}
