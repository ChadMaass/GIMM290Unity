using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            // Generate a random height
            float randomHeight = Random.Range(1.75f, 2.25f);
            // Set the enemy's scale to the random height
            enemy.transform.localScale = new Vector3(1, randomHeight, 1);
            enemy.transform.position = new Vector3(0, (randomHeight / 2), 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
            // Generate a random color
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            // Set the enemy's color to the random color
            enemy.GetComponent<Renderer>().material.color = randomColor;
        }
    }
}
