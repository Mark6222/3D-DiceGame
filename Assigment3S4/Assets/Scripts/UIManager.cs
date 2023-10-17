using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    Animator animator;
    void Start()
    {
     animator = GetComponent<Animator>();
    }

    public void Open()
    {
        animator.SetBool("Opening", true);
    }
    public async void StartGame()
    {
        await Task.Delay(800);
        SceneManager.LoadScene("Indoor");
    }

   public void MainMenu()
   {
	   SceneManager.LoadScene("Landing");
   }

   public void RetryGame()
   {
	   SceneManager.LoadScene("Indoor");
   }
}
