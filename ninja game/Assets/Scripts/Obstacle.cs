using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float obstacleInterval = 3f;
    public GameObject panel;

    float nextObstacleTime;

    void Start()
    {
        nextObstacleTime = Time.time + obstacleInterval;
    }
    void Update()
    {
        if (Time.time > nextObstacleTime)
        {
            nextObstacleTime = Time.time + obstacleInterval;
            CreateObstacle();
        }
    }

    GameObject obstacle;

    void CreateObstacle()
    {
        Vector3[] positions = { new Vector3(-8, 0, 0), new Vector3(8, 0, 0) };

        int index = Random.Range(0, positions.Length);
        Vector3 position = positions[index];
        obstacle = Instantiate(obstaclePrefab, position, Quaternion.identity);

        Rigidbody rb = obstacle.GetComponent<Rigidbody>();

        if (index == 0)
        {
            rb.velocity = new Vector3(1, 0, 0) * 6f;
        }
        else
        {
            rb.velocity = new Vector3(-1, 0, 0) * 6f;
        }

        Destroy(obstacle, 3.5f);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(obstacle);
        }
    }

}