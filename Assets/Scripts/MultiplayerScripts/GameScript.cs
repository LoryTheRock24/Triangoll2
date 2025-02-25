﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GameScript : NetworkBehaviour {

    public GameScript gameScript;
    public NetworkManager networkManager;

    public GameObject[] spawnPoints = new GameObject[6];

    void Start() {
        MpPlayer.gameManager = gameScript;
        MpPlayer.networkManager = networkManager;
    }
}
