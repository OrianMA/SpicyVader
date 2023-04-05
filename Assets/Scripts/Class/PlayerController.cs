using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerStats currentStats;

    public void Init()
    {
        currentStats = PlayerManager.Instance.playerStats;
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = new Vector3(-touch.position.x,0 , -touch.position.x);
            
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(touchPosition);
            targetPosition.y = transform.position.y;
            print(targetPosition);

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, currentStats.speed * Time.deltaTime);

        }
    }

    private Vector3 GetScreenCenterOffset()
    {
        Vector3 center = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        return Camera.main.ScreenToWorldPoint(center) - Camera.main.transform.position;
    }
}
