# Invariants

## Descriptor Invariants
- A room cannot have duplicate loot entries
- A room must have an identifiable and human readable plain text code

## Loot Invariants
- Loot must have a difficulty class above 0
- Loot must have a difficulty class below 30
- Loot must have a minimum quantity above 0
- A room must have an identifiable and human readable plain text code

### Variations
A variation is a of the same type of item for example

#### Examples
```
Simple Weapon
- Club, Dagger, Greatclub, Javelin, Handaxe
Food
- Apple, Bread, Meat
```

## Modifier Invariants
- A room must have an identifiable and human readable plain text code

## Loot Table Invariants
- Must contain a valid code that represents a list of descriptors and modifiers that can be used to generate the table
- Must contain at least one descriptor


# Examples
`Elven.Ancient:Bakery(Food: Apple,Bread;SimpleWeapon: Dagger).Ruin::Abundant`
`Elven:Armory(SimpleWeapon: !Dagger)::Abundant`