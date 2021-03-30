using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
   public float speedHorizontale = 5f;  //bepalen snelheid links-rechts
    public float speedVertical = 5f;  //bepalen snelheid boven onder

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speedHorizontale * Time.deltaTime;
        transform.position += transform.up * speedVertical * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            speedHorizontale *= -1;
            speedVertical *= -1;
        }
    }
}
