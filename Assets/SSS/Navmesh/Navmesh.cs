using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navmesh : SSController
{
    public void OnBackButtonClick()
    {
        SSSceneManager.Instance.Screen("Scene1");
    }

}
