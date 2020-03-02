using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorCollisionDetection : MonoBehaviour
{
    public BlockSpawner blockSpawner;
    int collisionCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        collisionCount += 1;
        Debug.Log("test");
        if (collisionCount > 1)
        {
            Debug.Log("Lost");
            blockSpawner.hasLost = true;

            SceneManager.LoadScene("SampleScene");
        }
    }
}
