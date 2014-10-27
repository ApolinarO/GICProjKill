var bullet : GameObject;
var gunanimation : Animation;

function Start () {

}

function Update () {
if (Input.GetButtonDown ("Fire1")){
gunanimation.Play();
GameObject.Instantiate (bullet, transform.position, transform.rotation);
}
}