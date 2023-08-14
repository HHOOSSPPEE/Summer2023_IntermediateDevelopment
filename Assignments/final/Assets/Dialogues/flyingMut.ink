# uses_attr # fuuuuck
VAR charm = 0
VAR strength = 0
VAR psych = 0

->start
==start
AN IMPISH, WINGED MUTANT IS HERE.
->next1
==next1
WHAT CAN YOU SAY?
{
    - charm > 0:
        +"WHERE AM I" ->charming
}
{
    - strength > 0:
        +"WHERE AM I" ->intimidating
}
{
    - psych > 0:
        +"WHERE AM I" ->entrancing
}
+NOTHING ->END

==charming
(charming)
THE MUTANT IS SMOOTH-TALKED AND REPLIES...
"THIS IS THE WELLSPRING."
->END

== intimidating
(intimidating)
THE MUTANT IS INTIMIDATED AND REVEALS...
"THIS IS THE WELLSPRING."
->END

== entrancing
(entrancing)
BEFORE THE MUTANT CAN ANSWER, YOU SEE THE LETTERS IN YOUR MIND:
"WELLSPRING"
AND YOU WALK AWAY.
->END
