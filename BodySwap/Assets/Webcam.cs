using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Webcam : MonoBehaviour
{
    public string webcamName;
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture webCamTexture = new WebCamTexture();
        //Debug.Log(webCamTexture.deviceName);

       // Renderer renderer = GetComponent<Renderer>();
        //renderer.material.mainTexture = webCamTexture;
        //webCamTexture.Play();

         foreach (WebCamDevice device in devices)
        {
            Debug.Log(device.name);
        } 
        if(devices.Length > 0)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = webCamTexture;
            webCamTexture.deviceName = webcamName;
            webCamTexture.Play();
        }

    }

    // Update is called once per frame
    
}
