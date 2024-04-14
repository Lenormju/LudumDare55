VAR name_1 = "Dominos Jr"
VAR run_away = "Leave"


-> intro


=== intro ===
Bouuuh !
* What happened ? AHHHH A MONSTER!
    Good morning :) I summoned you to hell, I am {name_1} the Minotaur
    ** A minotaur ? Are you going to kill me ?
        No, I'm a pacifist, I wouldn't harm a fly.
        *** This is great !
            Not it isn't, I'm a demon. 
            **** What ?
                I lost my bloodlust, my wrath, I yearn for conflict and war.
                ***** Why ?
                    I am a minotaur, I'm supposed to be cruel and barbaric ! Do you want some camomille tea?
                    ****** I understand but why did you summon me ?
                        You are the worst shrink in the world, you make all your clients miserable. You're my last resort to find my inner rage.
                            ******* Why would I help you ?
                                I will put a good review on MyOccultTherapist.com
                                    ******** Great ! Let's start then !
                        -> choices
 -> DONE

=== choices ===
- (start_choices)
Thank you !
* How long have you felt at peace ?
    Since I realized the humans thrown in my labyrinth were quite fun
    
    ** Are you sure ?
        To be honest, I'm getting a little bit tired of Bryan's dad jokes.
        *** Can you tell me one ?
            I'm afraid for the calendar. Its days are numbered.
            **** ... It's quite bad
                Just thinking about it get on my nerves
                ***** Really ?What do you call a fish wearing a bowtie? ... Sofishticated.
                    mhmmmh
                    ****** I only know 25 letters of the alphabet. I don't know y.
                        Please stop ...
                        ******* I don't trust those trees. They seem kind of shady.
                            STOP TELLING JOKES !
                            ******** Here it is :)
                                ~ run_away = "RUN AWAY"
                                LEAVE BEFORE I KILL YOU PUNY HUMAN !!! # result:Dominos Jr:5:I MAKE BLOOD RAIN EVERYDAY ! Great Therapy !
                                *********  [{run_away}]
                                     -> DONE

        *** It happens to everyone
            You are right, I should be more tolerant
            **** Yes, why get angry for so little
                Life is much more beautiful when everyone share happiness and laughter  # result:Dominos Jr:1:I lost all hope to go back to my roots
                *****  [{run_away}]
                    -> DONE

    ** Yeah, humans are pretty great
        Yes, they taught me how to play frisbee, I loved it, it's amazing
        *** Last summer, I saw many people happily playing frisbee at the beach with their dogs
            What ? Are you comparing me to a dumb dog ?
            **** Not really ...
                Ahh ...
                ***** You look more like a pig
                     ~ run_away = "RUN AWAY"
                     
                    YOU BETTER LEAVE BEFORE I IMPALE YOU ! YOUR GUTS WILL DECORATE MY HORNS !
                    # result:Dominos Jr:4:I believe in myself again, I am a wild beast.
                    ******  [{run_away}]
                    -> DONE
            **** No, I meant you need some vacation
            Oh, it's true I would enjoy some sunshine, far from this dark cave. Ciao my friend !
             # result:Dominos Jr:2:He couldn't help me get rid of my good friends. I have even more now
                *****  [{run_away}]
                    -> DONE

* What anger you ?
    Nothing
    ** Are you sure ? Don't you have any trigger ?
    Not really
    *** Is there anything you dislike slightly ?
    To be honest, I'm not a big fan of dad jokes
        **** Can you tell me one ?
                I'm afraid for the calendar. Its days are numbered.
                ***** ... It's quite bad
                    Just thinking about it get on my nerves
                    ****** Really ?What do you call a fish wearing a bowtie? ... Sofishticated.
                        mhmmmh
                        ******* I only know 25 letters of the alphabet. I don't know y.
                            Please stop ...
                            ******** I don't trust those trees. They seem kind of shady.
                                STOP TELLING JOKES !
                                ********* Here it is :)
                                     ~ run_away = "RUN AWAY"
                                    LEAVE BEFORE I KILL YOU PUNY HUMAN !!! # result:Dominos Jr:5:I MAKE BLOOD RAIN EVERYDAY ! Great Therapy !
                                        **********  [{run_away}]
                                        -> DONE

* You look a little bit dumb
    How could you say something like that ?
    ** You are a farm animal in a hawaian shirt
        A farm animal ?!? You think I look like a bull ?
        *** You look more like a pig
         ~ run_away = "RUN AWAY"
        YOU BETTER LEAVE BEFORE I IMPALE YOU ! YOUR GUTS WILL DECORATE MY HORNS !
        # result:Dominos Jr:4:I believe in myself again, I am a wild beast.
            ****  [{run_away}]
                        -> DONE
            
        *** You are a bull !
            That's not something to say to a minotaur. How can you be so insensitive ?
            **** (tolerance) It happens to everyone
                You are right, I should be more tolerant
                ***** Yes, why get angry for so little
                    Life is much more beautiful when everyone share happiness and laughter  # result:Dominos Jr:1:I lost all hope to go back to my roots
                    ******  [{run_away}]
                    -> DONE
        *** Your horns are bigger
            It's true, my mighty horns make me superior
            **** Without this outfit, you could like quite scary
                Really ?
                ***** Yes, your face is terrifying, only your outfit is ridiculous.
                    You are right, I should go back to my roots, I'll never wear this shirt again  # result:Dominos Jr:3:I was arrested for public exposure,I'm thriving in jail
                    ******  [{run_away}]
                    -> DONE
    ** Without this outfit, you could like quite scary
        Really ?
        *** Yes, your face is terrifying, only your outfit is ridiculous.
            You are right, I should go back to my roots, I'll never wear this shirt again  # result:Dominos Jr:3:I was arrested for public exposure,I'm thriving in jail
            **** [{run_away}]
                    -> DONE


