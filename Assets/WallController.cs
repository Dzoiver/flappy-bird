using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField] Transform[] walls;
    [SerializeField] GameObject teleporter;
    float speed = 2f;
    public bool Gameover = false;
    Vector3 vect = new Vector3();
    Vector3 movevect = new Vector3(5, 0, 0);
    Vector3[] vectors = new Vector3[6];

    int length;
    // Start is called before the first frame update
    void Start()
    {
        length = walls.Length;
        for (int i = 0; i < walls.Length; i++)
        {
            vectors[i] = walls[i].position;
        }
    }

    public void ResetPos()
    {
        for (int i = 0; i < walls.Length; i++)
        {
            // vect.x = 5 * i;
            // vect.y = Random.Range(-5f, 5f);
            // vect.z = 15;
            walls[i].position = vectors[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Gameover)
            return;
        for (int i = 0; i < walls.Length; i++)
        {
            vect = walls[i].position;
            vect.x -= speed * Time.deltaTime;
            walls[i].position = vect;
        }
    }
}
