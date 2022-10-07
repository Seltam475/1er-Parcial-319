from pyswip import Prolog

prolog = Prolog()
prolog.assertz("antecesor(Mateo,Paola)")
prolog.assertz("antecesor(Paola,Camilo)")
prolog.assertz("antecesor(Roberto,Camilo)")
prolog.assertz("antecesor(Pedro,Luis)")
prolog.assertz("antecesor(Luis,Soledad)")
prolog.asserta("abuelo(X,Y):-antecesor(X,Z),antecesor(Z,Y)")
prolog.asserta("nieto(X,Y):-antecesor(Z,X),antecesor(Y,Z)")
prolog.asserta("hermano(X,Y):-antecesor(Z,X),antecesor(Z,Y),X\=Y")
prolog.asserta("primo(X,Y):-antecesor(Z,X),antecesor(W,Y),hermano(Z,W),X\=Y")


abuelos = list(prolog.query("abuelo(X,Y)"))

for abuelo in abuelos:
    print ("   ",abuelo["X"], " es abuelo/a de ",abuelo["Y"] )
    
nietos= list(prolog.query("nieto(X,Y)"))

for nieto in nietos:
    print ("   ",nieto["X"], " es nieto/a de ",nieto["Y"] )
    
primos = list(prolog.query("primo(X,Y)"))

for primo in primos:
    print ("   ",primo["X"], " es primo/a de ",primo["Y"] )

prolog.retractall("antecesor(X,Y)")
prolog.retractall("abuelo(X,Y)")
prolog.retractall("nieto(X,Y)")
prolog.retractall("hermano(X,Y)")
prolog.retractall("primo(X,Y)")
