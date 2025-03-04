using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        GameObject obj = GameObject.FindGameObjectWithTag("coin");
       // if (obj != null )
        //{
            //obj.GetComponent<Spin>().powerUp.AddListener(OnPowerUp);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.Play("open");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.Play("close");
    }
    public void OnPowerUp()
    {
        Debug.Log("power up");
        animator.Play("open");
    }
}
