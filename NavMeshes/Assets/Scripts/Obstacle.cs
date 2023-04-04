using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5;
    public bool right = true;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > 9)
        {
            right = false;
        } 
        else if (this.transform.position.x < -9)
        {
            right = true;
        }

        if (right)
        {
            this.transform.position = new Vector3(this.transform.position.x + speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        else
        {
            this.transform.position = new Vector3(this.transform.position.x - speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
    }
}
