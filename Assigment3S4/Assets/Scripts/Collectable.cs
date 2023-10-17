using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,45f*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject[] Collectables = GameObject.FindGameObjectsWithTag("Collectable");
        if(other.CompareTag("Player")){
            Destroy(gameObject);
        }
        if(Collectables.Length-1 <= 0){
            print("All coins collected!");
            SceneManager.LoadScene("GameOver");
        }
    }
}
