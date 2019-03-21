﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MapSave : MonoBehaviour
{
    public GameObject enemy;
    private string m_strPath= "map/";
    // Start is called before the first frame update
    void Start() {
        m_strPath = PathForDocumentsFile(m_strPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void save() {
        string mapName = GameObject.FindWithTag("MapName").name+".txt";
        string path = m_strPath;
        path = path + mapName;
        Debug.Log(path);
        FileStream fs = new FileStream(path, FileMode.Create);
        Debug.Log(mapName + "," + fs);
        StreamWriter w = new StreamWriter(fs);
        for(int i = 0; i < enemy.transform.childCount; i++) {
            Debug.Log(i);
            EnemyData e = enemy.transform.GetChild(i).GetComponent<EnemyData>();
            string str = e.SpawnPoint.x + "," + e.SpawnPoint.y + ","+e.Pos1.x+","+e.Pos1.y+","+ e.Pos2.x + "," + e.Pos2.y + "," +e.SpawnTime+","+e.EnemySpeed+","+e.Bullettype+","+e.Firerate+","+e.BulletSpeed+","+e.Color.r+","+e.Color.g+","+e.Color.b+","+null+","+null;
            w.WriteLine(str);
        }
        w.Close();
    }
    public string PathForDocumentsFile(string filename) {
        if (Application.platform == RuntimePlatform.IPhonePlayer) {
            string path = Application.dataPath.Substring(0, Application.dataPath.Length - 5);
            path = path.Substring(0, path.LastIndexOf('/'));
            return Path.Combine(Path.Combine(path, "Documents"), filename);
        } else if (Application.platform == RuntimePlatform.Android) {
            string path = Application.persistentDataPath;
            path = path.Substring(0, path.LastIndexOf('/'));
            return Path.Combine(path, filename);
        } else if (Application.platform == RuntimePlatform.WindowsEditor) {
            string path = Application.dataPath + "/" + filename;
            return path;
        } else if (Application.platform == RuntimePlatform.WindowsPlayer) {
            string path = Application.dataPath + "/" + filename;
            return path;
        } else {
            string path = Application.dataPath;
            path = path.Substring(0, path.LastIndexOf('/'));
            return Path.Combine(path, filename);
        }
    }
}
