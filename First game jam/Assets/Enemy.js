#pragma strict

function Start () {

}

function Update () {

}
    function OnCollisionStay(collision : Collision)
    {
    if (collision.gameObject.tag == "Bullet")
    {
    Destroy(gameObject);
    }
     
    }