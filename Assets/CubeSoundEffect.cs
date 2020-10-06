using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundEffect : MonoBehaviour
{
    private GameObject ground;
    private
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    void OnCollisionEnter2D(Collision2D other)
    { 
        
        if (other.gameObject.tag == "GroundTag" || this.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }

    }
}
