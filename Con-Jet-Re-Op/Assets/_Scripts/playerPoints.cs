using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoints : MonoBehaviour {
    public GameController gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PointA"))
        {
            if (this.CompareTag("RedPlayer"))
            {
                gameController.changePointARed();
            }

            else if(this.CompareTag("BluePlayer"))
            {
                gameController.changePointABlue();
            }
        }
        else if (other.CompareTag("PointB"))
        {
            if (this.CompareTag("RedPlayer"))
            {
                gameController.changePointBRed();
            }

            else if (this.CompareTag("BluePlayer"))
            {
                gameController.changePointBBlue();
            }
        }
    }
}
