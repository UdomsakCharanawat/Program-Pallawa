using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;


public class SaveCard : MonoBehaviour
{
    public int resWidth;
    public int resHeight;

    //private bool takHiResShot = false;

    public Camera camera;

    public string pathSave;

    public GameObject[] disable;
    public bool save;

    public CanvasScaler canvasScaler;
    public float height, width, setHeight, setWidth;

    //public static string ScreenShotName(int width, int height, string path)
    public static string ScreenShotName(int width, int height, string path)
    {
        return string.Format("{0}/screen_{1}x{2}_{3}.png",
            path, width, height,
            System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }

    public void TakeHitResShot()
    {
        //disable[0].SetActive(false);
        //disable[1].SetActive(false);
        //disable[2].SetActive(false);

        for(int i = 0; i < disable.Length; i++)
        {
            disable[i].SetActive(false);
        }

        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = new Color(0, 0, 0, 0);

        //canvasScaler.referenceResolution = new Vector2(setWidth, setHeight);

        Directory.CreateDirectory(pathSave);

        save = true;
        
    }

    private void Update()
    {
        if (save)
        {
            string filename = ScreenShotName(resWidth, resHeight, pathSave);
            ScreenCapture.CaptureScreenshot(filename);
            save = false;
        }
        else
        {
            //canvasScaler.referenceResolution = new Vector2(width, height);

            //disable[0].SetActive(true);
            //disable[1].SetActive(true);
            //disable[2].SetActive(true);

            for (int i = 0; i < disable.Length; i++)
            {
                disable[i].SetActive(true);
            }
        }
    }
}
