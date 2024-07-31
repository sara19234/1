using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fyutagun : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //transform
            Vector2 aimDirection = mousePosition - (Vector2)transform.position;

            float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

            Quaternion rotation = Quaternion.Euler(0, 0, angle);

            GameObject spawnedBullet = Instantiate(bullet, transform.position, rotation);
        }
    }
}
