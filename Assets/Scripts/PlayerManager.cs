using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public int char1;

    PhotonView PV;

    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    void Start()
    {

        if (PV.IsMine)
        {
            if(char1 == 1)
            {
                CreateController();
            }
            else
            {
                CreateController();
            }
        }
    }

    void CreateController()
    {
        Debug.Log("Instantiate Player Controller");
        
        if(char1 == 0)
        {
            Transform spawnpoint = SpawnManager.Instance.GetSpawnpoint();
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerController"), spawnpoint.position, spawnpoint.rotation);
        }

        if(char1 == 1)
        {
            Transform spawnpoint = SpawnManager.Instance.GetSpawnpoint();
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerController1"), spawnpoint.position, spawnpoint.rotation);
        }
    }
}
