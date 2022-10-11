using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] GameObject _gameState;

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * _speed, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            if (player._health == 1)
            {
                gameState.Instance.InitiateGameOver();
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            else
            {
                player._health--;
                Destroy(gameObject);
            }
        }
        
        if (collision.gameObject.name != "Player")
        {
            Destroy(collision.gameObject);
        }
        gameState.Instance.IncreaseScore(10);

        Destroy(gameObject);
    }
}
