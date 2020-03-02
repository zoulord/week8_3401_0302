using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour
{


    public GameObject blockPrefab;
    public Text scoreText;
    public Text highScoreText;

    int currentScore = 0;

    [HideInInspector]
    public bool hasLost;

    private void Start()
    {
        int highScore
    }



    public void SpawnBlock()
    {
        Invoke("InstantiateBlock", 1);
    }

    void InstantiateBlock()
    {
        if (!hasLost)
        {
            float xSpawnPosition = Random.Range(-8, 8);
            Vector3 spawnPosition = new Vector3(xSpawnPosition, 5.5f, 0);

            Instantiate(blockPrefab, spawnPosition, Quaternion.identity);
            currentScore += 1;
            scoreText.text = currentScore.ToString();

            int HighScore = PlayerPrefs.GetInt("highScore, 0");
            if (currentScore > highScore)
            {
                PlayerPrefs.SetInt("highScore", currentScore);
            }

        }
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
