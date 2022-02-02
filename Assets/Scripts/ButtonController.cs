using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _popupWindow;
    public void OpenPopup()
    {
        StartCoroutine(ActivePopupWindow());
    }
    public void ClosePopup()
    {
        StartCoroutine(DeactivePopupWindow());
    }

    IEnumerator ActivePopupWindow()
    {
        if(_popupWindow.activeSelf == false)
        {
            _popupWindow.SetActive(true);
            yield return null;
        }
       
    }
    IEnumerator DeactivePopupWindow()
    {
        DestroyAllCircles();
        _popupWindow.SetActive(false);
        yield return null;
    }

    private void DestroyAllCircles()
    {
        CircleMoving[] allCircles;
        allCircles = FindObjectsOfType<CircleMoving>();

        foreach (CircleMoving goCircle in allCircles)
        {
            Destroy(goCircle.gameObject);
        }
    }
}
