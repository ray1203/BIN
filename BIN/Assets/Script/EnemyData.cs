﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData :MonoBehaviour {
    private Vector2 spawnPoint = new Vector2(0, 0);//0,1
    private Vector2 pos1=new Vector2(0,0);//2,3
    private Vector2 pos2 = new Vector2(0, 0);//4,5
    private float spawnTime = 2f;//6
    private float enemySpeed = 2.0f;//7
    private int bullettype;//0:normal 1:following//8
    private float firerate = 0f;//9
    private float bulletSpeed = 0f;//10
    private int spreadPoint;//11
    private int hp = 1;//12
    private Sprite enemySprite;
    public EnemyData(Vector2 spawnPoint, Vector2 pos1, Vector2 pos2, float spawnTime, float enemySpeed, int bullettype, float firerate, float bulletSpeed, int spreadPoint, int hp,Sprite enemySprite) {
        this.spawnPoint = spawnPoint;
        this.pos1 = pos1;
        this.pos2 = pos2;
        this.spawnTime = spawnTime;
        this.enemySpeed = enemySpeed;
        this.bullettype = bullettype;
        this.firerate = firerate;
        this.bulletSpeed = bulletSpeed;
        this.spreadPoint = spreadPoint;
        this.hp = hp;
        this.enemySprite = enemySprite;
    }
    public void putDatas(EnemyData e) {
        this.spawnPoint = e.spawnPoint;
        this.pos1 = e.pos1;
        this.pos2 = e.pos2;
        this.spawnTime = e.spawnTime;
        this.enemySpeed = e.enemySpeed;
        this.bullettype = e.bullettype;
        this.firerate = e.firerate;
        this.bulletSpeed = e.bulletSpeed;
        this.spreadPoint = e.spreadPoint;
        this.hp = e.hp;
        this.enemySprite = e.enemySprite;
    }

    public Vector2 SpawnPoint {
        get {
            return spawnPoint;
        }

        set {
            spawnPoint = value;
        }
    }

    public Vector2 Pos1 {
        get {
            return pos1;
        }

        set {
            pos1 = value;
        }
    }

    public Vector2 Pos2 {
        get {
            return pos2;
        }

        set {
            pos2 = value;
        }
    }

    public float SpawnTime {
        get {
            return spawnTime;
        }

        set {
            spawnTime = value;
        }
    }

    public float EnemySpeed {
        get {
            return enemySpeed;
        }

        set {
            enemySpeed = value;
        }
    }

    public int Bullettype {
        get {
            return bullettype;
        }

        set {
            bullettype = value;
        }
    }

    public float Firerate {
        get {
            return firerate;
        }

        set {
            firerate = value;
        }
    }

    public float BulletSpeed {
        get {
            return bulletSpeed;
        }

        set {
            bulletSpeed = value;
        }
    }

    public int SpreadPoint {
        get {
            return spreadPoint;
        }

        set {
            spreadPoint = value;
        }
    }

    public int Hp {
        get {
            return hp;
        }

        set {
            hp = value;
        }
    }

    public Sprite EnemySprite {
        get {
            return enemySprite;
        }

        set {
            enemySprite = value;
        }
    }
}
