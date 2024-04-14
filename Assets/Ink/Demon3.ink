/*
Une gorgone trop productive, habillé en tailleur
- Objectif: être négligé dans le travail, redevenir paresseuse
- Décors:
	- Bureau
	- Setup plusieurs écran
	- Pile de documents de boulot
	- Canapé
	- Télé + enceinte
	- Plante verte en pot
- Musique: énergétique
 
 */
 
 /*
 poser des questions sur son travail : python programmer
 boring
 télé : diffuse les infos en continue
 --> suggestion : téléréalité, va faire koh-lanta
 canapé : dernière fois que tu as fait une sieste ? tu parais fatiguée ? tu as de petits yeux

computer mouse joke

s longs comme pronciation

pourquoi elle bosse trop ?
- syndrôme de l'imposterice
- programming is fun

outcomes:
- elle n'a rien changé, elle continue de bosser
- elle bosse encore plus, la situation a empiré
- 
 */

-> lonely_gorgon

VAR couch = false
VAR tv = false
VAR computer = true
VAR run_away = "Leave"

=== intro ===

Nicccce to ssssee you.
* Who are you ?
    I am Zola the Gorgon, I need your help
    ** What is the problem this time ?
        I work too much, I'd like to change that.
        *** Understood, I'll be with you in a minute.
            -> lonely_gorgon

=== lonely_gorgon ===

- (start_choices)
Have you an idea how I can work lessss ?
* Why do you work so much ?
    I'm trying to sssave money to buy nice things
    ** {tv} You mean like your huge TV
        Yes, exactly but I don't like human news
        *** Have ever tried reality shows ?
            I never tried those
            **** They really showcase the worst of humanity
                I need to give it a try !
                # result:Zola:5:I binge watch the Kardashians instead of working. It was terrible, I loved it !
                ***** [{run_away}]
                        -> DONE
    ** Why not invest in NFTs instead ?
        What is that ?
        *** The best way to make a fortune
            Really ? I will give it a try then after my work
            **** Your salary can't compare
                I will quit my job then 
                # result:Zola:3:I lost all my sssavings but I spend all my days sssleeping now
                *****  [{run_away}]
                        -> DONE
        
* What is your job ?
    I'm a Pythhhhon programmer.
    ** Is the pun intended ?
        What pun ?
        *** Never mind. You like your work ?
            Not too much. I feel like a fraud.
            **** Because you are viper ?
                No, that's offensive to say !
                ***** I didn't know.
                    Leave before I kill you with my poison. # result:Zola:2:This rude person is completely useless
                    ~ run_away = "RUN AWAY"
                    ****** [{run_away}]
                        -> DONE
* { computer } I saw some Python code on your computer.
    Yessss, it'ssss a ssscript I'm working on.
    ** Not too complicated I hope ?
        Actually, a bit. It'ssss giving me headaches.
        *** { couch } have you tried to take a break ?
            I'm under a lot of pressure to deliver it by next Tuesssssday.
                **** So you still have time to rest. Go nap!
                    I'll do that after you leave.  # result:Zola:4:The adviccccesss were great, I learned how to procrasssstinate
                        *****  [{run_away}]
                        -> DONE
        *** I could take a look if you want.
            Yesssss, pleasssse.
            **** Oups, it seems I deleted all your work.
                WHATTTTT?! I'll sssslit your thhhroat !  # result:Zola:1:Thissss bassstard erasssed weekssss of labor. Avoid at all cosssst !
                    ~ run_away = "RUN AWAY"
                    *****  [{run_away}]
                        -> DONE
                
                    

 