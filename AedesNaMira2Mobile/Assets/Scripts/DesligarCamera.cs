using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesligarCamera : MonoBehaviour {
	public Camera camera,HUD;
    public bool VR;
	public float time=0;
    public Image image;
    public byte value = 0;
    // Use this for initialization
    void Start () {
        if (VR==false)
        {
            image = GameObject.FindGameObjectWithTag("visao").GetComponent<Image>();
            image.color = new Color32(0, 0, 0, 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time < 1.5f) {
            if (VR)
            {
                camera.clearFlags = CameraClearFlags.SolidColor;
                camera.cullingMask = 0;
            }
            else {
                value = 0;
                if (time > 0.1f && time < 0.2f)
                {
                    value = 21;
                }else  if (time > 0.2f && time < 0.3f)
                {
                    value = 42;
                }
                else if (time > 0.3f && time < 0.4f)
                {
                    value = 63;
                }
                else if (time > 0.4f && time < 0.5f)
                {
                    value = 84;
                }
                else if (time > 0.5f && time < 0.6f)
                {
                    value = 105;
                }
                else if (time > 0.7f && time < 0.8f)
                {
                    value = 116;
                }
                else if (time > 0.8f && time < 0.9f)
                {
                    value = 137;
                }
                else if (time > 0.9f && time < 1)
                {
                    value = 158;
                }
                else if (time > 1 && time < 1.1f)
                {
                    value = 179;
                }
                else if (time > 1.1f && time < 1.2f)
                {
                    value = 200;
                }
                else if (time > 1.2f && time < 1.3f)
                {
                    value = 221;
                }
                else if (time > 1.3f && time < 1.4f)
                {
                    value = 242;
                }
                else if (time > 1.4f && time < 1.5f)
                {
                    value = 255;
                }
                image.color= new Color32(0, 0, 0, value);
            }
		} else if (time > 1.5f && time < 3) {
            if (VR)
            {
                camera.clearFlags = CameraClearFlags.Skybox;
                camera.cullingMask = -1;
            }
            else {
                value = 255;
                if (time > 1.5f && time < 1.6f)
                {
                    value = 255;
                }
                else if (time > 1.5f && time < 1.6f)
                {
                    value = 234;
                }
                else if (time > 1.6f && time < 1.7f)
                {
                    value = 213;
                }
                else if (time > 1.7f && time < 1.8f)
                {
                    value = 192;
                }
                else if (time > 1.8f && time < 1.9f)
                {
                    value = 171;
                }
                else if (time > 1.9f && time < 2)
                {
                    value = 150;
                }
                else if (time > 2.1f && time < 2.2f)
                {
                    value = 129;
                }
                else if (time > 2.3f && time < 2.4f)
                {
                    value = 108;
                }
                else if (time > 2.4f && time < 2.5f)
                {
                    value = 87;
                }
                else if (time > 2.5f && time < 2.6f)
                {
                    value = 66;
                }
                else if (time > 2.6f && time < 2.7f)
                {
                    value = 45;
                }
                else if (time > 2.7f && time < 2.8f)
                {
                    value = 24;
                }
                else if (time > 2.8f && time < 2.9f)
                {
                    value = 3;
                }
                else if (time > 2.9f && time < 3)
                {
                    value = 0;
                }
                image.color = new Color32(0, 0, 0, value);
            }
		} else {
			time = 0;
		}
	}
}
