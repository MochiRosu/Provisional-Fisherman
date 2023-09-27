using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Harpoon : MonoBehaviour
{
    public float moveSpeed;
    public GameObject deadPrefab;
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(deadPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            score.UpdateScore(50);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Barrier")
        {
            Destroy(gameObject);
        }
    }
}
