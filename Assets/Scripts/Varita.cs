using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Varita : MonoBehaviour
{
    private SFXManager sfxManager;
    private BGMManager bgmManager;
    
    // Start is called before the first frame update
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Witch"))
        {
            sfxManager.VaritaSound();
            bgmManager.StopBGM();
            Invoke("LoadEndScreen", 1);
        }
    }

    private void LoadEndScreen()
    {
        SceneManager.LoadScene("Pantalla de victoria"); 
    }

}
