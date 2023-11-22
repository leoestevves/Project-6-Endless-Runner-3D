using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleObstacle : MonoBehaviour
{
    GameManager _GameManager;

    // Start is called before the first frame update
    void Start()
    {
        _GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _GameManager.AddScore(1);
        }
    }
}
