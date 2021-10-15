using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CofdreamEditor.AssetBundle
{
    public sealed class FolderBuildRule : ScriptableObject, IBuildRule
    {
        public Object AssetFolder;

        public void CreateAssetBundleBuild(CreateCallback createCallback)
        {
            string path = AssetDatabase.GetAssetPath(AssetFolder);

            createCallback(new AssetBundleBuild()
            {
                assetBundleName = BuildRuleUtil.PathToAssetBundleName(path),
                assetNames = new string[] { path },
            });
        }

        private void OnValidate()
        {
            if (AssetFolder != null)
            {
                string path = AssetDatabase.GetAssetPath(AssetFolder);
                if (AssetDatabase.IsValidFolder(path) == false)
                {
                    EditorUtility.DisplayDialog("����", "�����ļ���·��", "ȷ��");
                }
            }
        }
    }
}