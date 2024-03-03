using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBorder = 30;
    private float _lowBorder = -30;

    // Update is called once per frame
    void Update()
    {
        //if an object past the player veiw in the game -> remove that object
        if(transform.position.z > _topBorder)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _lowBorder)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
