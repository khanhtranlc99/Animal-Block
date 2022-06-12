using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Spine.Unity;
public class Loading : MonoBehaviour
{
    public SkeletonGraphic skeletonGraphic;
    void Start()
    {

        skeletonGraphic.SetAnimation("animation", false, delegate { LoadA("MainScene"); }) ;



    }

    public void LoadA(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }





}
