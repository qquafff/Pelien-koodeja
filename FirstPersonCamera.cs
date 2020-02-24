using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    Vector2 hiirenKaanto;
    Vector2 kiihdytysV;
    public float herkkyys;
    public float kiihdyttaa;

    GameObject hahmo;

    private void Start()
    {
        hahmo = this.transform.parent.gameObject;
    }

    private void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(herkkyys * kiihdyttaa, herkkyys * kiihdyttaa));
        kiihdytysV.x = Mathf.Lerp(kiihdytysV.x, md.x, 1f / kiihdyttaa);
        kiihdytysV.y = Mathf.Lerp(kiihdytysV.y, md.y, 1f / kiihdyttaa);
        hiirenKaanto += kiihdytysV;

        transform.localRotation = Quaternion.AngleAxis(-hiirenKaanto.y, Vector3.right);
        hahmo.transform.localRotation = Quaternion.AngleAxis(hiirenKaanto.x, hahmo.transform.up);
    }






}
