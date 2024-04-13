-> intro

VAR name_2 = "Julienne"
VAR seasheperd_flag = true
VAR weed = true
VAR potager = true



=== intro ===

* Again ? Are you the one who summoned me ?
    Greetings, bredda, ease up yuhself. Yuh can assist I wit mi troubles?
    ** Who are you ?
        Mi name be {name_2} di cyclop
        *** Nice to meet you {name_2}, how can I help you ?
            Mi lose mi appetite, mi hardly nyam no more,  mi can't even manage to finish a likkle plate.
            **** What do you eat?
                Mostly salad an' seeds, mi a proud vegan, mi naah nyam meat fi centuries.
                -> rasta_cyclop
 -> DONE



=== rasta_cyclop ===

- (start_choices)

* Why ? Are you not supposed to eat meat ?
  It is better fi mi body.
  
    ** {potager} Your vegetables don't look great
    Mi nuh really good at gardening, yuh know
    
        *** Are you not missing meat ?
           No way, meat ah killin
    
            **** Are you telling me, you don't miss a fried chicken, a good steak and even bacon.
                Nah, mi neva did rate dem much
                ***** What did you eat back in the day then ?
                    Human beings
                    ****** (cannibal)... 
                        Now dat mi ponder pon it, mi miss di flavor of humans
                        ******* ...
                        Mi nyam a French engineer one time, it taste sweet
                            ******** RUN AWAY
                            No run weh, mi belly a grumble now.
                            !!! # result:5:Mi always hanker afta food. Him look nyam-able 
                                    -> end_choices

        *** (diet) Eating less protein is a great way to lose weight
            Yuh waan follow mi diet ?
            **** Yes, I think you could make a fortume with it
                # result:1:Mi get thin an' rich, but mi still feel miserable
                -> end_choices

    ** {weed} And weed and booze are good for your body ?
        Dem deh. Dem mek mi happy.
        *** It doesn't make any sense !
        Yeah, it nuh haffi
            **** What ?
            Yuh right, sense nuh matter
            *****
        *** Amen to that ! Let's party !
        Ya go, mi friend
            **** I'm getting hungry, you too ?
            Nah, not really, but mi can cook yuh someting
                **** I would kill for some chicken
                Now dat yuh mention it, it sound like a good idea.
                # result:3:He couldn't help me get rid of my good friends. I have even more now
                **** Nah, I don't eat seeds
             # result:2:He couldn't help me get rid of my good friends. I have even more now
            -> end_choices

* {seasheperd_flag} I get you sister, meat is murder !
    Yuh overstand, bredren !
    ** All living beings should be protected
    Yeah man, yuh right
    -> diet
    ** Humans kill so many innocent animals
    Yeah man, mi gwine seek vengeance fi dem
    -> cannibal
    


- (end_choices)
-> DONE
