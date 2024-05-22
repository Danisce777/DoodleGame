using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Doodle;
    public GameObject platformPreSub;
    public GameObject springPreFab;
    private GameObject myPlat;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 7) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(springPreFab, new Vector2(Random.Range(-10.5f, 10.5f), Doodle.transform.position.y + (14 + Random.Range(0.2f, 1f))), Quaternion.identity);


            }
            else 
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), Doodle.transform.position.y + (14 + Random.Range(0.2f, 1f)));
            
            }

        } else if (collision.gameObject.name.StartsWith("Spring")) 
        {
            if (Random.Range(1, 7) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-10.5f, 10.5f), Doodle.transform.position.y + (14 + Random.Range(0.2f, 1f)));


            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPreSub, new Vector2(Random.Range(-10.5f, 10.5f), Doodle.transform.position.y + (14 + Random.Range(0.2f, 1f))), Quaternion.identity);


            }

        }

    }

}
