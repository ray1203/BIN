﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
    public static gameManager instance;
    public Text scoreText;
    private int score = 0;
    public GameObject EnemyBase;
    void Awake()
    {   

        GameObject e = GameObject.Find("Enemy").gameObject;
        for(int i = 0; i < e.transform.childCount; i++) {
            GameObject E = EnemyBase;
            E.GetComponent<EnemyCtrl>().spawnPoint = Camera.main.ScreenToWorldPoint(e.transform.GetChild(i).GetComponent<EnemyData>().SpawnPoint);
            E.GetComponent<EnemyCtrl>().pos1 = Camera.main.ScreenToWorldPoint(e.transform.GetChild(i).GetComponent<EnemyData>().Pos1);
            E.GetComponent<EnemyCtrl>().pos2 = Camera.main.ScreenToWorldPoint(e.transform.GetChild(i).GetComponent<EnemyData>().Pos2);
            E.GetComponent<EnemyCtrl>().spawnTime = e.transform.GetChild(i).GetComponent<EnemyData>().SpawnTime;
            E.GetComponent<EnemyCtrl>().enemySpeed = e.transform.GetChild(i).GetComponent<EnemyData>().EnemySpeed;
            E.GetComponent<EnemyCtrl>().firerate = e.transform.GetChild(i).GetComponent<EnemyData>().Firerate;
            E.GetComponent<EnemyCtrl>().bulletSpeed = e.transform.GetChild(i).GetComponent<EnemyData>().BulletSpeed;
            E.GetComponent<SpriteRenderer>().sprite = e.transform.GetChild(i).GetComponent<EnemyData>().EnemySprite;

            if (e.transform.GetChild(i).GetComponent<EnemyData>().Bullettype == 0) {
                E.GetComponent<EnemyCtrl>().bullet.GetComponent<BulletCtrl>().normalBullet = true;
                E.GetComponent<EnemyCtrl>().bullet.GetComponent<BulletCtrl>().playerFollowingBullet = false;
            } else {
                E.GetComponent<EnemyCtrl>().bullet.GetComponent<BulletCtrl>().playerFollowingBullet = true;
                E.GetComponent<EnemyCtrl>().bullet.GetComponent<BulletCtrl>().normalBullet = false;
            }
            Instantiate(E);
        }
        if (!instance)
            instance = this;
    }
    public void AddScore(int num)
    {
        score += num; //점수를 더해줍니다.
        scoreText.text = "Score : " + score;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
