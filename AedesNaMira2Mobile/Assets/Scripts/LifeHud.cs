using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeHud : MonoBehaviour
{

    public Image Vida;
    public Sprite v100, v99, v98, v97, v96, v95, v94, v93, v92, v91, v90, v89, v88, v87, v86, v85, v84, v83, v82, v81;
    public Sprite v80, v79, v78, v77, v76, v75, v74, v73, v72, v71, v70, v69, v68, v67, v66, v65, v64, v63, v62, v61;
    public Sprite v60, v59, v58, v57, v56, v55, v54, v53, v52, v51, v50, v49, v48, v47, v46, v45, v44, v43, v42, v41;
    public Sprite v40, v39, v38, v37, v36, v35, v34, v33, v32, v31, v30, v29, v28, v27, v26, v25, v24, v23, v22, v21;
    public Sprite v20, v19, v18, v17, v16, v15, v14, v13, v12, v11, v10, v9, v8, v7, v6, v5, v4, v3, v2, v1, v0;
    // Start is called before the first frame update


    public void atualizarLife(float life)
    {           
            try
            {              

                if (life >= 100)
                    Vida.sprite = v100;
                else if (life >= 99)
                    Vida.sprite = v99;
                else if (life >= 98)
                    Vida.sprite = v98;
                else if (life >= 97)
                    Vida.sprite = v97;
                else if (life >= 96)
                    Vida.sprite = v96;
                else if (life >= 95)
                    Vida.sprite = v95;
                else if (life >= 94)
                    Vida.sprite = v94;
                else if (life >= 93)
                    Vida.sprite = v93;
                else if (life >= 92)
                    Vida.sprite = v92;
                else if (life >= 91)
                    Vida.sprite = v91;
                else if (life >= 90)
                    Vida.sprite = v90;
                else if (life >= 89)
                    Vida.sprite = v89;
                else if (life >= 87)
                    Vida.sprite = v87;
                else if (life >= 86)
                    Vida.sprite = v86;
                else if (life >= 85)
                    Vida.sprite = v85;
                else if (life >= 84)
                    Vida.sprite = v84;
                else if (life >= 83)
                    Vida.sprite = v83;
                else if (life >= 82)
                    Vida.sprite = v82;
                else if (life >= 81)
                    Vida.sprite = v81;
                else if (life >= 80)
                    Vida.sprite = v80;
                else if (life >= 79)
                    Vida.sprite = v79;
                else if (life >= 78)
                    Vida.sprite = v78;
                else if (life >= 77)
                    Vida.sprite = v77;
                else if (life >= 76)
                    Vida.sprite = v76;
                else if (life >= 75)
                    Vida.sprite = v75;
                else if (life >= 74)
                    Vida.sprite = v74;
                else if (life >= 73)
                    Vida.sprite = v73;
                else if (life >= 72)
                    Vida.sprite = v72;
                else if (life >= 71)
                    Vida.sprite = v71;
                else if (life >= 70)
                    Vida.sprite = v70;
                else if (life >= 69)
                    Vida.sprite = v69;
                else if (life >= 68)
                    Vida.sprite = v68;
                else if (life >= 67)
                    Vida.sprite = v67;
                else if (life >= 66)
                    Vida.sprite = v66;
                else if (life >= 65)
                    Vida.sprite = v65;
                else if (life >= 64)
                    Vida.sprite = v64;
                else if (life >= 63)
                    Vida.sprite = v63;
                else if (life >= 62)
                    Vida.sprite = v62;
                else if (life >= 61)
                    Vida.sprite = v61;
                else if (life >= 60)
                    Vida.sprite = v60;
                else if (life >= 59)
                    Vida.sprite = v59;
                else if (life >= 58)
                    Vida.sprite = v58;
                else if (life >= 57)
                    Vida.sprite = v57;
                else if (life >= 56)
                    Vida.sprite = v56;
                else if (life >= 55)
                    Vida.sprite = v55;
                else if (life >= 54)
                    Vida.sprite = v54;
                else if (life >= 53)
                    Vida.sprite = v53;
                else if (life >= 52)
                    Vida.sprite = v52;
                else if (life >= 51)
                    Vida.sprite = v51;
                else if (life >= 50)
                    Vida.sprite = v50;
                else if (life >= 49)
                    Vida.sprite = v49;
                else if (life >= 48)
                    Vida.sprite = v48;
                else if (life >= 47)
                    Vida.sprite = v47;
                else if (life >= 46)
                    Vida.sprite = v46;
                else if (life >= 45)
                    Vida.sprite = v45;
                else if (life >= 44)
                    Vida.sprite = v44;
                else if (life >= 43)
                    Vida.sprite = v43;
                else if (life >= 42)
                    Vida.sprite = v42;
                else if (life >= 41)
                    Vida.sprite = v41;
                else if (life >= 40)
                    Vida.sprite = v40;
                else if (life >= 39)
                    Vida.sprite = v39;
                else if (life >= 38)
                    Vida.sprite = v38;
                else if (life >= 37)
                    Vida.sprite = v37;
                else if (life >= 36)
                    Vida.sprite = v36;
                else if (life >= 35)
                    Vida.sprite = v35;
                else if (life >= 34)
                    Vida.sprite = v34;
                else if (life >= 33)
                    Vida.sprite = v33;
                else if (life >= 32)
                    Vida.sprite = v32;
                else if (life >= 31)
                    Vida.sprite = v31;
                else if (life >= 30)
                    Vida.sprite = v30;
                else if (life >= 29)
                    Vida.sprite = v29;
                else if (life >= 28)
                    Vida.sprite = v28;
                else if (life >= 27)
                    Vida.sprite = v27;
                else if (life >= 26)
                    Vida.sprite = v26;
                else if (life >= 25)
                    Vida.sprite = v25;
                else if (life >= 24)
                    Vida.sprite = v24;
                else if (life >= 23)
                    Vida.sprite = v23;
                else if (life >= 22)
                    Vida.sprite = v22;
                else if (life >= 21)
                    Vida.sprite = v21;
                else if (life >= 20)
                    Vida.sprite = v20;
                else if (life >= 19)
                    Vida.sprite = v19;
                else if (life >= 18)
                    Vida.sprite = v18;
                else if (life >= 17)
                    Vida.sprite = v17;
                else if (life >= 16)
                    Vida.sprite = v16;
                else if (life >= 15)
                    Vida.sprite = v15;
                else if (life >= 14)
                    Vida.sprite = v14;
                else if (life >= 13)
                    Vida.sprite = v13;
                else if (life >= 12)
                    Vida.sprite = v12;
                else if (life >= 11)
                    Vida.sprite = v11;
                else if (life >= 10)
                    Vida.sprite = v10;
                else if (life >= 9)
                    Vida.sprite = v9;
                else if (life >= 8)
                    Vida.sprite = v8;
                else if (life >= 7)
                    Vida.sprite = v7;
                else if (life >= 6)
                    Vida.sprite = v5;
                else if (life >= 5)
                    Vida.sprite = v5;
                else if (life >= 4)
                    Vida.sprite = v4;
                else if (life >= 3)
                    Vida.sprite = v3;
                else if (life >= 2)
                    Vida.sprite = v2;
                else if (life >= 1)
                    Vida.sprite = v1;
                else if (life <= 0)
                    Vida.sprite = v0;
            }
            catch (System.Exception e)
            {

            }
        }
    }

   

