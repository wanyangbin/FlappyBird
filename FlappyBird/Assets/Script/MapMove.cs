using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float speed = 300f;
    public RectTransform tubes1;
    public RectTransform tubes2;
    private RectTransform _transform;
    // Start is called before the first frame update
    void Awake()
    {
        _transform = transform as RectTransform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (_transform.anchoredPosition.x <= -764)
        {
            _transform.anchoredPosition = new Vector2(764f, 0);
            tubes1.anchoredPosition = new Vector2(tubes1.anchoredPosition.x, Random.Range(-170, 200));
            tubes2.anchoredPosition = new Vector2(tubes2.anchoredPosition.x, Random.Range(-170, 200));
        }
    }
}
