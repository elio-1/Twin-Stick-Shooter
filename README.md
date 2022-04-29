# Twin-Stick-Shooter
First project in Unity

The goal of this project was to learn the basics of unity.

Play the game: https://elio1.itch.io/twin-stick-shooter




Modification des Scripts Template pour changer le contenu de base d'un Script

Project Settings > Input Manager

Scripts :
- Region

Unity Life Cycle : https://docs.unity3d.com/Manual/ExecutionOrder.html
- Awake : L'objet est mis en mémoire
- Start
- Update : A chaque frame
- FixedUpdate

Input.GetAxis : Interpolation linéaire ( on augmente graduellement la valeur en 0 et 1 ou en 0 et -1 ) en fonction de Sensitivity & Gravity
Input.GetAxisRaw : Pas Interpolation linéaire ( Lerp = Linear Interpolation )

Rigidbody : Gérer la physique d'un Game Object
- isKinematic : Quand isKinematic est actif les calculs physiques du moteur n'est plus appliqués sur le Game Object
- velocity

GetComponent<TypeDeComponent>() : Permet de récupérer une component du <Type> si il existe sur le Game Object

Pro Builder

Vector2 : X,Y
Vector3 : X,Y,Z
Vector4 : X,Y,Z,A

Accessibilité des variables : public, private, protected
MonoBehaviour : La class parente qui permet de créer un nouveau component dans Unity
using : permet d'ajouter une library au script

[SerializeField] : Permet de rendre une variable privée modifiable via l'inspector
Debug.Log : Permet d'afficher un message dans la console d'Unity
  
  Project Settings : 
Créer de nouveaux axes : Attention au configuration des manettes
Invert : permet d'inverer les valeurs sur l'axe

Les gâchettes des manettes ( RT, LT ) exprime un axe : Si on appuie sur RT on a une valeur positive

Quaternion : Ultracomplexe sert à exprimer une rotation dans le moteur d'Unity

Quaternion.LookRotation : https://docs.unity3d.com/ScriptReference/Quaternion.LookRotation.html

Euler Angles : Expression des rotations sur les 3 axes (X,Y,Z) en dégrés

Vector3.zero : C'est un vecteur ayant pour valeur 0 en X, Y & Z
if( _orientationInput != Vector3.zero )
_direction = Vector3.zero;

Rigidbody.MoveRotation : https://docs.unity3d.com/ScriptReference/Rigidbody.MoveRotation.html
  
  Faire tirer le joueur

Instantiate( prefab ) : https://docs.unity3d.com/ScriptReference/Object.Instantiate.html

Destroy(L'objet qu'on veut détruire, temps)

Quaternion.RotateTowards : permet de tourner progressivement vers une rotation
https://docs.unity3d.com/ScriptReference/Quaternion.RotateTowards.html

Time.timesinceLevelLoaded : Temps écoulé depuis le lancement de la Scene
Time.time : Temps écoulé depuis le lancement de l'application
Time.deltaTime : Temps écoulé depuis la dernière frame (Update)
Time.fixedDeltaTime : Temps écoulé depuis la dernière frame physique (FixedUpdate)

OnTriggerEnter
OnCollisionEnter

Project Settings > Physics > Layer Collision Matrix : Permet d'activer ou désactiver les collisions entre des layers de Game Objects

Les conditions
if
if/else
if/else if.../else
switch
    case VALEUR:
    break;

>, >=, ==, !=, <, <=
&&
||

Boutons Toolbar :
Play : CTRL + P
Pause : CTRL + SHIFT + P
Step : CTRL + ALT + P
  
  Scriptable Objects :
Une sorte de variable globale, qui peut communiquer/etre utilisé par n'importe quel scripts (Components)
C'est une Asset Unity, c'est un fichier sur le PC

Pour créer un ScriptableObject, la class doit hérité de ScriptableObject et non de MonoBehaviour.

CreateAssetMenu( fileName = "newStringVariable", menuName = "Variables/StringVariable") :
Permet de créer un sous-menu dans le menu de la Project Window pour créer de nouveau Scriptable Objects
fileName : Nom par défaut du nouveau fichier
menuName : C'est le nom et l'arborescence du sous-menu

Variables/SousMenu/SousMenu2/StringVariable

OnColliderEnter
OnTriggerEnter

Layers de collision & Project Settings > Physics > Layers Collision Matrix

Tags
gameObject.CompareTag("tag") : Fonction qui return TRUE si le gameObject à le tag précisé entre les paranthèses

Build :
- WebGL : Dans Project Settings > Player > Onglet WebGL > Publish Settings > Compression Format
IL FAUT DESACTIVER LA COMPRESSION ! 
- Windows
- Project Settings > Player : pour modifier les paramètres du Build

Portfolio :
- itch.io
- gamejolt
- newgrounds
- kongregate
- armor games

gameObject.SetActive( false ) || gameObject.SetActive( true ) : permet de désactive ou activer un Game Object

FindGameObjectsWithTag("tag") : Permet de trouver tous les GameObjects présents dans la Scene avec le tag précisé

Il est conseillé de faire un Script GameManager pour gérer les conditions de victoire et défaite 
du jeu.
  
  
