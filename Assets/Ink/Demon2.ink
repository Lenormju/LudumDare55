VAR name_2 = "Phydidre"
VAR seasheperd_flag = false
VAR weed = false
VAR potager = false
VAR run_away = "Leave"

-> intro

=== intro ===
Bouuuh!
* Again ? Are you the one who summoned me?
    Greetings, bredda, ease up yuhself. Yuh can assist I wit mi troubles?
    ** Who are you ?
        Mi name be {name_2} di cyclop
        *** Nice to meet you {name_2}, how can I help you?
            Mi lose mi appetite, mi hardly nyam no more,  mi can't even manage to finish a likkle plate.
            **** What do you eat?
                Mostly salad an' seeds, mi a proud vegan. Mi naah nyam meat fi centuries.
                -> rasta_cyclop
 -> DONE



=== rasta_cyclop ===

- (start_choices)
* {potager} Why? Are you not supposed to eat meat?
  It is better fi mi body.
  
    ** {potager} Your vegetables don't look great
    Mi nuh really good at gardening, yuh know
    
        *** Are you not missing meat?
           No way, meat ah killin
    
            **** Are you telling me, you don't miss a fried chicken, a good steak and even bacon.
                Nah, mi neva did rate dem much
                ***** What did you eat back in the day then?
                    Human beings
                    ****** ... 
                        Now dat mi ponder pon it, mi miss di flavor of humans
                        ******* ...
                        Mi nyam a French engineer one time, it tastes sweet
                            ******** I think I should go
                            No run weh, mi belly a grumble now. # result:demon_2:5:Mi always hanker afta food. Him look nyam-able
                            ~ run_away = "RUN AWAY"
                                   ********* [{run_away}]
                                    -> DONE

        *** Eating less protein is a great way to lose weight
            Yuh waan follow mi diet?
            **** Yes, I think you could make a fortune with it # result:demon_2:1:Mi get thin an' rich, but mi still feel miserable
               ***** [{run_away}]
                    -> DONE

    ** {weed} And weed and booze are good for your body?
        Dem deh. Dem mek mi happy.
        *** Amen to that! Let's party!
        Ya go, mi friend
            **** I'm getting hungry, you too?
            Nah, not really, but mi can cook yuh someting
                ***** I would kill for some chicken
                Now dat yuh mention it, it sound like a good idea.
                    # result:demon_2:3:Him get mi high fi solve mi problems, pretty solid
                    ****** [{run_away}]
                        -> DONE


* {seasheperd_flag} I get you sister, meat is murder!
    Yuh overstand, bredren!
    ** All living beings should be protected
    Yeah man, yuh right
        *** (diet) Eating less protein is a great way to lose weight
                Yuh waan follow mi diet?
                **** Yes, I think you could make a fortume with it # result:demon_2:1:Mi get thin an' rich, but mi still feel miserable
                   ***** [{run_away}]
                        -> DONE
    ** Humans kill so many innocent animals
    Yeah man, mi gwine seek vengeance fi dem
        *** You still shouldn't hurt humans 
                Now dat mi ponder pon it, mi miss di flavor of humans
                **** ...
                Mi nyam a French engineer one time, it taste sweet
                    ***** I think I should go
                    No run weh, mi belly a grumble now.  # result:demon_2:5:Mi always hanker afta food. Him look nyam-able 
                    ~ run_away = "RUN AWAY"
                        ****** [{run_away}]
                            -> DONE

* How's your relationship with your father?
  Don't you dare talk about my daddy!
  ** What happened to your accent?
     Fork you man! My daddy is great
     *** Why are you upset?
         He hasn't talked to me in 500 years
        **** Why?
         One time I stole his lunch, he never forgave me
             ***** Talk to your father
             Do I really have to?
                ****** It will help you to overcome your problems.
                 I am afraid you are right #result:demon_2:2: I had a meaningful talk with my family to overcome my issues. This shrink make me puke.
                    ******* [{run_away}]
                        -> DONE
             ***** Steal his food again
             No, I couldn't.... I shouldn't ....
                 ****** Go for it
                 It's true that I miss my parents cooking. Thanks doc! #result:demon_2:4: I moved back with my parents and gained a hundred pounds, my dad is miserable. Would summon again!
                     ******* [{run_away}]
                        -> DONE

-> END
