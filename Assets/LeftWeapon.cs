using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWeapon : MonoBehaviour {
    SteamVR_TrackedObject trackedObj;
    public Transform GunKou;

    public GameObject PrefabFire;

    public GameObject prefabHit;

    void Awake()
    {
        //获取手柄脚本组件
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //获取手柄输入
        var device = SteamVR_Controller.Input((int)trackedObj.index);


        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            GameObject go = Instantiate(PrefabFire, GunKou.transform.position,GunKou.transform.rotation);
            Destroy(go,1);
            RaycastHit info;

            bool hit = Physics.Raycast(GunKou.position, GunKou.TransformDirection(Vector3.forward),out info,200);
            if (hit)
            {
                //生成开枪特效
                GameObject go1= Instantiate(PrefabFire);
                go1.transform.position = info.point;

                if (info.transform.tag=="enemy")
                {
                    info.transform.GetComponent<zombie>().TakeDamage();


                }
            }
            Debug.Log("按下扳机键");
        }


    }
}
