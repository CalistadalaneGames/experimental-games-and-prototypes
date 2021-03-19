# DUNGINE Manual
> v0.6.x.x

## Dungine
The main thing

## Dungine.Common
Common game stuff.

## Dungine.Common.GameInstance.cs
Contains all components of a game, including:
* Game details (GameDetails.cs)

### Dungine.Common.GameInstance.NewTemplate()
When a Dungine game starts, the first thing it does is create a generic GameInstance template because:
1. If the "gameName.json" file for your game isn't found, the "dungine-generic-game.json" file is loaded. You'll find out pretty quick that something is wrong.
2. The generic GameInstance template is useful when developing/debugging Dungine, and this way a new, current GameInstance template is created whenever a Dungine game is launched.
In general, you can just ignore the ""dungine-generic-game.json" file.

### Dungine.Common.GameDetail.cs
The GameDetail object contains various details for a game.
* **Title**: The game title (i.e. "Dungeon")
* **SubTitle**: The game subtitle (i.e. "A Scary Adventure")
* **Genre**: The game genre (i.e. "text-adventure")

## Genres
Supported game genres:

* Text Adventure