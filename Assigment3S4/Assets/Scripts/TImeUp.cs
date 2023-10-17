using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TImeUp : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject snakes;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    void Update()
       {
           if(Time.timeSinceLevelLoad >=5f)
            {
                gameObject.SetActive(false);
                snakes.SetActive(true);
            }
        }
}
