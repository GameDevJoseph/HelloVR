using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncherBehavior : MonoBehaviour
{
    [SerializeField] GameObject _launchPoint;
    [SerializeField] GameObject _rocketPrefab;
    [SerializeField] GameObject _rocketVisual;
    bool _canFire = true;

    [ContextMenu("TestFire")]
    public void FireRocket()
    {
        if (!_canFire)
            return;

        Instantiate(_rocketPrefab,_launchPoint.transform.position,_launchPoint.transform.rotation);
        _rocketVisual.SetActive(false);
        _canFire = false;
    }
}
