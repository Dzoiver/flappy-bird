using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playerscript : MonoBehaviour
{
    [SerializeField] GameObject gameover;
    float speed = 5f;
    float maxSpeed = 5f;
    Rigidbody _rb;
    float horizontal;
    float vertical;
    Vector3 force = new Vector3(0, 0, 1);
    float jumpAmount = 10f;
    [SerializeField] WallController wall;
    int score = 0;
    int scoreInc = 100;
    Touch theTouch;
    [SerializeField] TextMeshProUGUI scoreNumber;
    public Vector3 InitPos;
    // Start is called before the first frame update
    void Start()
    {
        InitPos = gameObject.transform.position;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wall.Gameover)
            return;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (_rb.velocity.magnitude > maxSpeed)
        {
            _rb.velocity = Vector3.ClampMagnitude(_rb.velocity, maxSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if (theTouch.phase == TouchPhase.Began)
            {
                _rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {
            gameover.SetActive(true);
            wall.Gameover = true;
        }
        if (other.tag == "score")
        {
            score += scoreInc;
            scoreNumber.text = score.ToString();
        }
    }

    public void ResetScore()
    {
        score = 0;
        scoreNumber.text = "0";
    }

    void FixedUpdate()
    {
    }
}
