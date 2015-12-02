﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	//public SpriteRenderer spriteRenderer; lecture 83
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
		corridor_0,
		final_0,
		endscreen
	};
	private States myState;
	// Use this for initialization
	void Start () {
		
		myState = States.tv_0;
	}
	
	// Update is called once per frame
	void Update () {

		print (myState);
		if (myState == States.tv_0) {state_tv_0();}
		else if (myState == States.tv_1) {state_tv_1();}
		else if (myState == States.tv_2) {state_tv_2();}
		else if (myState == States.tv_3) {state_tv_3();}
		else if (myState == States.tv_internet) {state_tv_internet();}
		else if (myState == States.tv_playstation) {state_tv_playstation();}

		else if (myState == States.garden_0) {state_garden_0();}
		else if (myState == States.garden_1) {state_garden_1();}
		else if (myState == States.garden_2) {state_garden_2();}
		else if (myState == States.garden_3) {state_garden_3();}
		else if (myState == States.garden_4) {state_garden_4();}
		else if (myState == States.garden_5) {state_garden_5();}
		else if (myState == States.garden_6) {state_garden_6();}
		else if (myState == States.garden_how) {state_garden_how();}
		else if (myState == States.garden_who) {state_garden_who();}
		else if (myState == States.garden_7) {state_garden_7();}
		else if (myState == States.garden_old) {state_garden_old();}
		else if (myState == States.garden_hat) {state_garden_hat();}
		else if (myState == States.garden_8) {state_garden_8();}

		else if (myState == States.jungle_0) {state_jungle_0();}
		else if (myState == States.jungle_1) {state_jungle_1();}
		else if (myState == States.jungle_2) {state_jungle_2();}
		else if (myState == States.jungle_center_1) {state_jungle_center_1();}
		else if (myState == States.jungle_left_1) {state_jungle_left_1();}
		else if (myState == States.jungle_right_1) {state_jungle_right_1();}
		else if (myState == States.jungle_center_2) {state_jungle_center_2();}
		else if (myState == States.jungle_left_2) {state_jungle_left_2();}
		else if (myState == States.jungle_right_2) {state_jungle_right_2();}
		else if (myState == States.jungle_center_3) {state_jungle_center_3();}
		else if (myState == States.jungle_left_3) {state_jungle_left_3();}
		else if (myState == States.jungle_right_3) {state_jungle_right_3();}
		
		else if (myState == States.temple_0) {state_temple_0();}
		else if (myState == States.temple_1) {state_temple_1();}
		else if (myState == States.temple_2) {state_temple_2();}
		else if (myState == States.temple_3) {state_temple_3();}
		else if (myState == States.temple_4) {state_temple_4();}
		else if (myState == States.temple_5) {state_temple_5();}
		else if (myState == States.temple_card) {state_temple_card();}
		else if (myState == States.temple_stun) {state_temple_stun();}
		else if (myState == States.temple_6) {state_temple_6();}
		else if (myState == States.temple_7) {state_temple_7();}
		else if (myState == States.temple_8) {state_temple_8();}
		else if (myState == States.temple_9) {state_temple_9();}
		else if (myState == States.temple_10) {state_temple_10();}
		else if (myState == States.temple_11) {state_temple_11();}
		else if (myState == States.temple_11_1) {state_temple_11_1();}
		else if (myState == States.temple_attack_0) {state_temple_attack_0();}
		else if (myState == States.temple_jump_0) {state_temple_jump_0();}
		else if (myState == States.temple_back_0) {state_temple_back_0();}
		else if (myState == States.temple_attack_1) {state_temple_attack_1();}
		else if (myState == States.temple_jump_1) {state_temple_jump_1();}
		else if (myState == States.temple_back_1) {state_temple_back_1();}
		else if (myState == States.temple_attack_2) {state_temple_attack_2();}
		else if (myState == States.temple_jump_2) {state_temple_jump_2();}
		else if (myState == States.temple_back_2) {state_temple_back_2();}

		else if (myState == States.montain_0) {state_montain_0();}
		else if (myState == States.montain_rope_0) {state_montain_rope_0();}
		else if (myState == States.montain_jump_0) {state_montain_jump_0();}
		else if (myState == States.montain_fly_0) {state_montain_fly_0();}
		else if (myState == States.montain_cloud_1) {state_montain_cloud_1();}
		else if (myState == States.montain_rope_1) {state_montain_rope_1();}
		else if (myState == States.montain_bridge_1) {state_montain_bridge_1();}
		else if (myState == States.montain_1) {state_montain_1();}
		else if (myState == States.montain_map_a) {state_montain_map_a();}
		else if (myState == States.montain_map_z) {state_montain_map_z();}
		else if (myState == States.montain_map_e) {state_montain_map_e();}

	}

	void state_tv_0(){
		text.text = "Télévision : FLASH INFO SPECIAL. Des archéologues ont découvert l’existence d’un grand trésor caché"+
					" dans la pyramide du Pharaon ToutenKarton. Les plus grands aventuriers du monde partent déjà à sa"+
					" recherche, qui pourra bien découvrir ce trésor en premier ? …\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.tv_1;
		}
	}

	void state_tv_1(){
		text.text = " Le Héros : Qu’est ce que j’aimerais trouver ce trésor ! J’ai envie d’une autre vie, pleine d’aventure\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.tv_2;
		}
	}

	void state_tv_2(){
		text.text = " Mais sans Carte au Trésor je n’y arriverais jamais. Et puis je n’ai pas du tout le sens de l’orientation !\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.tv_3;
		}
	}

	void state_tv_3(){
		text.text = "Comment je pourrais me débrouiller ?\n\n" +
				"- Chercher la carte sur internet (A)\n\n"+
				"- Aller dans le jardin (Z)\n\n"+
				"- Jouer à la Playstation (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.tv_internet;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.garden_0;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.tv_playstation;}
	}

	void state_tv_internet(){
		text.text = "Il n'y a rien sur internet à propos de cette carte au trésor...\n\n"+
					"Retour (R)"; 
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.tv_3;
		}
	}

	void state_tv_playstation(){
		text.text = "Non ce n'est pas le moment de jouer, je dois partir à l'aventure ! \n\n"+
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.tv_3;
		}
	}

	// JARDIN

	void state_garden_0(){
		text.text = " Héros : Rien de tel qu’un peu d’air frais pour s’aérer les idées. Il faut que je réfléchisse à une solution pour retrouver ce fameux trésor avant les autres.\n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.garden_1;
		}
	}

	void state_garden_1(){
		text.text = " PAFFFFFFF (grosse explosion de fumée dans le jardin du Héros)\n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.garden_2;
		}
	}

	void state_garden_2(){
		text.text = " Le Héros : Waaaaah. J’en suis tombé à la renverse. C’était quoi ce bazar à l’instant ?\n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.garden_3;
		}
	}

	void state_garden_3(){
		text.text = " Une voix : T’es un peu trouillard pour un aventurier ! Si de la simple fumée de te fait peur, tu ne pourras jamais retrouver le trésor de ToutenKarton ! \n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.garden_4;
		}
	}

	void state_garden_4(){
		text.text = " Héros : Hé mais, comment tu sais pour le trésor ?\n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.garden_5;
		}
	}

	void state_garden_5(){
		text.text = "Une voix : Je suis le seigneur de la Magie, c’est facile pour moi de lire dans tes pensées ! Enfin non, en vrai tu es l’homme de la prophétie, et je suis venu te chercher pour te confier la Carte au Trésor. Mais ça aurait été stylé que je puisse lire dans tes pensées hein ? \n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.garden_6;
		}
	}

	void state_garden_6(){
		text.text = "Héros : Ouais…. Mais du coup j’aurais quelques question à te poser:\n\n"+
				"- Qui es tu ? (A)\n\n"+
				"- Que fais tu ici ? (Z)\n\n"+
				"- Comment tu es apparu dans mon jardin ?(E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.garden_who;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.garden_7;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.garden_how;}
	}

	void state_garden_who(){
		text.text = "Je te l'ai dit à l'instant, je suis le Seigneur de la Magie. \n\n" +
			"Retour (R)"; 
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.garden_6;
		}
	}

	void state_garden_how(){
		text.text = "Avec mes puissants pouvoirs magiques, et un peu de talc \n\n" +
			"Retour (R)"; 
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.garden_6;
		}
	}

	void state_garden_7(){
		text.text = "Seigneur de la Magie : Je suis ici car tu es l'enfant de le prophétie et tu dois absolument trouver le trésor avant tous les autres aventuriers.\n\n"+
					"Ah ouais ? Mais c'est trop cool ça ! Et sinon...\n\n"+
					"- Tu as quel age ? (A)\n\n"+
					"- Tu me donnes ton chapeau ? (Z)\n\n"+
					"- Tu me donnes la carte ?(E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.garden_old;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.garden_hat;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.garden_8;}
	}

	void state_garden_old(){
		text.text = "J'ai 1999 ans, mais tu peux arrondir à 2000 ans. \n\n" +
			"Retour (R)"; 
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.garden_7;
		}
	}
	
	void state_garden_hat(){
		text.text = "Un simple mortel comme toi ne peut pas porter un chapeau de puissant magicien comme le mien. \n\n" +
			"Retour (R)"; 
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.garden_7;
		}
	}

	void state_garden_8(){
		text.text = "Merci ! C'est parti pour l'Egypte ! Je prends le premier vol.\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.jungle_0;
		}
	}

	// JUNGLE

	void state_jungle_0(){
		text.text = "Héros : Après un vol direct pour l’Egypte, et plusieurs jours de route à dos de dromadaire dans le désert, je dois me repérer dans la jungle et le désert grâce à ma carte.\n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.jungle_1;
		}
	}

	void state_jungle_1(){
		text.text = "Alors si je lis correctement, il est écrit :\n\n" +
					"- Ne prenez jamais le même chemin\n\n" +
					"- Des trois routes, il n’y en a qu’une de correcte\n\n" +
					"- Ne prenez jamais le même chemin\n\n" +
					"- Chaque mauvaise route vous fera revenir à la case départ\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.jungle_2;
		}
	}

	void state_jungle_2(){
		text.text = "Quel chemin je dois prendre ?\n\n"+
					"Je me trouve à l'entrée de la jungle : \n\n"+
					"Je prends la voie de gauche  (A)\n\n"+
					"Je prends la voie du centre  (Z)\n\n"+
					"Je prends le voie de droite  (E)\n\n";

		if (Input.GetKeyDown (KeyCode.A)) {myState = States.jungle_left_1;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.jungle_center_1;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.jungle_right_1;}
	}

	void state_jungle_left_1(){
		text.text = "Il y a pleins de crocodiles par là, je ne peux pas passer.\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.jungle_2;
		}
	}

	void state_jungle_right_1(){
		text.text = "De nombreuses pierres bloquent le passage, je ferais mieux de rebrousser chemin\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.jungle_2;
		}
	}

	void state_jungle_center_1(){
		text.text = "Je viens de la voie du centre. Me voici à nouveau devent 3 chemins.\n\n "+
					"Quel chemin je dois prendre ?\n\n"+
					"Je prends la voie de gauche  (A)\n\n"+
					"Je prends la voie du centre  (Z)\n\n"+
					"Je prends le voie de droite  (E)\n\n";
		
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.jungle_left_2;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.jungle_center_2;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.jungle_right_2;}
	}

	void state_jungle_left_2(){
		text.text = "Il y a pleins de crocodiles par là, je ne peux pas passer.\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.jungle_center_1;
		}
	}
	
	void state_jungle_center_2(){
		text.text = "De nombreuses pierres bloquent le passage, je ferais mieux de rebrousser chemin\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.jungle_center_1;
		}
	}
	
	void state_jungle_right_2(){
		text.text = "Je viens de la voie de droite. Me voici à nouveau devent 3 chemins.\n\n "+
			"Quel chemin je dois prendre ?\n\n"+
				"Je prends la voie de gauche  (A)\n\n"+
				"Je prends la voie du centre  (Z)\n\n"+
				"Je prends le voie de droite  (E)\n\n";
		
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.jungle_left_3;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.jungle_center_3;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.jungle_right_3;}
	}

	void state_jungle_center_3(){
		text.text = "De nombreuses pierres bloquent le passage, je ferais mieux de rebrousser chemin\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.jungle_right_2;
		}
	}

	void state_jungle_right_3(){
		text.text = "De nombreuses pierres bloquent le passage, je ferais mieux de rebrousser chemin\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.jungle_right_2;
		}
	}

	void state_jungle_left_3(){
		text.text = "Héros : Cool ! Me voilà sorti de ce labyrinthe mais la carte s’arrête ici et toujours pas de trace de la" +
					" Pyramide de ToutanKarton. Par contre, j’aperçois un temple Ninja, je pourrais peut être leur demander mon"+
					" chemin.\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_0;
		}
	}

	// TEMPLE

	void state_temple_0(){
		text.text = "Garde : Bonjour l’étranger, qui es tu ?\n\n"+
					"Héros : Moi ?\n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_1;
		}
	}

	void state_temple_1(){
		text.text = "Garde : Non je parlais au fantôme derrière toi !\n\n"+
			"Héros : Comment ça ?! Ou ça ?!  J’ai peuuuuuuur des fantômes !\n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_2;
		}
	}

	void state_temple_2(){
		text.text = "Garde : Non mais il est bête celui là…. JE BLAGUAIS IMBÉCILE. OUI TOI, QUI ES TU ?\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_3;
		}
	}

	void state_temple_3(){
		text.text = "Héros : Ah ça va pas la peine de gueuler aussi. Je suis un aventurier à la recherche de la Pyramide de Toutenkarton.\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_4;
		}
	}

	void state_temple_4(){
		text.text = "Garde : Pour atteindre la Pyramide de ToutenKarton il te faut traverser le Temple Ninja."+
					" Mais attention, il te faudra affronter le Champion du Temple si tu veux avoir le droit de traverser,"+
					" ou alors payer 1 000 000 €. Pour information,  on accepte pas les chèques mais on prends la carte.\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_5;
		}
	}

	void state_temple_5(){
		text.text = "Que choisis tu de faire ?\n\n "+
					"- Payer en carte bleue  (A)\n\n"+
					"- Assomer le garde(Z)\n\n"+
					"- Accepter d'affronter le Champon du Temple(E)\n\n";
		
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.temple_card;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.temple_stun;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.temple_6;}
	}

	void state_temple_card(){
		text.text = "Je n'ai pas assez d'argent sur mon compte en banque.\n\n "+
					"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_5;
		}
	}

	void state_temple_stun(){
		text.text = "Avec son casque en fer, je ne pourrais jamais l'assomer.\n\n "+
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_5;
		}
	}

	void state_temple_6(){
		text.text = "Garde : Tiens tu es moins froussard que je ne le pensais ! Suis moi je vais t’emmener dans le Dojo.\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_7;
		}
	}

	void state_temple_7(){
		text.text = "Maitre Ninja  : Bonjour valeureux étranger. Voici mon élève et Champion du Dojo : Rambo Binlacassette.\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_8;
		}
	}

	void state_temple_8(){
		text.text = "Maitre Ninja  : Vous pouvez vous saluer…\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_9;
		}
	}

	void state_temple_9(){
		text.text = "...COMBATTEZ !!\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_10;
		}
	}

	void state_temple_10(){
		text.text = "Héros : Ce Rambo à l'air costaud, je en dois pas l'attaquer de front !\n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_11;
		}
	}
	
	void state_temple_11(){
		text.text = "Attention, Rambo te fonce dessus ! Que fais tu ? \n\n"+
					"- Attaquer  (A)\n\n"+
					"- Sauter  (Z)\n\n"+
					"- Reculer (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.temple_attack_0;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.temple_jump_0;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.temple_back_0;}
	}

	void state_temple_attack_0(){
		text.text = "Rambo a evité facilement ton attaque.\n\n "+
					"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_11;
		}
	}

	void state_temple_jump_0(){
		text.text = "Tu as pris l'assault de Rambo de plein fouet ! Si tu continues comme ça tu vas perdre, fais attention.\n\n "+
					"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_11;
		}
	}
	
	void state_temple_back_0(){
		text.text = "Bravo, tu as évité sa charge.\n\n"+
					"Rambo veut te balayer avec son épee ! Que fais tu ? \n\n"+
					"- Attaquer  (A)\n\n"+
					"- Sauter  (Z)\n\n"+
					"- Reculer (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.temple_attack_1;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.temple_jump_1;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.temple_back_1;}
	}

	void state_temple_attack_1(){
		text.text = "Rambo a evité facilement ton attaque.\n\n "+
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_11;
		}
	}
	
	void state_temple_back_1(){
		text.text = "Rambo t'as touché aux jambes et tu tombes à la renverse. Relève toi vite !\n\n "+
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_11;
		}
	}
	
	void state_temple_jump_1(){
		text.text = "Super ! Il n'arrive pas à te toucher.\n\n"+
			"Rambo est essouflé et à bout de force. Que fais tu ? \n\n"+
				"- Attaquer  (A)\n\n"+
				"- Sauter  (Z)\n\n"+
				"- Reculer (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.temple_attack_2;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.temple_jump_2;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.temple_back_2;}
	}

	void state_temple_jump_2(){
		text.text = "Rambo a eu le temps de se reposer. Il est pret à combattre à nouveau\n\n "+
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_11;
		}
	}
	
	void state_temple_back_2(){
		text.text = "Rambo a eu le temps de se reposer. Il est pret à combattre à nouveau\n\n "+
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.temple_11;
		}
	}

	void state_temple_attack_2(){
		text.text = "Joli coup ! Le Champion du Dojo est KO.\n\n "+
					"Tu as gagné !\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_11_1;
		}
	}

	void state_temple_11_1(){
		text.text = "Maitre Ninja  : Bravo tu as vaincu mon meilleur élève, tu mérites l’épée légendaire du Dragon Noir."+
					" Prends en soin, elle est extrêmement puissante contre les forces du mal qui rodent autour de la Pyramide"+
					" de Tontankarton !\n\n "+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_12;
		}
	}
	void state_temple_12(){
		text.text = "Héros : Merci le vieux ! Elle est trop stylé ton épée, avec ça j’ai trop la classe ! \n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_13;
		}
	}

	void state_temple_13(){
		text.text = "Héros : On se revoit bientôt, j’ai de la route à faire, Ciao ! \n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_14;
		}
	}

	void state_temple_14(){
		text.text = "Héros : Et au fait, c’est par où après ? C’est que je suis pas trop du coin."+
					" Moi à la base je suis de Temara...la jungle, les temples, les pyramides y’en pas des masses par chez nous.\n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_15;
		}
	}

	void state_temple_15(){
		text.text = "Maitre Ninja : Tu traverses les 3 grandes montagnes aux Neiges éternelles et tu prends la deuxième"+
					" à droite après le cascade, puis au feu de bois tu serres à gauche le long des orties,"+
					" ensuite tu pourras pas la rater !\n\n"+
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.temple_16;
		}
	}
	void state_temple_16(){
		text.text = "Héros : Okay merci Papy ! A la prochaaiiiiine!\n\n" +
					"Continuer vers la Montagne(Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_0;
		}
	}
	

	void state_montain_0(){
		text.text = "Héros : ça m’a l’air compliqué de traverser ces trois montagnes. Comment je dois m’y prendre ?\n\n"+
					"D'abord je dois passer de la première montagne à la seconde montage\n\n" +
					"- Me suspendre à une corde  (A)\n\n"+
					"- Sauter  (Z)\n\n"+
					"- Voler (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.montain_rope_0;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.montain_jump_0;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.montain_fly_0;}
	}


	void state_montain_jump_0(){
		text.text = "Héros : C'est un saut d'au moins 100 mètres que je dois faire. C'est impossible, je ne suis pas Spider-Man.\n\n" +
					"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_0;
		}
	}

	void state_montain_fly_0(){
		text.text = "Héros : C'est un vol d'au moins 100 mètres que je dois faire. C'est impossible, je ne suis pas SuperMan.\n\n" +
					"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_0;
		}
	}
	
	
	void state_montain_rope_0(){
		text.text = "Héros : Me voici sur la deuxième montagne. Comment je me rends à la dernière montagne ?\n\n" +
					"- Marcher sur les nuages (A)\n\n"+
					"- Me suspendre à une corde (Z)\n\n"+
					"- Prendre le pont (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.montain_cloud_1;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.montain_rope_1;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.montain_bridge_1;}
	}

	void state_montain_cloud_1(){
		text.text = "Héros : Marcher sur des nuages... T'as pas une meilleure idée ?\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_rope_0;
		}
	}

	void state_montain_rope_1(){
		text.text = "Bah finalement c’était pas trop compliqué.\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_1;
		}
	}

	void state_montain_bridge_1(){
		text.text = "Bah finalement c’était pas trop compliqué.\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_1;
		}
	}

	void state_montain_1(){
		text.text = "Héros : Donc si je me souviens bien...\n\n"+
				"- je prends la deuxième à gauche après les orties, puis au feu de bois tu serres à gauche le long de la cascade(A)\n\n"+
				"- je prends la deuxième à gauche après le cascade, puis au feu de bois tu serres à gauche le long des orties  (Z)\n\n"+
				"- je prends la deuxième à droite après le cascade, puis au feu de bois tu serres à gauche le long des orties (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.montain_map_a;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.montain_map_z;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.montain_map_e;}
	}

	void state_montain_map_a(){
		text.text = "Zut je me suis perdu\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_1;
		}
	}

	void state_montain_map_z(){
		text.text = "Je crois que j'ai pris le mauvais chemin\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.montain_1;
		}
	}
	
	void state_montain_map_e(){
		text.text = "Youpi ! Voillà la Pyramide de Toutankarton !!!\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_0;
		}
	}

	// PYRAMIDE

	void state_pyramid_0(){
		text.text = "Youpi ! Voillà la Pyramide de Toutankarton !!!\n\n" +
			"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_1;
		}
	}

	void state_pyramid_1(){
		text.text = "Je ne suis plus qu'à quelques mètres du trésor.\n\n" +
					"Allons à l'intérieur de cette pyramide.\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_2;
		}
	}

	void state_pyramid_2(){
		text.text = "Héros : Jusqu’à présent j’étais un aventurier débutant, sauf que j’ai vu tous les films d’Indiana Jones"+
					", et j’ai terminé tous les Tomb Raider, je connais les pièges de Pyramides, on me l’a fait pas à moi !\n\n" +
					"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_3;
		}
	}

	void state_pyramid_3(){
		text.text = "Héros : Jusqu’à présent j’étais un aventurier débutant, sauf que j’ai vu tous les films d’Indiana Jones"+
			", et j’ai terminé tous les Tomb Raider, je connais les pièges de Pyramides, on me l’a fait pas à moi !\n\n" +
				"Continuer (Espace)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_4;
		}
	}

	void state_pyramid_fall(){
		text.text = "Aaaaaaaaaaaaah.\n\n" +
			"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_4;
		}
	}
	
	void state_pyramid_4(){
		text.text = "Héros : Me voici dans un long couloir à l'intérieur de la pyramide \n\n" +
					"- Inspecter le sol(A)\n\n"+
					"- Inspecter la plafond(Z)\n\n"+
					"- Avancer (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.pyramid_floor_0;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.pyramid_roof_0;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.pyramid_walk_0;}
	}

	void state_pyramid_roof_0(){
		text.text = "Beurk, il y a des toiles d'araignés.\n\n" +
					"Retour (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_4;
		}
	}

	void state_pyramid_walk_0(){
		text.text = "Aaaaaaaaaaaaah.\n\n" +
					"Recommencer (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_fall;
		}
	}
	
	void state_pyramid_floor_0(){
		text.text = "Héros : Tiens, un fil presque invisible est plus  \n\n" +
					"- Couper le fil(A)\n\n"+
					"- Enjamber le fil(Z)\n\n"+
					"- Marcher sur le fil (E)\n\n";
		if (Input.GetKeyDown (KeyCode.A)) {myState = States.pyramid_cut_0;}
		else if (Input.GetKeyDown (KeyCode.Z)) {myState = States.pyramid_stepup_0;}
		else if (Input.GetKeyDown (KeyCode.E)) {myState = States.pyramid_walkon_0;}
	}

	void state_pyramid_cut_0(){
		text.text = "Aaaaaaaaaaaaah.\n\n" +
					"Recommencer (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_fall;
		}
	}
	
	void state_pyramid_walkon_0(){
		text.text = "Aaaaaaaaaaaaah.\n\n" +
					"Recommencer (R)";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_fall;
		}
	}

	void state_pyramid_stepup_0(){
		text.text = "Héros : Me voilà devant le tombeau qui doit certainement contenir le trésor, comment je vais bien pouvoir l'ouvrir ?\n\n" +
					"- Appuyer sur le visage du tombeau\n\n"+
					"- Appuyer sur la poitrine du tombeau (Z)\n\n"+
					"- Appuyer sur les jambes du tombeau (E)\n\n";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_5;
		}
	}

	void state_pyramid_stepup_5(){
		text.text = "Héros : Me voilà devant le tombeau qui doit certainement contenir le trésor, comment je vais bien pouvoir l'ouvrir ?\n\n" +
					"- Appuyer sur le visage du tombeau\n\n"+
					"- Appuyer sur la poitrine du tombeau (Z)\n\n"+
					"- Appuyer sur les jambes du tombeau (E)\n\n";
		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.pyramid_5;
		}
	}
	
	
	
	
}
	
	