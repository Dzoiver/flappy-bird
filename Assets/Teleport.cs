using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    Vector3 vect = new Vector3(0, 0, 15);
    [SerializeField] GameObject lastWall;
    [SerializeField] GameObject beforeLastWall;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = lastWall.transform.position.x - beforeLastWall.transform.position.x;
    }
    private void OnTriggerEnter(Collider other)
    {
        vect.y = Random.Range(-5f, 5f);
        vect.x = distance * 6 + other.transform.position.x;
        other.transform.position = vect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
