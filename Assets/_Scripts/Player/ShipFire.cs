using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFire : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform Gun;
    [SerializeField] private Vector3 posInstance;
    [SerializeField] private float countDown;
    [SerializeField] private float timeDuration = 0.2f;
    private void Awake()
    {
        countDown = timeDuration;
    }
 
    // Update is called once per frame
    void Update()
    {
        InitObject();
    }
    public void InitObject()
    {
        if (bulletPrefab == null) return;
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            posInstance = Gun.transform.position;
            GameObject ob = GameObjectPool.instance.GetGameObjectPool(bulletPrefab);
            ob.SetActive(true);
            ob.transform.position = posInstance;
            ob.transform.rotation = Quaternion.identity;
            countDown = timeDuration;
        }
    }
}
    