using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ButtonsManager : MonoBehaviour
{
    public RectTransform TargetPanel;
    public Transform Camera;
    public float duration = 1.0f;
    private bool PanelOut = true;
    private bool OriginalAngle = true;

    public void OpenMenu()
    {
        if (PanelOut)
        {
            TargetPanel.DOLocalMove(new Vector3(-642f, 0f, 0f), duration);
        } else
        {
            TargetPanel.DOLocalMove(new Vector3(-1342f, 0f, 0f), duration);
        }

        PanelOut = !PanelOut;

        if (OriginalAngle)
        {
            Camera.DOLocalMove(new Vector3(-647f, 1212f, -869f), duration);
        } else
        {
            Camera.DOLocalMove(new Vector3(0f, 1212f, -869f), duration);
        }

        OriginalAngle = !OriginalAngle; 
    }
}
