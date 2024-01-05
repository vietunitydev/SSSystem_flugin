using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : SSController
{
    public void OnPopupButtonClick()
    {
        SSSceneManager.Instance.PopUp("Popup", "Nav Mesh",
            ctrl =>
            {
                ((Popup)ctrl).OnOkButtonTap += OnPopupOkButtonTap;
                Debug.LogWarning("CTRL : " + ctrl);
            },
            ctrl =>
            {
                ((Popup)ctrl).OnOkButtonTap -= OnPopupOkButtonTap;
                Debug.LogWarning("CTRL : " + ctrl);
            });
    }

    void OnPopupOkButtonTap()
    {
        SSSceneManager.Instance.Screen("Navmesh");
    }

}
