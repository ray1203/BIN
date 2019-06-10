﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainToEdit : MonoBehaviour
{
    public Sprite EnemySprite;
    public GameObject EnemyEditor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toEdit(string name) {
        List<EnemyData> enemyDatas = this.GetComponent<mapData>().EnemyDatas;
        GameObject gameObject = new GameObject();
        GameObject mapName = new GameObject();
        mapName.name = this.transform.Find("mapname").GetComponent<Text>().text;
        mapName.tag = ("MapName");
        gameObject.tag = "fill";
        gameObject.name = "enemy";
        foreach(var Item in enemyDatas) {
            GameObject newObject=Instantiate(EnemyEditor);
            newObject.GetComponent<EnemyData>().putDatas(Item);
            newObject.GetComponent<Image>().sprite = EnemySprite;
            newObject.transform.position = Item.SpawnPoint;
            newObject.transform.localScale = new Vector2(0.01f, 0.01f);
            newObject.transform.SetParent(gameObject.transform);
        }
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(mapName);
        SceneManager.LoadScene(name);

    }
}