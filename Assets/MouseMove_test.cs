using UnityEngine;
using System.Collections;

//给予鼠标控制的视角转换脚本(待定)::用给主视角

public class MouseMove_test : MonoBehaviour {
	public float roate_Speed=10.0f;//移动速度10.0←float
	private static float mousX;
	private static float mousY;
	private static float delmousX;
	private static float delmousY;
	private static bool isMove;
    public float shakeMask=4.0f;


	// Use this for initialization  并没有初始值,可能需要增加回归初始位置的旋转
	void Start () {
		isMove = false;
		mousX = 0;
		mousY = 0;
	}


    private float Getabs(float inp)
    {//取绝对值
        if (inp >= 0)
            return inp;
        else
            return -1.0f * inp;
    }


    // Update is called once per frame
    void Update () {
		//if (Input.touchCount > 0&&isMove==false) {
		//	mousX = Input.GetAxis("Mouse X");
		//	mousY = Input.GetAxis("Mouse Y");
		//	isMove=true;
		//}

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)  //获取鼠标输入
		{

            //		Debug.Log(cameraposX);

            //delmousX =  ( Input.GetAxis("Mouse X")-mousX ) * roate_Speed;
            //delmousY =  ( Input.GetAxis("Mouse Y")-mousY ) * roate_Speed;//得到鼠标移动距离  
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

   //         float checkrotX=Getabs (delmousX);
			//float checkrotY=Getabs (delmousY);//确认大致移动方向

			float cameraposX= transform.position.x;
			float cameraposZ= transform.position.z;//通过位置的向量计算垂直方向的旋转轴 在想要不要提出去当pubic
			float cameraposY= transform.position.y;//旋转限制
                                                   //	Debug.Log (cameraposY);

            //if(checkrotX>=checkrotY)//中心思想是二维数据控制三维旋转,略作调整之后AxisX控制(0,1,0)轴向的旋转,AxisY控制垂直方向旋转
            //	transform.RotateAround (Vector3.zero, Vector3.up,delmousX);//水平旋转

            //else if(cameraposY< shakeMask && cameraposY>-1.0f* shakeMask)//(cameraposY<-5&&mousY>0)||(cameraposY>5&&mousY<0)else    垂直旋转,逻辑需要调整
            //	transform.RotateAround (Vector3.zero, new Vector3(-cameraposZ,0,cameraposX), -delmousY);
            //else if(cameraposY> shakeMask && delmousY>0)
            //	transform.RotateAround (Vector3.zero, new Vector3(-cameraposZ,0,cameraposX), -delmousY);
            //else if(cameraposY< -1.0f * shakeMask && delmousY<0)
            //	transform.RotateAround (Vector3.zero, new Vector3(-cameraposZ,0,cameraposX), -delmousY);//逻辑可能需要调整
            if(touchDeltaPosition.y<0)
            {
                if (cameraposY > 7)
                    touchDeltaPosition.y = 0;
            }
            else
            {
                if (cameraposY < -7)
                    touchDeltaPosition.y = 0;
            }
            if (Getabs(touchDeltaPosition.x)> Getabs(touchDeltaPosition.y))
                transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), touchDeltaPosition.x);
            else
                transform.RotateAround(Vector3.zero, new Vector3(cameraposZ, 0, -1.0f * cameraposX), touchDeltaPosition.y);
        

        }  
		
	}
}
