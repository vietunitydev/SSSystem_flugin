using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : SSController
{
    public delegate void OnOkButtonTapDelegate();
    public OnOkButtonTapDelegate OnOkButtonTap;

    [SerializeField] Text m_Title;


    public void OnOKButtonClick()
    {
        SSSceneManager.Instance.Close();

        if (OnOkButtonTap != null)
        {
            OnOkButtonTap();

            Debug.LogWarning(OnOkButtonTap);
        }
    }

    public override void OnSet(object data)
    {
        string title = (string)data;
        m_Title.text = title;
    }


}
