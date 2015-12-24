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

	//PICTURES
	public GameObject Plans; // Assign in inspector
	public GameObject MainHouse;
	public GameObject Tv;
	public GameObject Garden;

	enum States {
		initial,
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
		if (Application.loadedLevelName == "Game") {
			myState = States.initial;
			isShowingAnswer = false;
			choices.SetActive(isShowingAnswer);
			
			isShowingContinu = true;
			ContinuerButton.SetActive(isShowingContinu);
			
			ReturnButton.SetActive(false);
		}

		else if (Application.loadedLevelName == "garden") {
			myState = States.garden_0;
			isShowingAnswer = false;
			choices.SetActive(isShowingAnswer);
			
			isShowingContinu = true;
			ContinuerButton.SetActive(isShowingContinu);
			
			ReturnButton.SetActive(false);
		}

		else if (Application.loadedLevelName == "jungle"){
			myState = States.jungle_0;
			
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
		print (Application.loadedLevelName);
	}

	public void NoPlansLevel1() {
		MainHouse.SetActive (false);
		Tv.SetActive (false);
		Garden.SetActive (false);
	}

	public void ModeContinu(){
		choices.SetActive (false);
		ContinuerButton.SetActive (true);
		ReturnButton.SetActive(true);
	}

	public void ModeAnswer(){
		choices.SetActive (true);
		ContinuerButton.SetActive (false);
		ReturnButton.SetActive(false);
	}

	public void ModeReturn(){
		ReturnButton.SetActive(true);
		choices.SetActive(false);
		ContinuerButton.SetActive (false);
	}
	
	public void TvScene0(){
		NoPlansLevel1();
		if (myState  == States.initial) {
			ModeContinu();
			story.text = "Il était un fois, une personne ordinaire dans une maison ordinaire...";
			MainHouse.SetActive(true);
			
		}

		else if (myState  == States.tv_0) {
			ModeContinu();
			story.text = "Télévision : FLASH INFO SPECIAL. Des archéologues ont découvert l’existence d’un grand trésor caché" +
				" dans la pyramide du Pharaon ToutenKarton. Les plus grands aventuriers du monde partent déjà à sa" +
					" recherche, qui pourra bien découvrir ce trésor en premier ? …\n\n";
			MainHouse.SetActive(true);

		}
		
		else if (myState  == States.tv_1) {
			ModeContinu();
			story.text = " Le Héros : Qu’est ce que j’aimerais trouver ce trésor ! J’ai envie d’une autre vie, pleine d’aventure\n\n";
			MainHouse.SetActive(true);
			Tv.SetActive(true);
		}
		
		else if (myState  == States.tv_2) {
			ModeContinu();
			story.text = " Mais sans Carte au Trésor je n’y arriverais jamais. Et puis je n’ai pas du tout le sens de l’orientation !\n\n";
		}
		
		else if (myState  == States.tv_3) {
			ModeAnswer();
			story.text = "Comment je pourrais me débrouiller ?";
			answerA.text = "Chercher la carte sur internet";
			answerB.text = "Aller dans le jardin";
			answerC.text = "Jouer à la Playstation";
		}
		
		else if (myState  == States.tv_internet) {
			ModeReturn();
			story.text = "Il n'y a rien sur internet à propos de cette carte au trésor...";
		}
		
		else if (myState  == States.garden_0) {
			ModeContinu();
			story.text = "Héros : Rien de tel qu’un peu d’air frais pour s’aérer les idées. Il faut que je réfléchisse à une solution pour retrouver ce fameux trésor avant les autres.";
		}
		
		else if (myState  == States.tv_playstation) {
			ModeReturn();
			story.text = "Non ce n'est pas le moment de jouer, je dois partir à l'aventure !";
		}
		
		// GARDEN SECTION 
		
		else if (myState  == States.garden_0) {
			ModeContinu();
			story.text = "Héros : Rien de tel qu’un peu d’air frais pour s’aérer les idées. Il faut que je réfléchisse à une solution pour retrouver ce fameux trésor avant les autres.";
		}
		
		else if (myState  == States.garden_1) {
			ModeContinu();
			story.text = "PAAAAAAAF";
		}
		
		else if (myState  == States.garden_2) {
			ModeContinu();
			story.text = "Héros : Waaaaah. J’en suis tombé à la renverse. C’était quoi ce bazar à l’instant ?";
		}
		
		else if (myState  == States.garden_3) {
			ModeContinu();
			story.text = "Une voix : T’es un peu trouillard pour un aventurier ! Si de la simple fumée de te fait peur, tu ne pourras jamais retrouver le trésor de ToutenKarton !";
		}
		
		else if (myState  == States.garden_4) {
			ModeContinu();
			story.text = "Héros : Hé mais, comment tu sais pour le trésor ?";
		}
		
		else if (myState  == States.garden_5) {
			ModeContinu();
			story.text = "";
		}
		
		else if (myState  == States.garden_6) {
			ModeAnswer();
			story.text = "Héros : Ouais…. Mais du coup j’aurais quelques question à te poser:";
			answerA.text = "Qui es-tu ?";
			answerB.text = "Que fais-tu ici ?";
			answerC.text = "Comment tu es apparu dans mon jardin ?";
		}
		
		else if (myState  == States.garden_who) {
			ModeReturn();
			story.text = "Je te l'ai dit à l'instant, je suis le Seigneur de la Magie.";
		}
		
		else if (myState  == States.garden_7) {
			ModeAnswer();
			story.text = "Seigneur de la Magie : Je suis ici car tu es l'enfant de le prophétie et tu dois absolument trouver le trésor avant tous les autres aventuriers." +
				"Ah ouais ? Mais c'est trop cool ça ! Et sinon...";
			answerA.text = "Tu as quel age ?";
			answerB.text = "Tu me donnes ton chapeau ?";
			answerC.text = "Tu me donnes la carte ?";
		}
		
		else if (myState  == States.garden_how) {
			ModeReturn();
			story.text = "Avec mes puissants pouvoirs magiques, et un peu de talc";
		}
		
		else if (myState  == States.garden_old) {
			ModeReturn();
			story.text = "J'ai 1999 ans, mais tu peux arrondir à 2000 ans.";
		}
		
		else if (myState  == States.garden_hat) {
			ModeReturn();
			story.text = "Un simple mortel comme toi ne peut pas porter un chapeau de puissant magicien comme le mien.";
		}
		
		else if (myState  == States.garden_8) {
			ModeContinu();
			story.text = "Merci ! C'est parti pour l'Egypte ! Je prends le premier vol.";
		}

		// JUNGLE SECTION 

		else if (myState  == States.jungle_0) {
			ModeContinu();
			story.text = "Héros : Après un vol direct pour l’Egypte, et plusieurs jours de route à dos de dromadaire dans le désert, je dois me repérer dans la jungle et le désert grâce à ma carte.";
		}

		else if (myState  == States.jungle_1) {
			ModeContinu();
			story.text = "Héros : Voyons voir cette carte";
		}

		else if (myState  == States.jungle_2) {
			ModeAnswer();
			story.text = "Me voici devant la PREMIERE INTERSECTION.Quel chemin je dois prendre ?\n\n";
			answerA.text = "Voie de gauche";
			answerB.text = "Voie du milieu";
			answerC.text = "Voie de droite";
		}

		else if (myState  == States.jungle_left_1) {
			ModeReturn();
			story.text = "Il y a pleins de crocodiles par là, je ne peux pas passer.";
		}

		else if (myState  == States.jungle_right_1) {
			ModeReturn();
			story.text = "De nombreuses pierres bloquent le passage, je ferais mieux de rebrousser chemin";
		}

		else if (myState  == States.jungle_center_1) {
			ModeAnswer();
			story.text = "Me voici devant la 2EME INTERSECTION."+
				"Quel chemin je dois prendre ?\n\n";
			answerA.text = "Voie de gauche";
			answerB.text = "Voie du milieu";
			answerC.text = "Voie de droite";
		}

		else if (myState  == States.jungle_left_2) {
			ModeReturn();
			story.text = "Il y a pleins d'arraignées par là, je ne peux pas passer.";
		}
		
		else if (myState  == States.jungle_center_2) {
			ModeReturn();
			story.text = "Il y a une grande rivière qui bloque le passage";
		}

		else if (myState  == States.jungle_right_2) {
			ModeAnswer();
			story.text = "JMe voici devant la 3EME INTERSECTION.\n\n "+
				"Quel chemin je dois prendre ?\n\n";
			answerA.text = "Voie de gauche";
			answerB.text = "Voie du milieu";
			answerC.text = "Voie de droite";
		}

		else if (myState  == States.jungle_right_3) {
			ModeReturn();
			story.text = "Il y a trop de lianes et d'herbes hautes par là, je ne peux pas passer.";
		}
		
		else if (myState  == States.jungle_center_3) {
			ModeReturn();
			story.text = "Il y a un grand rocher qui bloque le passage";
		}

		else if (myState  == States.jungle_left_3) {
			ModeContinu();
			story.text = "Héros : Cool ! Me voilà sorti de ce labyrinthe mais la carte s’arrête ici et toujours pas de trace de la Pyramide de ToutanKarton.\n\n"+
						 " Par contre, j’aperçois un temple Ninja, je pourrais peut être leur demander mon chemin.";
		}

	}
	
	public void Continuer(){
		if (myState == States.initial) {
			myState = States.tv_0;
		} else if (myState == States.tv_0) {
			myState = States.tv_1;
		} else if (myState == States.tv_1) {
			myState = States.tv_2;
		} else if (myState == States.tv_2) {
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
		} else if (myState == States.jungle_0) {
			myState = States.jungle_1;
		} else if (myState == States.jungle_1) {
			myState = States.jungle_2;
		}
	}

	public void Return(){
		ModeAnswer();
		if (myState == States.tv_internet) {
			myState = States.tv_3;
		} else if (myState == States.tv_playstation) {
			myState = States.tv_3;
		} else if (myState == States.garden_who) {
			myState = States.garden_6;
		} else if (myState == States.garden_how) {
			myState = States.garden_6;
		} else if (myState == States.garden_hat) {
			myState = States.garden_7;
		} else if (myState == States.garden_old) {
			myState = States.garden_7;
		} else if (myState == States.jungle_left_1) {
			myState = States.jungle_2;
		} else if (myState == States.jungle_right_1) {
			myState = States.jungle_2;
		} else if (myState == States.jungle_left_2) {
			myState = States.jungle_center_1;
		} else if (myState == States.jungle_center_2) {
			myState = States.jungle_center_1;
		} else if (myState == States.jungle_center_3) {
			myState = States.jungle_right_2;
		} else if (myState == States.jungle_right_3) {
			myState = States.jungle_right_2;
		}
	}

	public void Answer(string answer){
		print (answer);
		if (myState  == States.tv_3) {
			if (answer == "a"){
				myState = States.tv_internet;
				ModeReturn();
			} else if (answer == "b"){
				myState = States.garden_0;
				Application.LoadLevel("garden");
			} else if (answer == "c"){
				myState = States.tv_playstation;
				ModeReturn();
			}

		} else if (myState  == States.garden_7) {
			if (answer == "a"){
				myState = States.garden_old;
				ModeReturn();
			} else if (answer == "b"){
				myState = States.garden_hat;
				ModeReturn();
			} else if (answer == "c"){
				myState = States.garden_8;
				ModeAnswer();
				Application.LoadLevel("jungle");
			}
			
		} else if (myState  == States.garden_6) {
			if (answer == "a"){
				myState = States.garden_who;
				ModeReturn();
			} else if (answer == "b"){
				myState = States.garden_7;
				ModeAnswer();
			} else if (answer == "c"){
				myState = States.garden_how;
				ModeReturn();
			}
		}  else if (myState  == States.jungle_2) {
			if (answer == "a"){
				myState = States.jungle_left_1;
				ModeReturn();
			} else if (answer == "b"){
				myState = States.jungle_center_1;
				ModeAnswer();
			} else if (answer == "c"){
				myState = States.jungle_right_1;
				ModeReturn();
			}
		} else if (myState  == States.jungle_center_1) {
			if (answer == "a"){
				myState = States.jungle_left_2;
				ModeReturn();
			} else if (answer == "b"){
				myState = States.jungle_center_2;
				ModeReturn();
			} else if (answer == "c"){
				myState = States.jungle_right_2;
				ModeAnswer();
			}
		} else if (myState  == States.jungle_right_2) {
			if (answer == "a"){
				myState = States.jungle_left_3;
				ModeAnswer();
			} else if (answer == "b"){
				myState = States.jungle_center_3;
				ModeReturn();
			} else if (answer == "c"){
				myState = States.jungle_right_3;
				ModeReturn();
			}
		}
	}
}
