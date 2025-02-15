using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject target; 
    private void LateUpdate()
    {
    
        GameObject[] targets = GameObject.FindGameObjectsWithTag("word");

        if (targets.Length > 0)
        {
            target = targets[0];
            float closestDistance = Vector3.Distance(transform.position, target.transform.position);

            foreach (GameObject obj in targets)
            {
                float distance = Vector3.Distance(transform.position, obj.transform.position);
                if (distance < closestDistance)
                {
                    target = obj;
                    closestDistance = distance;
                }
            }
        }
    }

    private void Update()
    {
        if (target != null) 
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.transform.position, 
                20 * Time.deltaTime
            );
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("word"))
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
