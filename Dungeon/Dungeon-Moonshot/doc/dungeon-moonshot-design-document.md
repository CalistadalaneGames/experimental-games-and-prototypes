<!--
  project-templates 201102
  project-templates-github-design-document-template 201024
-->

<h1 align="center">

  <br>
  Dungeon: MOONSHOT<br>
  Design Document

</h1>

<h5 align="center">

  Last updated: November 2, 2020
  <br>
  <br>

</h5>

<!-- NOTE: The HTML indentations have to stay this way to work. -->
<table>
<tr>
<td img src="repository-data/image/document/readme/spacer.png" alt="blank-spacer" width="1000" height="1">

  ### CONTENTS
  [ABOUT](#about)<br>
  [GAME OFF 2020 THEME: MOONSHOT](#game-off-2020-theme-moonshot)<br>
  [THE INSPIRATIONS](#the-inspirations)<br>
  [DEVELOPMENT](#development)<br>
  
</td>
</tr>
</table>

<!-- About this repository -->
# ABOUT
This is the design document for [**Dungeon: MOONSHOT**](https://github.com/CalistadalaneGames/dungine-moonshot), an experimental game for the [itch.io Game Off 2020](https://itch.io/jam/game-off-2020) game jam, and is being developed alongside the [Moonshot Engine](https://github.com/CalistadalaneGames/moonshot-engine).

# GAME OFF 2020 THEME: MOONSHOT
The theme of Game Off 2020 is MOONSHOT, which itch.io defines as:

* **moonshot** – *noun*
    * an extremely ambitious and innovative project
    * the act of launching a spacecraft to the moon
    * a hit or thrown ball that travels a great distance with a high trajectory

* **moonshot thinking** – *noun*
    * a type of thinking that aims to achieve something that is generally believed to be impossible.

## My interpretation of "MOONSHOT
I'm going to interpret "MOONSHOT" as:
* an extremely ambitious and innovative project
* a type of thinking that aims to achieve something that is generally believed to be impossible

And since "MOONSHOT" is capitalized, I am going to consider it an acronym. Therefore, Dungeon: MOONSHOT will be taking inspiration from the following games/genres:
* [**M**ight & Magic series (role-playing)](#might-&-magic-series)
* [**O**regon Trail (survival)](#oregon-trail)
* [**O**overPower (card game)](#overpower)
* [**N**etHack (roguelike)](#nethack)
* [**S**imCity (simulation)](#simcity)
* [**H**unt the Wumpus (text adventure)](#hunt-the-wumpus)
* [**O**ut Run (driving)](#out-run)
* [**T**etris (puzzle)](#tetris)

The end result will, most likely, be terrible. But that's fine.

# THE INSPIRATIONS
### Might & Magic series
>[Might & Magic](https://en.wikipedia.org/wiki/Might_and_Magic) is a series of role-playing video games. The majority of the gameplay takes place in a medieval fantasy setting, where the player controls a party of player characters which can consist of members of various character classes. The game world is presented to the player in first person perspective.

Dungeon: MOONSHOT will resemble an old-school RPG like ["Bard's Tale"](https://en.wikipedia.org/wiki/The_Bard%27s_Tale) or ["Eye of the Beholder"](https://en.wikipedia.org/wiki/Eye_of_the_Beholder_%28video_game%29). I would have liked to use ["Wizardry"](https://en.wikipedia.org/wiki/Wizardry), but "MOONSHOT" doesn't have a "W".

Might & Magic's primary influence on Dungeon: MOONSHOT will be as a *role-playing* game:
* There will be a graphical user interface
* You will play as a party of adventurers
* There will be character sheets, paper dolls, and resource management
* Your party will gain experiance
* There will be various NPCs

### Oregon Trail
>[Oregon Trail](https://en.wikipedia.org/wiki/The_Oregon_Trail_(1985_video_game)) is a computer game designed to teach students about the realities of 19th-century pioneer life on the Oregon Trail. In the game, the player assumes the role of a wagon leader guiding a party of settlers from Independence, Missouri, to Oregon's Willamette Valley via a covered wagon.

Dungeon: MOONSHOT will give the player a clear path to the endgame. The goal of The Oregon Trail is to successfully lead your settlers from one location to another, which is a clear path to the endgame. I also want to have some realism/survival aspects where the player needs to pay attention to keeping the party alive on their journey.

The Oregon Trail's primary influence on Dungeon: MOONSHOT will be as a *survival* game:
* Your party will travel from a starting position to a final destination
* The environment is dangerous
* Your party will need to eat, drink, and rest

### OverPower
>[OverPower](https://en.wikipedia.org/wiki/OverPower) is a collectible card game originally featuring characters from Marvel Comics and later from DC Comics and Image Comics. The game was launched in August 1995. In the game, two players went head-to-head with teams of four heroes and villains.

Dungeon: MOONSHOT will have card-based play, which will bring some additional strategy to gameplay, as well as some randomness and luck. There aren't alot of card games that start with "O", and I didn't want to mimic any existing game, so OverPower is really just representing card-based gaming as a whole.

OverPower's primary influence on Dungeon: MOONSHOT will be as a *card* game:
* Loot is represented with cards
* Combat is card-based

### NetHack
>[NetHack](https://en.wikipedia.org/wiki/NetHack) is roguelike video game where the player takes the role as one of several pre-defined character classes to descend through multiple dungeon floors, fighting monsters and collecting treasure, to recover the "Amulet of Yendor" at the lowest floor and then escape. NetHack features procedural-generated dungeons and treasure, hack and slash combat, tile-based gameplay, and permadeath. 

Dungeon: MOONSHOT will focus on exploration, finding loot, eventually dying, then starting again.

NetHack's primary influence on Dungeon: MOONSHOT will be as a *rogue-like* game:
* The environment is procedurally generated
* The environment becomes increasingly more difficult
* There will be a variety of loot

### SimCity
>[SimCity](https://en.wikipedia.org/wiki/SimCity) is an open-ended city-building video game series published by Maxis in 1989. In the SimCity games, the player develops a city from a patch of undeveloped land. The player controls where to place development zones, infrastructure like roads and power plants, landmarks, and public services such as schools, parks, hospitals and fire stations. The player also determines the tax rate, the budget, and social policy. 

Dungeon: MOONSHOT will have a town the player needs to maintain.

SimCity's primary influence on Dungeon: MOONSHOT will be as a *simulation* game:
* The player will be responsible the expansion and maintenance of a town

### Hunt the Wumpus
>[Hunt the Wumpus](https://en.wikipedia.org/wiki/Hunt_the_Wumpus) is a text-based adventure game developed by Gregory Yob in 1973. In the game, the player moves through a series of connected caves, arranged in a dodecahedron, as they hunt a monster named the Wumpus. The turn-based game has the player trying to avoid fatal bottomless pits and "super bats" that will move them around the cave system; the goal is to fire one of their "crooked arrows" through the caves to kill the Wumpus. Hunt the Wumpus has been cited as an early example of the survival horror genre, and was listed in 2012 on Time's All-Time 100 greatest video games list.

Dungeon: MOONSHOT will be creepy. In addition, while it will have a grphical user interface, much of the interaction will be text-based. I also want the endgame goal to be defeating the Big Bad Monster.

Hunt the Wumpus's primary influence on Dungeon: MOONSHOT will be as a *text adventure* game:
* The environment is creepy
* Much of the gameplay will be text-based
* The endgame goal is to kill the Big Bad Monster

### OutRun
>[Out Run](https://en.wikipedia.org/wiki/Out_Run)  is a racing video game released in arcades by Sega in September 1986. It is known for its nonlinear gameplay and a selectable soundtrack. The goal is to avoid traffic and reach one of five destinations.

Dungeon: MOONSHOT will have car racing! Also, music was also a big part of Out Run.

Out Run's primary influence on Dungeon: MOONSHOT will be as a *driving* game:
* The player will be able to drive a car
* There will be cool music

### Tetris
>[Tetris](https://en.wikipedia.org/wiki/Tetris) is a tile-matching video game where players complete lines by moving differently shaped pieces, which descend onto the playing field. The completed lines disappear and grant the player points, and the player can proceed to fill the vacated spaces. The game ends when the playing field is filled. The longer the player can delay this inevitable outcome, the higher their score will be.

Dungeon: MOONSHOT will have some puzzle mechanics, possibly with the card aspects of the gameplay

Tetris's primary influence on Dungeon: MOONSHOT will be as a *puzzle* game:
* Some sort of puzzle/matching component to the cards.

# DUNGEON: MOONSHOT
## The List of Inspirations
So taking all of the inspirations from past games, Dungeon: MOONTSHOT looks something like this:

* A single player, rogue-like dungeon-crawler in a dark, creepy environment
* A party of four adventurers decends to the final level of a dungeon to kill a monster that is terrifying a local village
* The party will have to fight monsters and deal with the environment of the dungeon itself, both of which become more difficult as they decend
* Each member of the party will need to take care of their health and morale
* Each member of the party will gain experiance and increase in level
* The party will find various treasure and useful items
* The game interface will have graphical components for dungeon navigation and party management, text-based for gameplay interaction, and card-based for loot and combat
* The party will be responsible for the expansion and maintenance of the village and it's community
* When all members of the party die, the player is returned to the village and is able to spend some resources to expand/maintain the village
* The player may choose a new party to decend the dungeon
* The party will be able to drive cars
* There will be cool music

## A few things I'll be adding
There are a few things that aren't included in the List of Inspirations that will be in the game:

### Bob
There will be a fifth party member that the player doesn't control. Let's call him Bob. The party is able to give Bob loot they find during their decent, and in the event that all member of the party die, Bob runs back to the village with the loot he was given. The loot can be exchanged for currency, or given to a new recruit.

Some things about Bob:
* Bob always successfully returns to the village
* Bob can only so much loot
* Bob can be upgraded to hold more loot

## Bringing it altogether
Dungeon: MOONSHOT is a very ambitious, very experimental videogame comprised of multiple gaming genres, mechanics, and styles. At its core it's a single player rogue-like party-based RPG. It also includes survival and simulation systems, as well as text-based and card-based interfaces. And driving. And cool music.

Dungeon: MOONSHOT begins in a small village. The village is being terrorized by a monster that resides at the bottom of a nearby dungeon. The village is simple, consisting of a few houses, and an inn. At the inn, the player can recruit four adventurers from a number of available characters. Once the party is complete, they set out for the dungeon.

The dungeon is dark and creepy. Each "floor" is procedurally generated, and is essentially a giant room with a staircase leading down on the far side. As the party decends into the dungeon, the monsters become more difficult, and the environment becomes more dangerous. Each room contains one of the following:

* Nothing
* Loot
* A trap!
* A monster
* A group of monsters
* A boss monster
* A friend
* A special place
* An environmental hazard

In addition to monsters and environmental hazards, each member of the party must take care of their own health and well-being. Party members must eat and drink, and rest when possible. Failing to do these things will result in negative consequences.

The party's mission is to decend to the final level of the dungeon - level 100 - and defeat the monster that has been terrorizing the village. If they are successful, they return to the village as heroes and the game ends. The party can continue decending until all members have died, at which point the player is returned to the village.

While in the village the player can expand the village, making additional options available. The player will also need to maintain the village and ensure that its community is happy. The player can also interact with various NPCs and recruit new adventurers to decend into the dungeon once more.

## Additional details
### Floor contents
Each dungeon floor will contain one of the following:
* Empty
	* Avoidable: Never
	* The party can eat/drink/rest: Always
	* The party can transfer loot to Bob : Always
	* Damage to living party member(s): Never
	* Loot: Never
	* Well-being: Normal increase
* Loot
	* Avoidable: Never
	* The party can eat/drink/rest: Always
	* The party can transfer loot to Bob : Always
	* Damage to living party member(s): Never
	* Loot: Always
	* Well-being: Always increase
* A trap!
	* Avoidable: Never
	* The party can eat/drink/rest: Never
	* The party can transfer loot to Bob : Never
    * Damaging living party member(s): Always
	* Loot: Always
	* Well-being: Advanced decrease
* A monster
	* Avoidable: Normal
	* The party can eat/drink/rest: Never
	* The party can transfer loot to Bob : Never
	* Damage to living party member(s): Normal
	* Loot: Normal
	* Well-being: Advanced decrease
* A group of monsters
	* Avoidable: Rare
	* The party can eat/drink/rest: Never
	* The party can transfer loot to Bob : Never
	* Damage to living party member(s): Advanced increase
	* Loot: Advanced increase
	* Well-being: Advanced decrease
* A boss monster
	* Avoidable: Never
	* The party can eat/drink/rest: Never
	* The party can transfer loot to Bob : Never
	* Damage to living party member(s): Advanced increase
	* Loot: Always
	* Well-being: Advanced decrease
* A friend
	* Vendor: buy/sell treasure/equipment/food/drink
		* Avoidable: Never
		* The party can eat/drink/rest: Advanced increase
		* The party can transfer loot to Bob : Advanced increase
		* Damage to living party member(s): Never
		* Loot: Never
		* Well-being: Normal
	* Cleric: resurrect dead party members, bless the party
		* Avoidable: Never
		* The party can eat/drink/rest: Advanced increase
		* The party can transfer loot to Bob : Advanced increase
		* Damage to living party member(s): Never
		* Loot: Never
		* Well-being: Advanced increase
* An environmental hazard
	* Avoidable: Rare
	* The party can eat/drink/rest: Rare
	* The party can transfer loot to Bob : Rare
	* Damage to living party member(s): Advanced increase
	* Loot: Rare
	* Well-being: Normal

### When the party is defeated
* The names of the adventurers are carved into the wall of the level where they died
* The player is returned to the village
* The player is given some of the loot from the previous decent
* The player can expand/maintain the village
* The player can recruit four new heroes and decend into the dungeon again.

### Well-being
* If a party member doesn't eat enough, they will die of starvation
* If a party member doesn't drink enough, they will die of dehydration.
* If a party member doesn't get enough rest, they may lose morale
* If a party member doesn't get enough rest, they may go mad.

### Other
* There will be character sheets, paper dolls, and resource management
* Your party will gain experiance and levels
* There will be various NPCs, such as shop owners and tradesmen
* Buildings (inn, armor, bank, weapons, training, church, alchemist, gym)