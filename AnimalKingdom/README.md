```mermaid
    classDiagram
        Bat --|> Animal
        Bat ..|> IMammal
        Bat ..|> ICanFly
        Dog --|> Animal
        Dog ..|> IMammal
        Cat --|> Animal
        Cat ..|> IMammal
        Bee --|> Animal
        Bee ..|> ICanFly

        class IMammal
        <<interface>> IMammal

        class ICanFly
        <<interface>> ICanFly
```