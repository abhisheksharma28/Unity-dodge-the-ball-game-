
using UnityEngine;

public class playercollison : MonoBehaviour {

    public playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obs")
        {
            movement.enabled = false;

            FindObjectOfType<gamemanage>().EndGame();
        }
    }
}
