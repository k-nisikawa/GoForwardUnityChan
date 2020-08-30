using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //キューブ同士、もしくは地面に当たった場合、音を鳴らす
        if (collision.collider.tag == "GroundTag" || collision.collider.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
            Debug.Log("音が鳴る予定");
        }
    }
}