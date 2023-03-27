using BaseTemplate.Behaviours;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoSingleton<PlayerManager>
{
    #region public
    public PlayerStats playerStats;
    public PlayerController playerController;

    #endregion

    [SerializeField] Transform spawnPoint;
    GameObject currentShip;
    public void Init()
    {
        currentShip = Instantiate(playerStats.Renderer.gameObject, playerController.rendererParent.transform);
        currentShip.transform.position = spawnPoint.position;
        currentShip.transform.rotation = spawnPoint.rotation;
    }
}
