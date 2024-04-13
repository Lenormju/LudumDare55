-> intro

=== intro ===

* mais qu'est-ce qui se passe ? Ahhhh un démon !!!
    bonjour :)
    ** aaah ... Comment ça bonjour ?
        bah ... bonjour :)
        *** vous êtes un minotaure qui dit bonjour ?
            oui, je suis très content de vous voir.
            **** ah, c'est cool.
                non justement !
                ***** comment ça ?
                    je suis un minotaure sanguinaire et cruel, je ne devrais pas être content de discuter paisiblement avec vous ! Vous voulez un peu de thé ?
                    ****** Ah je vois, c'est pour ça que vous m'appellez ?
                        oui, je veux retrouver ma rage.
                        -> choices
 -> DONE

=== choices ===

- (start_choices)
Let's go !
* comment l'avez-vous perdu ?
    je me suis rendu compte que les humains qu'on jetait dans mon dédale étaient sympas
    
    ** en êtes-vous bien sûr ?
        c'est vrai que y'a Bryan qui fait des blagues à papa ?

        *** (jokes) vous avez un exemple ?
            I'm afraid for the calendar. Its days are numbered.
            **** ah oui ...
                rien que d'y repenser, ça m'énerve !
                ***** What do you call a fish wearing a bowtie? Sofishticated.
                    mhmmmh
                    ****** I only know 25 letters of the alphabet. I don't know y.
                        please stop ...
                        ******* I don't trust those trees. They seem kind of shady.
                            STOP TELLING JOKES !
                            ******** eh voilà :)
                                leave before I kill you  # result:demon_1:5:il a su me faire retrouver ma rage intérieure, j'ai fait un carnage
                                -> end_choices

        *** (tolerance) ça arrive à tout le monde ...
            vous avez raison, il faut être tolérant.
            **** oui, sinon on risque de se fâcher, et ça serait dommage ...
                la vie est tellement plus belle lorsque tout le monde vit en harmonie !  # result:demon_1:1:j'ai perdu tout espoir de renouer des relations habituelles avec des personnes
                -> end_choices

    ** vous avez raison, ils semblent plutôt cools
        oui, j'ai appris à jouer au frisbee grâce à eux, quel sport incroyable
        *** l'été dernier je suis allé à la plage et j'ai regardé des gens jouer au frisbee, c'était agréable
            oh, ça me donne envie de partir en vacances au soleil, loin de ce sombre labyrinthe. Bonne journée !  # result:demon_1:2:il n'a pas su m'aider à me séparer de mes mauvaises fréquentations
            -> end_choices

* qu'est-ce qui vous enrage ?
    les mauvaises blagues
    -> jokes

* vous semblez un peu simplet !
    qu'est-ce qui vous fait dire ça ?
    ** vous avez un piercing au nez comme une vachette
        vous trouvez vraiment que je ressemble à une vachette ?
        *** oui
            PARTEZ AVANT QUE JE VOUS EN-CORNE ! VOUS VERREZ SI JE SUIS UNE VACHETTE !  # result:demon_1:4:j'ai retrouvé confiance en moi, je suis un animal sauvage
            
        *** non
            ce sont les préjugés qui vous donnent cette impression
            -> tolerance
    ** vous semblez avoir des problèmes vraiment futiles
        oui, vous avez raison, il faut que je tire un trait sur ce besoin de faire du mal aux autres  # result:demon_1:2:je n'ai pas réussi à me détacher de mes bas instincts
    -> end_choices

- (end_choices)
-> DONE
