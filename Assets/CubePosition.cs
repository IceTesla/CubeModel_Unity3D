using UnityEngine;
using System.Collections;
using System;

public class CubePosition : MonoBehaviour {
	public static int move_ctl;
	private static float rot=0f;
	public static float rotation_speed;
	public float cube_num=9f; 
//	public int *craft; 
	public int[] cft;
	public static int counting = 0;
	public static int maxl;

//	public Vector3 rotate_Axis;//暂定的公共变量旋转轴,由输入决定

	private int cubeposX;
	private int cubeposY;
	private int cubeposZ;
	// Use this for initialization
	void Start () {
        this.name = "Rubik";
        rotation_speed = 3f;
        cft = new int[]{18};
        counting = 0;
		maxl = cft.Length;
        //	craft = new int[5];
    }
	void setRota(string rota)
    {
        if (move_ctl == 19)
        {
            string[] sArray = rota.Split('#');
            int[] intArray;
            intArray = Array.ConvertAll<string, int>(sArray, s => int.Parse(s));
            cft = (int[])intArray.Clone();
            counting = 0;
            maxl = cft.Length;
            move_ctl = 0;
        }
    }
    void setSpeed(string sp)
    {
        rotation_speed = float.Parse(sp);
    }
    // Update is called once per frame
    void Update () {

		cubeposX = amendatory_check (transform.position.x);
		cubeposY = amendatory_check (transform.position.y);
		cubeposZ = amendatory_check (transform.position.z);//获取方块位置信息

	/*	if (Input.GetKey (KeyCode.A) && move_ctl == 0) //正左 x-
			move_ctl = 1;  
		if (Input.GetKey (KeyCode.D) && move_ctl == 0) //正右 x+
			move_ctl = 2;  
		if (Input.GetKey (KeyCode.S) && move_ctl == 0) //正主 z-
			move_ctl = 3;  
		if (Input.GetKey (KeyCode.W) && move_ctl == 0) //正后 z+
			move_ctl = 4;  
		if (Input.GetKey (KeyCode.Q) && move_ctl == 0) //正下 y-
			move_ctl = 5;  
		if (Input.GetKey (KeyCode.E) && move_ctl == 0) //正上 y+
			move_ctl = 6;  //输入控制

*/
		//Debug.Log (move_ctl);

		if (counting >= maxl) {
			move_ctl =19;
		}
		if (move_ctl == 0) {
			move_ctl = cft[counting]+ 1;  
		}
		/*
		if (cft[counting] == 0 && move_ctl == 0) //U
			move_ctl = 1;  
		if (cft[counting] == 1 && move_ctl == 0) //U2
			move_ctl = 2;  
		if (cft[counting] == 2 && move_ctl == 0) //U'
			move_ctl = 3;  

		if (cft[counting] == 3 && move_ctl == 0) //R
			move_ctl = 4;  
		if (cft[counting] == 4 && move_ctl == 0) //R2
			move_ctl = 5;  
		if (cft[counting] == 5 && move_ctl == 0) //R'
			move_ctl = 6;  

		if (cft[counting] == 6 && move_ctl == 0) //F
			move_ctl = 7;  
		if (cft[counting] == 7 && move_ctl == 0) //F2
			move_ctl = 8;  
		if (cft[counting] == 8 && move_ctl == 0) //F'
			move_ctl = 9;  

		if (cft[counting] == 9 && move_ctl == 0) //D
			move_ctl = 10;  
		if (cft[counting] == 10 && move_ctl == 0) //D2
			move_ctl = 11;  
		if (cft[counting] == 11 && move_ctl == 0) //D'
			move_ctl = 12;  

		if (cft[counting] == 12 && move_ctl == 0) //L
			move_ctl = 13;  
		if (cft[counting] == 13 && move_ctl == 0) //L2
			move_ctl = 14;  
		if (cft[counting] == 14 && move_ctl == 0) //L'
			move_ctl = 15;  

		if (cft[counting] == 15 && move_ctl == 0) //B
			move_ctl = 16;  
		if (cft[counting] == 16 && move_ctl == 0) //B2
			move_ctl = 17;  
		if (cft[counting] == 17 && move_ctl == 0) //B'
			move_ctl = 18;  
*/

		if (cubeposY == 2 && move_ctl == 1) {//其实从这个已经能确定了旋转轴向和径向 
			transform.RotateAround (new Vector3 ( 0, 1.1f, 0), new Vector3 ( 0, 1, 0),rotation_speed);//U
			rot+=rotation_speed;
		}
		if (cubeposY == 2 && move_ctl == 2) {
			transform.RotateAround (new Vector3 ( 0, 1.1f, 0), new Vector3 ( 0, 1, 0),rotation_speed);//U2
			rot+=rotation_speed/2;
		}
		if (cubeposY == 2 && move_ctl == 3) {
			transform.RotateAround (new Vector3 ( 0, 1.1f, 0), new Vector3 ( 0, -1, 0),rotation_speed);//U'
			rot+=rotation_speed;
		}

		if (cubeposX == 2 && move_ctl == 4) {
			transform.RotateAround (new Vector3 ( 1.1f, 0, 0), new Vector3 ( 1, 0, 0),rotation_speed);//R
			rot+=rotation_speed;
		}
		if (cubeposX == 2 && move_ctl == 5) {
			transform.RotateAround (new Vector3 ( 1.1f, 0, 0), new Vector3 ( 1, 0, 0),rotation_speed);//R2
			rot+=rotation_speed/2;
		}
		if (cubeposX == 2 && move_ctl == 6) {
			transform.RotateAround (new Vector3 ( 1.1f, 0, 0), new Vector3 ( -1, 0, 0),rotation_speed);//R'
			rot+=rotation_speed;
        }

		if (cubeposZ == 0 && move_ctl == 7) {
			transform.RotateAround (new Vector3 ( 0, 0,-1.1f), new Vector3 ( 0, 0, -1),rotation_speed);//F
			rot+=rotation_speed;
		}
		if (cubeposZ == 0 && move_ctl == 8) {
			transform.RotateAround (new Vector3 ( 0, 0,-1.1f), new Vector3 ( 0, 0, -1),rotation_speed);//F2
			rot+=rotation_speed/2;
		}
		if (cubeposZ == 0 && move_ctl == 9) {
			transform.RotateAround (new Vector3 ( 0, 0,-1.1f), new Vector3 ( 0, 0, 1),rotation_speed);//F'
			rot+=rotation_speed;
		}

		if (cubeposY == 0 && move_ctl == 10) {
			transform.RotateAround (new Vector3 ( 0, -1.1f, 0), new Vector3 ( 0, -1, 0),rotation_speed);//D
			rot+=rotation_speed;
		}
		if (cubeposY == 0 && move_ctl == 11) {
			transform.RotateAround (new Vector3 ( 0, -1.1f, 0), new Vector3 ( 0, -1, 0),rotation_speed);//D2
			rot+=rotation_speed/2;
		}
		if (cubeposY == 0 && move_ctl == 12) {
			transform.RotateAround (new Vector3 ( 0, -1.1f, 0), new Vector3 ( 0, 1, 0),rotation_speed);//D'
			rot+=rotation_speed;
		}

		if (cubeposX == 0 && move_ctl == 13) {
			transform.RotateAround (new Vector3 ( -1.1f, 0, 0), new Vector3 ( -1, 0, 0),rotation_speed);//L
			rot+=rotation_speed;
		}
		if (cubeposX == 0 && move_ctl == 14) {
			transform.RotateAround (new Vector3 ( -1.1f, 0, 0), new Vector3 ( -1, 0, 0),rotation_speed);//L2
			rot+=rotation_speed/2;
		}
		if (cubeposX == 0 && move_ctl == 15) {
			transform.RotateAround (new Vector3 ( -1.1f, 0, 0), new Vector3 ( 1, 0, 0),rotation_speed);//L'
			rot+=rotation_speed;
		}

		if (cubeposZ == 2 && move_ctl == 16) {
			transform.RotateAround (new Vector3 ( 0, 0, 1.1f), new Vector3 ( 0, 0, 1),rotation_speed);//B
			rot+=rotation_speed;
		}
		if (cubeposZ == 2 && move_ctl == 17) {
			transform.RotateAround (new Vector3 ( 0, 0, 1.1f), new Vector3 ( 0, 0, 1),rotation_speed);//B2
			rot+=rotation_speed/2;
		}
		if (cubeposZ == 2 && move_ctl == 18) {
			transform.RotateAround (new Vector3 ( 0, 0, 1.1f), new Vector3 ( 0, 0,-1),rotation_speed);//B'
			rot+=rotation_speed;
		}
		/*

		if (cubeposZ == 2 && move_ctl == 4) {// z+ 
			transform.RotateAround (new Vector3 ( 0, 0, 1.1f), new Vector3 ( 0, 0, 1),rotation_speed);//循环次数控制，误差来源于旋转的物理引擎 0.5为模型修正
			rot+=rotation_speed;
		}
		if (cubeposY == 0 && move_ctl == 5) {// y-
			transform.RotateAround (new Vector3 ( 0,-1.1f, 0), new Vector3 ( 0, -1, 0),rotation_speed);//循环次数控制，误差来源于旋转的物理引擎
			rot+=rotation_speed;
		}
		if (cubeposY == 2 && move_ctl == 6) {// y+
			transform.RotateAround (new Vector3 ( 0, 1.1f, 0), new Vector3 ( 0, 1, 0),rotation_speed);//循环次数控制，误差来源于旋转的物理引擎
			rot+=rotation_speed;
		}

*/
		if (rot == 90f*cube_num) {
			rot=0;
			move_ctl = 0;
			counting++ ;
            
            //	amendatory_func();
        }//停止响应
        
        //Debug.Log (rot);//误差检测

    }//Update
	
/*	void amendatory_func () {//修正函数
		float resultX = position_amendatory (transform.position.x);
		float resultY = position_amendatory (transform.position.y);
		float resultZ = position_amendatory (transform.position.z);
		transform.position = new Vector3 (resultX, resultY, resultZ);

	}//ame_fun

	float position_amendatory(float ori)//位置修正函数
	{
		ori += 0.5f;
		float res =  Mathf.Ceil (ori);
		res = res - 1;
		res = res * 1.1f;
		//Debug.Log (res);
		return res;

	}//pos_ame          */

	int amendatory_check(float ori)//修正检验函数
	{
		ori += 0.5f;
		int res =Mathf.CeilToInt(ori);
	//	Debug.Log (res);
		return res;
		
	}//ame_CHECK
}