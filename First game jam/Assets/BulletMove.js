var speed = 1;
var timer : float= 10;
var explosion : GameObject;

function Start () {

}

function Update () {
 transform.position += transform.forward * speed * Time.deltaTime;
 
 if (timer < 0){
 GameObject.Destroy (gameObject);
 }
 
 timer -= Time.deltaTime;
}
    function OnCollisionStay(collision : Collision)  {
    if (collision.gameObject.tag == "Floor") {
    Destroy(gameObject);
    }
   
    
    if (collision.gameObject.tag == "Enemy") {
    GameObject.Instantiate (explosion, transform.position, transform.rotation);
    Destroy(gameObject);
    Destroy(collision.gameObject);
    }
 }