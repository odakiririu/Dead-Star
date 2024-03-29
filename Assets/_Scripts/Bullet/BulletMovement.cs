using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float moveSpeedBullet = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeedBullet * Time.deltaTime;
    }
    private void OnEnable()
    {
        Invoke("Destroy", 10f);
    }
    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
