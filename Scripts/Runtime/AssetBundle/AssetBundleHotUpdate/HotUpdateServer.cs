using Cofdream.AssetBuild;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotUpdateServer : MonoBehaviour
{
    private static HotUpdateServer instance;
    public static HotUpdateServer I => instance;

    static HotUpdateServer()
    {
        instance = new GameObject("HotUpdateServer").AddComponent<HotUpdateServer>();
    }

    void Update()
    {

    }

    public static void GetHotUpdateAssetInfo(AssetBundleBuildData assetBundleBuildData, RuntimePlatform platform)
    {
        string rootPath = @"E:\Git\UnityBaseFramework\BuildAssetBundle\StandaloneWindows64";

        AssetBundleBuildData assetBundleBuildDataServer = JsonUtility.FromJson<AssetBundleBuildData>(rootPath + "/AssetBundleBuildData.json");

        //�Ƚ�
        /*
           �յ� ��Դ�������� ��ȡ�����°汾 ��ȡ����İ汾
    ����
        �Ƿ���Ҫ������Դ
        ��Ҫ���µ���Դ��С
         */
    }

}

