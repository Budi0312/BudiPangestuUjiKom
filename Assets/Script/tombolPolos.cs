using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tombolPolos : MonoBehaviour
{
public bool sedangPutar;
    public AudioSource sfxPlay;
    //public AudioSource sfxCredit;
    public AudioSource sfxExit;
    public AudioSource sfxMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aksiPlay()
    {
        StartCoroutine(TungguSuara());
        //sfxPlay.Play();
        SceneManager.LoadScene("GamePlay");
    }

    public void aksiCredit()
    {
        //sfxCredit.Play();
        SceneManager.LoadScene("Credit");
    }

    public void aksiExit()
    {
        sfxExit.Play();
        Application.Quit();
    }
    public void aksiMenu()
    {
         sfxMenu.Play();
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator TungguSuara()
    {
        sedangPutar=true;
        putarSuara();
        yield return new WaitWhile (()=>sedangPutar);
       
    }

    public void putarSuara()
    {
        sfxPlay.Play();
         Debug.Log("Tunggu");
        sedangPutar =false;
    }
}
