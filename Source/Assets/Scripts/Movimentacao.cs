using UnityEngine;
using System.Collections;

public class Movimentacao : MonoBehaviour {
	public KeyCode right, left, jump;
	float tempo;
	Rigidbody2D playerFisica;
	public Transform testePulo1, testePulo2, testePulo3;
	public Transform testeDireita1, testeDireita2, testeDireita3;
	public Transform testeEsquerda1, testeEsquerda2, testeEsquerda3;
	// Use this for initialization
	void Start () {
		playerFisica = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;
		if(Input.GetKey(right) && tempo >0.5f ){
			playerFisica.velocity = new Vector2(8, playerFisica.velocity.y);
		}
		if(Input.GetKey(left) && tempo >0.5f ){
			playerFisica.velocity = new Vector2(-8, playerFisica.velocity.y);
		}
		pular();
		PularParaDireita();
		PularParaEsquerda();

	/*	Vector3 velocidadePlayer;
		if(Input.GetKey(right)){
			velocidadePlayer.x = 10;
		}
		if(Input.GetKey(left)){
			velocidadePlayer.x = -10;
		}
		if(Input.GetKeyDown(jump)){
			velocidadePlayer.y = 10;
		}*/




	}

	void pular(){
	  	RaycastHit2D hit1 =	Physics2D.Raycast(testePulo1.position, -Vector2.up, 0.1f);
		RaycastHit2D hit2 =	Physics2D.Raycast(testePulo2.position, -Vector2.up, 0.1f);
		RaycastHit2D hit3 =	Physics2D.Raycast(testePulo3.position, -Vector2.up, 0.1f);





		if((hit1.collider != null) || (hit1.collider != null) || (hit1.collider != null)){
			if(Input.GetKeyDown(jump)){
				playerFisica.velocity = new Vector2( playerFisica.velocity.x,6);
			}
		}

	}
	void PularParaDireita(){
		RaycastHit2D ParedeE1 =	Physics2D.Raycast(testeEsquerda1.position, -Vector2.right, 0.1f);
		RaycastHit2D ParedeE2 =	Physics2D.Raycast(testeEsquerda2.position, -Vector2.right, 0.1f);
		RaycastHit2D ParedeE3=	Physics2D.Raycast(testeEsquerda3.position, -Vector2.right, 0.1f);

		if((ParedeE1.collider != null) || (ParedeE2.collider != null) || (ParedeE3.collider != null)){
			if(Input.GetKeyDown(jump)){
				tempo = 0;
				playerFisica.velocity = new Vector2( 6,6);

			}
		}
	}
	void PularParaEsquerda(){
		
		RaycastHit2D ParedeD1 =	Physics2D.Raycast(testeDireita1.position, Vector2.right, 0.1f);
		RaycastHit2D ParedeD2 =	Physics2D.Raycast(testeDireita2.position, Vector2.right, 0.1f);
		RaycastHit2D ParedeD3=	Physics2D.Raycast(testeDireita3.position, Vector2.right, 0.1f);

		if((ParedeD1.collider != null) || (ParedeD2.collider != null) || (ParedeD3.collider != null)){
			if(Input.GetKeyDown(jump)){
				tempo = 0;
				playerFisica.velocity = new Vector2( -6,6);
			}
		}
	}
}
