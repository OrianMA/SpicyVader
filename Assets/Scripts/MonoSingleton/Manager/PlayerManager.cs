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
    [SerializeField] Transform playerRendererParent;
    GameObject currentShip;
    public void Init()
    {
        currentShip = Instantiate(playerStats.Renderer.gameObject, playerRendererParent);
        playerController.Init();
    }
}
