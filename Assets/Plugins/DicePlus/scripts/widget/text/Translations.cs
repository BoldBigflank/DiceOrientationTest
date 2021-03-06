using UnityEngine;
using System.Collections.Generic;

public class Translations {
	
	public enum Key {
		CONNECTED = 0,
		SEARCHING,
		LOW_BATTERY,
		NOT_FOUND,
		DISCONNECTED,
		ROLL,
		TOO_NEW,
		TOO_OLD,
		BUY,
		HELP,
		ROLLER,
		WELCOME,
		GET_DICE,
		PRODUCT_WEBSITE,
		BUY_1_TEXT,
		BUY_2_TEXT,
		STEP_1,
		GET_TO_KNOW,
		STEP_2,
		STEP_2_TEXT,
		POWERED_BOARD_GAMES,
		STEP_3,
		STEP_3_TEXT,
		STEP_4,
		STEP_4_TEXT,
		FLIP_IT,
		STEP_5,
		STEP_5_TEXT,
		STEP_6,
		STEP_6_TEXT,
		MICRO_USB,
		STEP_7,
		STEP_7_TEXT1,
		STEP_7_TEXT2,
		STEP_7_TEXT3,
		STEP_1_TEXT,
		NO_BLUETOOTH,
		SEARCH_MORE
	}
	
	//used language
	string langcode;
	//singleton
	private static Translations instance = new  Translations();
	//translations
	Dictionary<string, List<string>> languages  = new Dictionary<string, List<string>> {
		{
			"en",
			new List<string> {
"CONNECTED",
"SEARCHING",
"LOW BATTERY",
"NOT FOUND",
"DISCONNECTED",
"ROLL",
"GAME IS INCOMPATIBLE",
"UPDATE DICE+",
"BUY DICE+",
"HELP",
"PLAY WITHOUT DICE+",
"Welcome!",
"GET DICE+",
"PRODUCT WEBSITE",
"Now you can enjoy an electronic version of board games on your tablet or other smart device. DICE+ is a universal board games controller sending results of your rolls or moves to your device via Bluetooth and thus offering you a completely new gaming experience. Buy DICE+ and invite your family and friends - because games like this are meant to be played together!",
"Do you enjoy an electronic version of board games enhanced with DICE+? Share this experience with others and get another DICE+ for them! Big variety of games will ensure a great entertainment to all of you!\n\nNote there are also games designed to be played with multiple controllers at once. Just check them and get more dice for a multiple fun gameplay!",
"Step 1 - Hello!",
"GET TO KNOW DICE+",
"Step 2 - About DICE+",
"DICE+ is a universal board games controller. It can make playing digital board games on a tablet or other smart device a great entertainment for everyone. You just throw the dice and DICE+ sends a result of each roll to your device via Bluetooth, providing a real-life experience and truly random gameplay. The fate is back in your hands!",
"POWERED BOARD GAMES",
"Step 3 - Powered Board Games",
"DICE+ preserves the experience of playing with a physical dice and empowers digital games to be played together! As a consequence, it gives rise to a new category of games called Powered Board Games.\n\nThe collection of games to be played with DICE+ is quite varied, just check them all and choose your favourite ones!",
"Step 4 - Turning On",
"How to turn DICE+ on?\nIt’s so easy! Just flip the dice upside down and it’s on and ready to use. The digits will light up in green.",
"FLIP IT 180°",
"Step 5 - Connecting DICE+",
"Having in mind your convenience, the connection is enabled automatically. Just enable Bluetooth on your device, launch a game compatible with DICE+ and turn the dice on. It will be flashing blue till the moment it’s connected. ",
"Step 6 - Charging DICE+",
"Even though this is a digital device, you don’t need to worry about the battery - it allows for up to 20 hours of continuous use when playing board games. The full charging cycle is about 2 hours long. You can charge it with any sort of powered USB port. No matter if it`s your phone charger or a PC slot. Just plug it in and wait until red color changes to green.",
"MICRO USB PLUG",
"Step 7 - Signalling",
"Digits flashing quick animation in red - DICE+ is discharged",
"Digits flashing blue - DICE+ is searching for a compatible game",
"Digits flashing from blue to green - the game has connected to DICE+",
"We are here to help you and present full options of this game!\n\nFirst of all, do you know how DICE+ can make the game more exciting for you and your friends?",
"Bluetooth disabled",
"Searching more DICE+"
			}
		},
		{ 
			"pl",
			new List<string> {
"POŁĄCZONY",
"WYSZUKUJE",
"NISKI POZIOM BATERII",
"NIE ZNALEZIONO",
"ROZŁĄCZONY",
"RZUT",
"GRA NIEKOMPATYBILNA",
"ZAKTUALIZUJ DICE+",
"KUP DICE+",
"POMOC",
"GRAJ BEZ DICE+",
"Witaj!",
"Zdobądź DICE+",
"Strona produktu",
"Od dziś możesz cieszyć się cyfrowymi wersjami gier planszowych na swoim tablecie lub innym dowolnym urządzeniu z kategorii smart. DICE+ jest uniwersalnym kontrolerem do gier planszowych przekazującym informację o rzucie lub ruchu do Twojego urządzenia dzięki technologii Bluetooth, zapewniając kompletnie nowe doznania związane z grą! Kup DICE+ i zaproś rodzinę czy znajomych - ponieważ gry są po to, żeby spędzać czas razem!",
"Podobają Ci się gry planszowe działające z DICE+ ? Podziel się swoją radością z innymi i zdobądź jeszcze jeden kontroler DICE+. Rozbudowana kolekcja gier zapewni Wam godziny ciągłej zabawy!\n\nUwaga, istnieją również gry stworzone by korzystać z kilku kontrolerów jednocześnie. Zdobądź więcej kostek, by mieć jeszcze więcej zabawy!",
"Krok 1 - Witaj!",
"Poznaj DICE+",
"Krok 2 - Informacje o DICE+",
"DICE+ jest uniwersalnym kontrolerem do gier planszowych. Dzięki niemu granie w gry planszowe na tablecie lub innym urządzeniu staję się rozrywką dla każdego. Po prostu rzucasz kostką a wynik jest przekazywany za pomocą Bluetooth do Twojego urządzenia elektronicznego, co zapewnia bardzo wciągającą rozgrywkę. Los znowu jest w Twoich rękach!",
"Powered Board Games",
"Krok 3 - Powered Board Games",
"Dzięki DICE+ możesz ponownie mieć przyjemność z gry kostką, grając razem! Dzięki DICE+ powstała nowa kategoria gier Powered Board Games.\n\nKolekcja gier dostępnych dla DICE+ jest bardzo zróżnicowana, sprawdź wszystkie i wybierz swoje ulubione!",
"Krok 4 - Włączanie",
"Jak włączyć DICE+ ?\nTo bardzo proste! Po prostu obróć kostkę do góry nogami, a włączy się sama! Cyfry zaczną mrugać na zielono. ",
"Obróć o 180°",
"Krok 5 - Podłączanie DICE+",
"Dla Twojej wygody połączenie nawiązuje się automatycznie. Po prostu włącz Bluetooth na swoim urządzeniu, uruchom grę, a następnie włącz DICE+. Do czasu połączenia kostka będzie mrugać na niebiesko.",
"Krok 6 - Ładowanie DICE+",
"Mimo iż jest to urządzenie elektroniczne, nie musisz martwić się o stan baterii - możesz grać w gry planszowe nawet do 20 godzin. Pełen cykl ładowania zajmuje do 2 godzin. W tym celu możesz użyć dowolnego portu USB. Nie ma znaczenia, czy to ładowarka do telefonu czy port Twojego komputera. Po prostu podłącz DICE+ i zaczekaj, aż czerwony kolor zmieni się w zielony.",
"PORT MICRO USB",
"Krok 7 - Sygnalizacja",
"Cyfry mrugające szybko na czerwono - DICE+ jest rozładowany",
"Cyfry mrugające na niebiesko - DICE+ wyszukuje gry",
"Cyfry mrugające na niebiesko, a potem na zielono - DICE+ połączył się",
"Chętnie pomożemy Tobie zapoznać się ze wszystkimi funkcjami gry!\n\nCzy wiesz, dlaczego DICE+ może sprawić że gry będą jeszcze bardziej ekscytujące dla Ciebie i Twoich znajomych?",
"Bluetooth wyłączony",
"Szukam kolejnych DICE+"
			}
		},
		{ 
			"de",
			new List<string> {
"VERBUNDEN",
"SUCHE",
"AKKU SCHWACH",
"NICHT GEFUNDEN",
"VERBINDUNG GETRENNT",
"WÜRFELN",
"DAS SPIEL IST NICHT KOMPATIBEL",
"AKTUALISIERE DICE+",
"KAUFE DICE+",
"HILFE",
"SPIELE OHNE DICE+",
"Willkommen!",
"HOL DIR DICE+",
"Produkt-Website",
"Nun kann man auf dem Tablet oder einem anderen Smartgerät elektronische Versionen von Brettspielen genießen. DICE+ ist ein universelles Brettspiel-Steuergerät, das die Ergebnisse deines Wurfs oder Zuges via Bluetooth auf dein elektronisches Gerät schickt und so ein völlig neues Spielerlebnis ermöglicht. Kaufe DICE+ und lade deine Familie und Freunde zum tollen Spieleabend ein - solche Spiele sind für mehrere Spieler gedacht!",
"Gefallen dir die elektronischen Versionen von Brettspielen, die mit DICE+ verbessert wurden? Teile deine Erfahrungen mit anderen und hole für sie ein weiteres DICE+! Eine große Auswahl von Spielen garantiert allen großartige Unterhaltung.\n\nBeachte, dass auch Spiele entwickelt wurden, die mit zwei Steuergeräten gleichzeitig zu spielen sind. Teste sie einfach und hole dir noch mehr Würfel für gemeinsamen Spielspaß!",
"Schritt 1 - Hallo! ",
"LERNE DICE+ KENNEN!",
"Schritt 2 - Alles über DICE+",
"DICE+ ist ein universelles Steuergerät für Brettspiele. Damit kann das Spielen von digitalen Brettspielen auf einem Tablet oder sonstigem Smartgerät zu einem großen Erlebnis werden. Wirf einfach den Würfel und DICE+ schickt das Ergebnis von jedem Wurf via Bluetooth auf dein elektronisches Gerät und sorgt so für echtes Spielgefühl und wirklich zufällige Spielergebnisse. Das Schicksal liegt wieder in deinen Händen!",
"POWERED BOARD GAMES",
"Schritt 3 - Powered Board Games",
"DICE+ bietet das echte Würfelerlebnis und ermöglicht das gemeinsame Spielen digitaler Brettspiele! Dadurch wurde eine völlig neue Kategorie von Spielen ins Leben gerufen: Powered Board Games.\n\nDie Auswahl von Spielen, die man mit DICE+ spielen kann, ist breit gefächert. Teste sie alle und wähle deine Favoriten!",
"Schritt 4 - Einschalten",
"Wie schalte ich den DICE+ ein?\nDas ist ganz leicht! Drehe einfach den Würfel um 180 Grad um und schon ist er eingeschaltet und zum Spielen bereit. Die Ziffern leuchten grün.",
"UMDREHEN UM 180 GRAD",
"Schritt 5 - DICE+ verbinden",
"Da wir immer an deinen Komfort denken, erfolgt die Verbindung von DICE+ automatisch. Schalte einfach die Bluetooth-Verbindung an deinem Smartgerät ein, starte ein mit DICE+ kompatibles Spiel und schalte den Spielwürfel ein. Er wird blau blinken, bis die Verbindung hergestellt ist.",
"Schritt 6 - DICE+ aufladen",
"Auch wenn es sich hier um ein elektronisches Gerät handelt, braucht man nicht ständig an die Batterie zu denken. Man kann ohne Weiteres bis zu 20 Stunden ununterbrochen mit aufgeladenen Batterien spielen. Der volle Ladezyklus dauert knapp 2 Stunden. Die Batterien können über jeden an eine Stromquelle angeschlossenen USB-Port geladen werden. Ganz egal, ob das ein Handy-Ladegerät oder ein Anschluss am Computer ist. Einfach einstecken und warten, bis die rote LED in grün übergeht.",
"MICRO-USB-STECKER",
"Schritt 7 - Signalanzeigen",
"Blinken die Ziffern schnell rot, ist der DICE+ entladen",
"Blinken die Ziffern blau sucht das DICE+ ein kompatibles Spiel",
"Blinken die Ziffern von blau nach grün, wurde die Verbindung zwischen DICE+ und einem Spiel hergestellt",
"Wir sind da, um dir zu helfen und alle Spieloptionen zu zeigen.\n\nZuerst wollen wir fragen, ob du schon weißt, wie aufregend ein DICE+ Gerät ein Brettspiel für dich und deine Freunde machen kann.",
"Bluetooth deaktiviert",
"Suche weitere DICE+"
			}
		},
		{ 
			"fr",
			new List<string> {
"CONNECTÉ",
"RECHERCHE…",
"BATTERIE FAIBLE",
"NON TROUVÉ",
"DÉCONNECTÉ",
"LANCER",
"LE JEU N'EST PAS COMPATIBLE",
"ACTUALISER DICE+",
"ACHETER DICE+",
"AIDE",
"JOUER SANS DICE+",
"Bienvenue !",
"OBTENIR DICE+",
"Site web du produit",
"Vous pouvez désormais profiter d'une version électronique des jeux de plateau sur votre tablette ou sur tout autre appareil de type Smart Device. DICE+ est un contrôleur universel de jeux de plateau qui envoie, par Bluetooth, les résultats de vos lancers de dés ou de vos mouvements à votre appareil, en vous offrant ainsi une nouvelle expérience de jeu. Achetez DICE+ et invitez votre famille et vos amis pour jouer tous ensemble ! ",
"Vous aimez la version électronique des jeux de plateau améliorée avec DICE+ ? Partagez cette expérience avec d'autres personnes et achetez un autre DICE+ pour elles ! Profitez tous d'une grande variété de jeux !\n\nVeuillez noter que certains jeux sont conçus pour être joués avec plusieurs contrôleurs en même temps. Découvrez lesquels et procurez-vous plus de dés pour jouer et vous amuser à plusieurs !",
"Étape 1 - Bonjour ! ",
"DÉCOUVREZ DICE+ !",
"Étape 2 - À propos de DICE+",
"DICE+ est un contrôleur universel de jeux de plateau. Il permet de faire profiter tout le monde de jeux de plateau numériques sur tablette ou sur tout autre appareil de type Smart Device. Lancez les dés et DICE+ envoie, par Bluetooth, le résultat de chaque lancer à votre appareil, en vous offrant une expérience réaliste et un gameplay aléatoire. Reprenez votre destin en main !",
"Powered Board Games",
"Étape 3 - Powered Board Games",
"DICE+ maintient la sensation de jouer avec de vrais dés et permet de jouer à plusieurs en version numérique ! Cette nouvelle catégorie de jeux s'appelle les Powered Board Games.\n\nLa série de jeux disponibles avec DICE+ est très variée. Découvrez-la et choisissez vos jeux préférés !",
"Étape 4 - Activation",
"Comment activer DICE+ ?\nC'est très facile ! Renverse les dés pour les activer et les utiliser. Les chiffres s'allumeront en vert.",
"FAIRE PIVOTER À 180°",
"Étape 5 - Connexion de DICE+",
"Pour votre confort, la connexion est automatique. Activez le Bluetooth sur votre appareil, lancez un jeu compatible avec DICE+ et activez les dés. Ceux-clignotent en bleu jusqu'à ce qu'ils soient connectés.",
"Étape 6 - Chargement de DICE+",
"Même s'il s'agit d'un appareil numérique, inutile de vous inquiéter pour la batterie. Pour les jeux de plateau, elle permet une utilisation interrompue de DICE+ pendant 20 heures. Le cycle complet de chargement est d'environ 2 heures. Vous pouvez charger DICE+ avec tout type de port USB alimenté, que ce soit avec votre chargeur de téléphone portable ou avec une prise PC. Branchez et attendez que la couleur rouge passe au vert. ",
"PRISE MICRO USB ",
"Étape 7 - Signal",
"Les chiffres clignotent rapidement en rouge - DICE+ est déchargé.",
"Les chiffres clignotent en bleu - DICE+ est en train de chercher un jeu compatible.",
"Les chiffres clignotent, en passant du bleu au vert - le jeu est connecté à DICE+.",
"Nous sommes ici pour vous aider et pour vous présenter les options complètes de ce jeu !\n\nTout d'abord, savez-vous comment DICE+ peut rendre le jeu encore plus amusant pour vous et pour vos amis ?",
"Bluetooth désactivé",
"Recherche de plus de DICE+"
			}
		},
		{ 
			"es",
			new List<string> {
"CONECTADO",
"BUSCANDO",
"BATERÍA BAJA",
"NO ENCONTRADO",
"DESCONECTADO",
"TIRA EL DADO",
"JUEGO INCOMPATIBLE",
"ACTUALIZA DICE+",
"COMPRA DICE+",
"AYUDA",
"JUEGA SIN DICE+",
"¡Bienvenido!",
"CONSEGUIR DICE+",
"SITIO WEB DEL PRODUCTO",
"Ahora puedes disfrutar de una versión electrónica de los juegos de mesa en tu tableta u otro dispositivo inteligente. DICE+ es un controlador universal de juegos de mesa, que envía por medio de Bluetooth los resultados de tus lanzamientos o movimientos a tu dispositivo inteligente, de esta manera una experiencia de juego completamente nueva. ¡Compra DICE+ e invita al juego a tu familia y a tus amigos, este tipo de juego es para jugar juntos!",
"¿Te gusta la versión electrónica de los juegos de mesa, mejorada con DICE+? ¡Comparte esta experiencia con los demás y consigue otro DICE+ para ellos! ¡Gracias a una gran variedad de juegos, seguro que no os aburrís!\n\nTen en cuenta que también hay juegos diseñados especialmente para jugar con muchos controladores a la vez. ¡Infórmate acerca de ellos y consigue más dados para disfrutar de un ritmo de juego que brinda diversión para todos!",
"Paso 1 - ¡Hola!",
"MÁS INFORMACIÓN ACERCA DE DICE+",
"Paso 2 - Acerca de DICE+",
"DICE+ es un controlador universal de juegos de mesa. Puede transformar el modo de jugar a un juego de mesa digital en una tableta o en cualquier otro dispositivo inteligente en toda una experiencia para todo aquel que se atreva a probarla. Solo tienes que lanzar tu dado, DICE+ enviará por medio de Bluetooth el resultado de cada lanzamiento a tu dispositivo, brindándote una experiencia a tiempo real donde de hecho está presente el azar. ¡El destino está de nuevo en tus manos!",
"POWERED BOARD GAMES",
"Paso 3 - Powered Board Games",
"¡DICE+ garantiza la experiencia de jugar con un dado real, mientras optimiza la funcionalidad de los juegos digitales de manera que pueden jugarse en grupo! Por consiguiente, se ha creado una nueva categoría de juegos llamada Powered Board Games.\n\nLa colección de juegos a lo que puedes jugar con DICE+ es muy variada: ¡descúbrelos todos y elige tus preferidos!",
"Paso 4 - Activación",
"¿Cómo se activa DICE+?\n¡Es muy sencillo! Solo hace falta dar vueltas al dado y ya está listo para utilización. Los números se iluminarán en verde.",
"GIRO DE 180º",
"Paso 5 - Conexión a DICE+",
"Para tu comodidad, la conexión se establece automáticamente. Solo tienes que activar Bluetooth en tu dispositivo, activar un juego compatible con DICE+ y activar el dado. El dado parpadeará en azul hasta que esté conectado.",
"Paso 6 - Cómo cargar DICE+",
"A pesar de que es un dispositivo digital, no debes preocuparte por la batería. Para los juegos de mesa, se garantiza el funcionamiento ininterrumpido de DICE+ durante 20 horas. El ciclo completo de carga dura alrededor de 2 horas. Puedes cargar DICE+ con cualquier tipo de puerto USB alimentado: ya sea el puerto de tu cargador del móvil o el de tu ordenador. Solo tienes que enchufar el dispositivo y esperar que el color cambie de rojo a verde.",
"CONEXIÓN MICRO USB",
"Paso 7 - Señales",
"Los números parpadean rápidamente en rojo: DICE+ está descargado.",
"Los números parpadean en azul: DICE+ está buscando un juego compatible.",
"Los números parpadean, cambiando de color azul a verde: el juego está conectado a DICE+.",
"¡Estamos a tu disposición para ayudarte y para presentarte las opciones completas de este juego!\n\nPrimero, ¿sabes cómo DICE+ puede hacer que un juego sea aún más apasionante para ti y para tus amigos?",
"Bluetooth desactivado",
"Buscando más DICE+"
			}
		},
		{ 
			"it",
			new List<string> {
"CONNESSO",
"RICERCA IN CORSO",
"BATTERIA SCARICA",
"NON TROVATO",
"SCONNESSO",
"TIRA IL DADO",
"IL GIOCO NON È COMPATIBILE",
"AGGIORNA DICE+",
"COMPRA DICE+",
"ASSISTENZA",
"GIOCA SENZA DICE+",
"Benvenuto!",
"ACQUISTA DICE+",
"Sito web del prodotto",
"Ora potrai usufruire della versione elettronica dei giochi da tavolo sul tuo tablet o su un altro dispositivo smart device. DICE+ è un controller universale di giochi da tavolo che invia i risultati dei tuoi lanci oppure movimenti al tuo dispositivo via Bluetooth garantendoti un'esperienza di gioco completamente  nuova. Acquista DICE + ed invita la tua famiglia e gli amici, giochi come questi sono fatti per divertirsi tutti insieme!",
"Ti diverti con la versione elettronica dei giochi da tavolo migliorata grazie a DICE +?Condividi quest'esperienza con gli altri ed acquista un altro DICE + per loro! Un'ampia scelta di giochi garantirà un gran divertimento per tutti!\n\nTi preghiamo di notare che ci sono anche giochi progettati per essere giocati con controller multipli allo stesso tempo. Scoprili e procurati altri dadi per una giocabilità che moltiplica il divertimento!",
"Passo 1- Ciao!",
"Impara a conoscere DICE +!",
"Passo 2- Cos'è DICE +",
"DICE +è un controller universale per giochi da tavolo, grazie al quale i giochi digitali su tablet o altri dispositivi smart device diventeranno un gran divertimento per tutti. Basta tirare il dado e DICE+ invierà il risultato di ogni lancio al tuo dispositivo mediante Bluetooth, facendoti assaporare un'esperienza realistica e una giocabilità assolutamente casuale. La sorte è tornata nelle tue mani! ",
"GIOCHI POWERED BOARD GAMES",
"Passo 3- Giochi Powered board games",
"DICE + mantiene intatta l'esperienza del gioco con un dado materiale e contemporaneamente fa sì che si possa giocare ai giochi digitali! Di conseguenza, si può affermare che è nata una nuova categoria di giochi detta Powered board games.\n\nLa collezione di giochi disponibili con DICE + è piuttosto varia, dacci un'occhiata e scegli i tuoi preferiti! ",
"Passo 4- Accensione",
"Come accendere DICE +?\nÈ facilissimo! Rovescialo semplicemente, in tal modo si accenderà e sarà pronto per l'uso. Le cifre diventeranno verdi.",
"Rovescialo a 180°",
"Passo 5- Collegare DICE +",
"Per tua comodità, il collegamento avviene in automatico. Attiva semplicemente la funzione Bluetooth sul tuo dispositivo, avvia un gioco compatibile con DICE + ed accendi il dado. Lampeggerà in blu fino alla connessione.",
"Passo 6- Ricaricare DICE +",
"Benchè si tratti di un dispositivo digitale, non preoccuparti della batteria- funzionerà fino a 20 ore ininterrottamente con i giochi da tavolo. Il pieno ciclo di ricarica dura circa 2 ore. È ricaricabile con qualsiasi porta USB ad energia, sia essa il caricabatterie del cellulare o uno slot del PC. Collegalo e attendi fino a quando il rosso non diventerà verde.",
"MICRO ATTACCO USB",
"Passo 7- Segnalazioni",
"Cifre che lampeggiano velocemente in rosso- DICE + è scarico",
"Cifre che lampeggiano in blu- DICE + è alla ricerca di un gioco compatibile",
"Cifre che lampeggiano dal blu al verde - il gioco si è collegato a DICE +",
"Siamo qui per aiutarti e per presentarti tutte le opzioni di questo gioco!\n\nInnanzitutto, sai come DICE + può rendere il gioco ancora più divertente per te e i tuoi amici?",
"Bluetooth disattivato",
"Ricerca di ulteriori DICE+"
			}
		},		
	};
	
	private Translations() {
		langcode = "en";

		if (Application.systemLanguage == SystemLanguage.Polish) langcode = "pl";
		if (Application.systemLanguage == SystemLanguage.German) langcode = "de";
		if (Application.systemLanguage == SystemLanguage.English) langcode = "en";
		if (Application.systemLanguage == SystemLanguage.Spanish) langcode = "es";
		if (Application.systemLanguage == SystemLanguage.French) langcode = "fr";
		if (Application.systemLanguage == SystemLanguage.Italian) langcode = "it";
		
	}
	
	public static void setLanguage(string langcode) {
		instance.langcode = langcode;
	}
	
	public static string translateKey(Key key) {
		return instance.translate(key);
	}
	
	//get transaltion for key
	private string translate(Key key) {
		if (languages.ContainsKey(langcode)) {
			List<string> translations = languages[langcode];
			if ((int)key < translations.Count) {
				return translations[(int)key].Replace("{n}", "\n");
			} else {
				return "MISSING_KEY:" + key;
			}
		} else {
			return "MISSING_LANGUAGE:" + langcode;
		}
	}
	
	//roughly estimates text block size
	public static Vector2 estimateSize(string text) {
		float maxXSize = 0;
		float ysize = 0;
		float xsize = 0;
		for (int i = 0; i < text.Length; i++) {
			bool isLower = char.IsLower(text[i]);;
			char letter = char.ToUpper(text[i]);
			float smallLetterFactor = 7f/8f;
			if (letter == '\n') {
				if (xsize > maxXSize) {
					maxXSize = xsize;
				}
				xsize = 0;
				ysize++;
			} else if (letter == 'T' || letter == 'F' || letter == 'J' || letter == 'L') {
				if (isLower) {
					xsize += 0.5f * smallLetterFactor;
				} else {
					xsize += 1f;
				}
			} else if (letter == 'I' || letter == ' ' || letter == 'Ï' || letter == 'Î') {
				if (isLower) {
					xsize += 0.5f * smallLetterFactor;
				} else {
					xsize += 0.5f;
				}
			} else if (letter == 'W' || letter == 'M') {
				if (isLower) {
					xsize += 1.5f * smallLetterFactor;
				} else {
					xsize += 1.5f;
				}
			} else if (letter == '.' || letter == ',' || letter == ';' || letter == ':' || letter == '!' || letter == '\'' || letter == '"' || letter == '(' || letter == ')' || letter == '-' || letter == '/' || letter == '\\') {
				xsize += 0.5f;
			} else {
				if (isLower) {
					xsize += 1f * smallLetterFactor;
				} else {
					xsize += 1f;
				}
			}
		}
		if (xsize > maxXSize) {
			maxXSize = xsize;
		}
		ysize++;
		return new Vector2(maxXSize, ysize);
	}
	
	//roughly estimates text length
	public static float estimateLength(string text) {
		return estimateSize(text).x;
	}
	
	//aranges string into text block with set line block length
	public static string wrapText(string input, float lineLength){
		string[] paragraphs = input.Split('\n');
		string result = "";
		
		foreach(string paragraph in paragraphs) {
		  	string[] words = paragraph.Split(' ');
			string resultParagraph = "";

		  	
			string line = "";
		 
		  	foreach(string s in words) {
		    	string temp = line + " " + s;
		 
			    if(estimateLength(temp) > lineLength){
				  resultParagraph += line + "\n";
			      line = s;
			    } else {
			      line = temp;
			    }
		  }
		  resultParagraph += line;
		  result += resultParagraph.Substring(1,resultParagraph.Length-1) + '\n';
	   }
	   return result.Substring(0,result.Length-1);

	}
	
}
