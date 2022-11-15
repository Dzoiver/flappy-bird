using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Restart : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Playerscript player;
    [SerializeField] WallController walls;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    public void RestartButton()
    {
        panel.SetActive(false);
        player.transform.position = player.InitPos;
        walls.Gameover = false;
        player.ResetScore();
        walls.ResetPos();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
