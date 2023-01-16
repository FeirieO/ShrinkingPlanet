   using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FpsDisplay : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    public float pollingTime = 1f; //how frequently the fps display will update

    private float time;
    private int frameCount;

    void Update()
    {
        time += Time.unscaledDeltaTime;
        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = frameCount.ToString() + " FPS";

            //Reset!
            time -= pollingTime;
            frameCount = 0;
        }
    }
}
