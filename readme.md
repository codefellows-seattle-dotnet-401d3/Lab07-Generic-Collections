# Lab07 Collections
## Make a deck of cards

## overview
Made a `<deck>` collection of Cards. The deck can be added too, removed from and shuffled.

## use
### Card
The Card class has enum values that it accepts. Those values only allow 2-14 rank and 1-4 suit. To make a new card:
```
Card myCard = new Card (V.Ace, S.Spades);
```
### Deck
Deck is generalized and can work with anything, although for this application card/deck ideas and terminology were used for variable names inside the definition. The deck can be added too, removed from, and shuffled. It is also enumerable, so you can traverse it with a foreach statement.

## Architecture
Deck is a custom generic, Card is a custom class.

## Expansion
- Contains method
- Search deck
- Overload remove to remove from index
- Overload remove to remove a specific card if it is found in the deck.

## change log
2018-03-28 19:30 version 1.0 released