using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    public Transform leftBoundary;
    public Transform rightBoundary;

    public float moveSpeed;

    bool isMovingRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (isMovingRight)
        {
            // move block right
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // if we're too far to the right, turn around
            if (transform.position.x > rightBoundary.position.x)
            {
                isMovingRight = false;
            }

        }
        else
        {
            // move block left
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            if (transform.position.x < leftBoundary.position.x)
            {
                isMovingRight = true;
            }
        }
    }
}
