using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio.volume = 0.5f;
        audio.Play();
    }

    void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
