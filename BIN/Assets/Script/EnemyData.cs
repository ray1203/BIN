﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData:MonoBehaviour {
    private Vector2 spawnPoint = new Vector2(0, 0);
    private Vector2 pos1=new Vector2(0,0);
    private Vector2 pos2 = new Vector2(0, 0);
    private float spawnTime = 2f;
    private float enemySpeed = 2.0f;
    private GameObject bullet;
    private int bullettype;//0:normal 1:following
    private float firerate = 0f;
    private float bulletSpeed = 0f;

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

    public GameObject Bullet {
        get {
            return bullet;
        }

        set {
            bullet = value;
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

    public int Bullettype {
        get {
            return bullettype;
        }

        set {
            bullettype = value;
        }
    }

    public EnemyData(Vector2 spawnPoint, Vector2 pos1, Vector2 pos2, float spawnTime, float enemySpeed, GameObject bullet, int bullettype, float firerate, float bulletSpeed) {
        this.spawnPoint = spawnPoint;
        this.pos1 = pos1;
        this.pos2 = pos2;
        this.spawnTime = spawnTime;
        this.enemySpeed = enemySpeed;
        this.bullet = bullet;
        this.Bullettype = bullettype;
        this.firerate = firerate;
        this.bulletSpeed = bulletSpeed;
    }
}
