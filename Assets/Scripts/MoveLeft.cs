using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10.0f;
    [SerializeField] private PlayerController playerController;
    private float leftBound = -10.0f;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!playerController.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (gameObject.CompareTag("Obstacle") && transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
