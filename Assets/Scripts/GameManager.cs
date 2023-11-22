using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    public float obstacleSpawnFirstRange;
    public float obstacleSpawnLastRange;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(obstacleSpawnFirstRange, obstacleSpawnLastRange);

            yield return new WaitForSeconds(waitTime);
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
        
    }

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp", 2f, 2f);
    }
}
