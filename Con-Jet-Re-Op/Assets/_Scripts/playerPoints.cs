using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerPoints : MonoBehaviour {

    public Text pointA;
    public Text pointB;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PointA"))
        {
            if (this.CompareTag("RedPlayer"))
            {
                pointA.text = "Point A: Red";
            }

            else if(this.CompareTag("BluePlayer"))
            {
                pointA.text = "Point A: Blue";
            }
        }else if (other.CompareTag("PointB"))
        {
            if (this.CompareTag("RedPlayer"))
            {
                pointB.text = "Point B: Red";
            }

            else if (this.CompareTag("BluePlayer"))
            {
                pointB.text = "Point B: Blue";
            }
        }
    }
}
