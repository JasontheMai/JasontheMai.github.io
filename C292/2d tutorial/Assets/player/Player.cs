using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject _laserPrefab;

    public int _health = 3;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "healthkit")
        {
            if (_health < 3)
            {
                _health++;
            }

            Destroy(collision.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
            Instantiate(_laserPrefab, transform.position, Quaternion.identity);

        Vector3 convertedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(convertedPos.x, transform.position.y, 0);
    
    }
}
