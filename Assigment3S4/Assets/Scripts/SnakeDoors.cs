using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SnakeDoors : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public AudioClip clip;
    AudioSource audioSource;
    void Start()
    {
        anim = this.transform.parent.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("isOpening", true);
            PlaySound();
            close();
        }
    }

        void PlaySound()
    {
        audioSource.PlayOneShot(clip);
    }
    private async void close()
    {
        await Task.Delay(1000);
        anim.SetBool("isOpening", false);
    }
}
