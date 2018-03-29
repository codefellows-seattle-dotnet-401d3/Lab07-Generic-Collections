# Lab07 Phil Werner

## Deck Of Cards
Using a Custom Generic Collection (Deck) that takes in Card objects, the program
can create decks of cards. The Deck Collection has a Add() method, Remove() method
and a Shuffle() method available to it. 

## Tools Used
Microsoft Visual Studio Community Version 15.5.7

C#

ASP.Net

xUnit

Collections

## Getting Started

Clone this repository to your local machine.
```
$ git clone 
```
Once downloaded, cd into the ```Lab07-Collections``` directory.
```
$ cd Lab06-Collections
```
The cd into ```CardDeck``` directory.
```
$ cd CardDeck
```
The cd into the second ```CardDeck``` directory.
```
$ cd CardDeck
```
Then run .NET build.
```
$ dotnet build
```
Once that is complete, run the program.
```
$ dotnet run
```
## Collection Examples
First we create a instance of ```Deck```:
```Deck<Card> sampleDeck = new Deck<Card>();```

Then we add a new Card:
```sampleDeck.Add(new Card(V.Four, S.Spades))```

To remove a Card using the ```Remove()``` method:
```sampleDeck.Remove()```

To shuffle the deck using the ```Shuffle()``` method:
```sampleDeck.Shuffle()```

## Enums For Cards
As seen above, the Cards use enums for the ```Suit``` and ```Value```
```V``` is for the ```Value``` Ace - King
```S``` is for the ```Suit``` Spades, Clubs, Diamonds, Hearts

