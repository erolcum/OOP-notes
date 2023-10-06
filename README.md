# OOP-notes
Object-Oriented Programming notes

**Program :** Although derived classes inherit	the	members	of	their	parent	base	class,	they	do	not	inherit	its
constructor	method. A constructor	method	of	the	base	class	is	always	called	when	a
new	object	of	a	derived	class	is	created. Call the overloaded base constructor with **: base** keyword.<br><br>
![Ekran Alıntısı](https://github.com/erolcum/OOP-notes/assets/110387801/47aba4c5-24eb-43ca-846d-3ab6b448987e)<br><br>
**Program-2 :** Hiding base method and calling base method<br>
**Program-3 :** Directing	method	calls with **virtual** and **override**. It is an example of Polymorphism<br>
**Program-4 :** **abstract** class<br>

# Abstract class VS Interface

1. Abstract class contains both **Declaration & Definition** for methods. Interface should contains only **Declaration**. (With C# 8.0, you can define a method in interface, but it may be useful for special cases)
2. Abstract class does not support **multiple inheritances**. But interface supports it.
3. Abstact class can have **constructors**. But interface can not.
4. Abstract class is inherited. Interface is implemented.
5. Abstract class is a partially defined base class. But interface is a contract, it gives 100% abstraction. You don't need to use public in front of a method in an interface, because it is already public.
6. Abstract class can be written with all abstact methods then it may be seem like an interface. But you can have design issues later in the code.
7. Abstact class can be derived from an interface. But the opposite is not possible.
8. 
   
