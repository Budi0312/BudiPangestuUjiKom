using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
//using Microsoft.Unity.VisualStudio.Editor;
public class timer : MonoBehaviour
{
    public float time = 60f;
    public TMP_Text timerText;
    public bool isCounting = true;
    public objPemain objPemain;

    private Coroutine timerCoroutine;

    public Image ProgressFill;

    private void Start()
    {
        // tampilkan waktu awal
        //timerText.text = "Waktu : " + time.ToString();

        // mulai hitung mundur otomatis
        //timerCoroutine = StartCoroutine(HitungTimer());
    }

    private void Update()
    {
        
    }

   IEnumerator HitungTimer()
    {
        while (isCounting && time > 0)
        {
            yield return new WaitForSeconds(1f);

            time -= 1;
            timerText.text = "Waktu : " + time.ToString();
        }

        // jika waktu habis
        if (time <= 0)
        {
            isCounting = false;
            timerText.text = "Waktu : 0";
            PlayerPrefs.SetInt("skor", objPemain.skor);
            PlayerPrefs.Save();
            objPemain.simpanHightSkor();
            SceneManager.LoadScene("GameOver");
        }
    }

   /* IEnumerator HitungTimer()
    {
        while(isCounting==true && time<time)
        {
            time=time+1;
            //TextTimer.text=Waktu.ToString();
            ProgressFill.fillAmount=time/time;
            yield return new WaitForSeconds(1);
        }

    }*/
}
