using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public int numberBall = 1;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject ballSpawn;
 
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        Instantiate(ballPrefab, ballSpawn.transform.position, Quaternion.identity, transform);
    }
    
    public void LoseBall()
    {
        numberBall --;
        if (numberBall > 0)
        {
            SpawnBall();
        }
        else
        {
            //Game Over
        }
    }
}
