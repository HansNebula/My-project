using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    public Image hpTarget;
    public TextMeshProUGUI tmpHp;
    public int hpInt;

    void Start(){
        hpInt=5;
    }
    void Update(){
        tmpHp.text=hpInt.ToString()+"/5";
        //if(Input.GetKeyDown(KeyCode.F)) getHurt();

        if(hpInt<=0)hpInt=0;

        if(hpInt>3) hpTarget.color=Color.green;
        if(hpInt<4&&hpInt>1) hpTarget.color=new Color(253,255,0,255);
        if(hpInt<2) hpTarget.color=Color.red;
    }
    public void getHurt(){
        hpInt-=1;
        hpTarget.fillAmount-=0.2f;
    }
}
