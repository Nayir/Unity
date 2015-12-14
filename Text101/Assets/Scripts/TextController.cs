using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text story;
	public Text answerA;
	public Text answerB;
	public Text answerC;
	public GameObject choices; // Assign in inspector
	private bool isShowingAnswer;
	public GameObject ContinuerButton; // Assign in inspector
	private bool isShowingContinu;
	public GameObject ReturnButton; // Assign in inspector
	private bool isShowingReturn;
	
	enum States {
		tv_0,
		tv_1,
		tv_2,
		tv_3,
		tv_internet,
		tv_playstation,
		garden_0,
		garden_1,
		garden_2,
		garden_3,
		garden_4,
		garden_5,
		garden_6,
		garden_who,
		garden_how,
		garden_7,
		garden_hat,
		garden_old,
		garden_8,
		jungle_0,
		jungle_1,
		jungle_2,
		jungle_left_1,
		jungle_center_1,
		jungle_right_1,
		jungle_left_2,
		jungle_center_2,
		jungle_right_2,
		jungle_left_3,
		jungle_center_3,
		jungle_right_3,
		temple_0,
		temple_1,
		temple_2,
		temple_3,
		temple_4,
		temple_5,
		temple_card,
		temple_stun,
		temple_6,
		temple_7,
		temple_8,
		temple_9,
		temple_10,
		temple_11,
		temple_11_1,
		temple_attack_0,
		temple_jump_0,
		temple_back_0,
		temple_attack_1,
		temple_jump_1,
		temple_back_1,
		temple_attack_2,
		temple_jump_2,
		temple_back_2,
		temple_12,
		temple_13,
		temple_14,
		temple_15,
		temple_16,
		montain_0,
		montain_rope_0,
		montain_jump_0,
		montain_fly_0,
		montain_cloud_1,
		montain_rope_1,
		montain_bridge_1,
		montain_1,
		montain_map_a,
		montain_map_z,
		montain_map_e,
		pyramid_0,
		pyramid_1,
		pyramid_2,
		pyramid_3,
		pyramid_4,
		pyramid_5,
		pyramid_floor_0,
		pyramid_roof_0,
		pyramid_walk_0,
		pyramid_fall,
		pyramid_cut_0,
		pyramid_stepup_0,
		pyramid_walkon_0,
		corridor_0,
		final_0,
		endscreen
	};
	private States myState;
	// Use this for initialization
	void Start () {
		TvScene0();
		
		if (Application.loadedLevelName == "garden") {
			myState = States.garden_0;
			isShowingAnswer = false;
			choices.SetActive(isShowingAnswer);
			
			isShowingContinu = true;
			ContinuerButton.SetActive(isShowingContinu);
			
			ReturnButton.SetActive(false);
		}
		else if (Application.loadedLevelName == "Game"){
			myState = States.tv_0;
			
			isShowingAnswer = false;
			choices.SetActive(isShowingAnswer);
			
			isShowingContinu = true;
			ContinuerButton.SetActive(isShowingContinu);
			
			ReturnButton.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		TvScene0();
		stepUpdate();
		print (Application.loadedLevelName);
	}

	public void ModeContinu(){
		choices.SetActive (false);
		ContinuerButton.SetActive (true);
	}

	public void ModeAnswer(){
		choices.SetActive (true);
		ContinuerButton.SetActive (false);
	}
	
	public void TvScene0(){
		if (myState  == States.tv_0) {
			story.text = "Télévision : FLASH INFO SPECIAL. Des archéologues ont découvert l’existence d’un grand trésor caché" +
				" dans la pyramide du Pharaon ToutenKarton. Les plus grands aventuriers du monde partent déjà à sa" +
					" recherche, qui pourra bien découvrir ce trésor en premier ? …\n\n";
			print (myState);
		}
		
		else if (myState  == States.tv_1) {
			story.text = " Le Héros : Qu’est ce que j’aimerais trouver ce trésor ! J’ai envie d’une autre vie, pleine d’aventure\n\n";
		}
		
		else if (myState  == States.tv_2) {
			story.text = " Mais sans Carte au Trésor je n’y arriverais jamais. Et puis je n’ai pas du tout le sens de l’orientation !\n\n";
		}
		
		else if (myState  == States.tv_3) {
			story.text = "Comment je pourrais me débrouiller ?";
			answerA.text = "Chercher la carte sur internet";
			answerB.text = "Aller dans le jardin";
			answerC.text = "Jouer à la Playstation";
		}
		
		else if (myState  == States.tv_internet) {
			story.text = "Il n'y a rien sur internet à propos de cette carte au trésor...";
		}
		
		else if (myState  == States.garden_0) {
			story.text = "Héros : Rien de tel qu’un peu d’air frais pour s’aérer les idées. Il faut que je réfléchisse à une solution pour retrouver ce fameux trésor avant les autres.";
		}
		
		else if (myState  == States.tv_playstation) {
			story.text = "Non ce n'est pas le moment de jouer, je dois partir à l'aventure !";
		}
		
		// GARDEN SECTION 
		
		else if (myState  == States.garden_0) {
			story.text = "Héros : Rien de tel qu’un peu d’air frais pour s’aérer les idées. Il faut que je réfléchisse à une solution pour retrouver ce fameux trésor avant les autres.";
		}
		
		else if (myState  == States.garden_1) {
			story.text = "PAAAAAAAF";
		}
		
		else if (myState  == States.garden_2) {
			story.text = "Héros : Waaaaah. J’en suis tombé à la renverse. C’était quoi ce bazar à l’instant ?";
		}
		
		else if (myState  == States.garden_3) {
			story.text = "Une voix : T’es un peu trouillard pour un aventurier ! Si de la simple fumée de te fait peur, tu ne pourras jamais retrouver le trésor de ToutenKarton !";
		}
		
		else if (myState  == States.garden_4) {
			story.text = "Héros : Hé mais, comment tu sais pour le trésor ?";
		}
		
		else if (myState  == States.garden_5) {
			story.text = "";
		}
		
		else if (myState  == States.garden_6) {
			story.text = "Héros : Ouais…. Mais du coup j’aurais quelques question à te poser:";
			answerA.text = "Qui es-tu ?";
			answerB.text = "Que fais-tu ici ?";
			answerC.text = "Comment tu es apparu dans mon jardin ?";
		}
		
		else if (myState  == States.garden_who) {
			story.text = "Je te l'ai dit à l'instant, je suis le Seigneur de la Magie.";
		}
		
		else if (myState  == States.garden_7) {
			story.text = "Seigneur de la Magie : Je suis ici car tu es l'enfant de le prophétie et tu dois absolument trouver le trésor avant tous les autres aventuriers." +
				"Ah ouais ? Mais c'est trop cool ça ! Et sinon...";
			answerA.text = "Tu as quel age ?";
			answerB.text = "Tu me donnes ton chapeau ?";
			answerC.text = "Tu me donnes la carte ?";
		}
		
		else if (myState  == States.garden_how) {
			story.text = "Avec mes puissants pouvoirs magiques, et un peu de talc";
		}
		
		else if (myState  == States.garden_old) {
			story.text = "J'ai 1999 ans, mais tu peux arrondir à 2000 ans.";
		}
		
		else if (myState  == States.garden_hat) {
			story.text = "Un simple mortel comme toi ne peut pas porter un chapeau de puissant magicien comme le mien.";
		}
		
		else if (myState  == States.garden_8) {
			story.text = "Merci ! C'est parti pour l'Egypte ! Je prends le premier vol.";
		}

		// GARDEN SECTION 

		else if (myState  == States.garden_8) {
			story.text = "Merci ! C'est parti pour l'Egypte ! Je prends le premier vol.";
		}
	}
	
	public void stepUpdate() {
		print (myState);
		if (myState == States.tv_3) {
			ModeAnswer();
		} else if (myState == States.garden_7) {
			myState = States.garden_7;
		} else if (myState == States.garden_7) {
			myState = States.garden_7;
		} else if (myState == States.garden_8) {
			ModeContinu();		
		}
	}
	
	public void Continuer(){
		if (myState  == States.tv_0) {
			myState = States.tv_1;
		} else if (myState == States.tv_1)  {
			myState = States.tv_2;
		} else if (myState == States.tv_2)  {
			myState = States.tv_3;
		} else if (myState == States.garden_0) {
			myState = States.garden_1;
		} else if (myState == States.garden_1) {
			myState = States.garden_2;
		} else if (myState == States.garden_2) {
			myState = States.garden_3;
		} else if (myState == States.garden_3) {
			myState = States.garden_4;
		} else if (myState == States.garden_4) {
			myState = States.garden_5;
		} else if (myState == States.garden_5) {
			myState = States.garden_6;
			choices.SetActive (true);
			ContinuerButton.SetActive (false);
		}
	}
	
	public void Return(){
		ReturnButton.SetActive(false);
		if (myState == States.tv_internet) {
			myState = States.tv_3;
		} else if (myState == States.tv_playstation) {
			myState = States.tv_3;
		} else if (myState == States.garden_who) {
			myState = States.garden_6;
			choices.SetActive (true);
			ContinuerButton.SetActive (false);
		} else if (myState == States.garden_how) {
			myState = States.garden_6;
			choices.SetActive (true);
			ContinuerButton.SetActive (false);
		} else if (myState == States.garden_hat) {
			myState = States.garden_7;
			choices.SetActive (true);
			ContinuerButton.SetActive (false);
		}
		
		else if (myState == States.garden_old) {
			myState = States.garden_7;
			choices.SetActive (true);
			ContinuerButton.SetActive (false);
		}
	}
	
	
	public void Answer(string answer){
		print (answer);
		
		if (myState  == States.tv_3) {
			if (answer == "a"){
				myState = States.tv_internet;
				ReturnButton.SetActive(true);
				choices.SetActive(false);
			}
			else if (answer == "b"){
				myState = States.garden_0;
				choices.SetActive(false);
				Application.LoadLevel("garden");
				
			}
			else if (answer == "c"){
				myState = States.tv_playstation;
				ReturnButton.SetActive(true);
				choices.SetActive(false);
			}
		} else if (myState  == States.garden_7) {
			if (answer == "a"){
				myState = States.garden_old;
				ReturnButton.SetActive(true);
				choices.SetActive(false);
			} else if (answer == "b"){
				myState = States.garden_hat;
				ReturnButton.SetActive(true);
				choices.SetActive(false);
			} else if (answer == "c"){
				myState = States.garden_8;
				print ("question 2b");
			}
			
		} else if (myState  == States.garden_6) {
			if (answer == "a"){
				myState = States.garden_who;
				ReturnButton.SetActive(true);
				choices.SetActive(false);
			} else if (answer == "b"){
				myState = States.garden_7;
				print ("question 1b");	
			} else if (answer == "c"){
				myState = States.garden_how;
				ReturnButton.SetActive(true);
				choices.SetActive(false);
			}
		}
		
		
	}
	
}
