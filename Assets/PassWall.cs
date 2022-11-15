using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassWall : MonoBehaviour
{
    [SerializeField] Text number;
    int scoreplus = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        int previousScore = int.Parse(number.text + scoreplus);
        number.text = previousScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
