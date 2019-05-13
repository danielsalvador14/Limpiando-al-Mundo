using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamingDelVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videpPlayer;
    public AudioSource audioSource;
    public bool EstamosEnVideo = false;

    public void CambiarStatus(bool estado)
    {
        EstamosEnVideo = estado;
        if (EstamosEnVideo)
        {
            StartCoroutine(PlayVideo());
        }
    }
    void Start()
    {
        /*if (EstamosEnVideo)
        {
            StartCoroutine(PlayVideo());
        }
        */

    }


    IEnumerator PlayVideo()
    {
        videpPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videpPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videpPlayer.texture;
        videpPlayer.Play();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
