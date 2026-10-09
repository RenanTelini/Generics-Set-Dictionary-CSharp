# Generics, Set, Dictionary and Hash collections - C#

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

#### This repository covers the concepts and use of Generics, Set, Dictionary, HashSet and SortedSet collections in C#.

### <ins>Generics</ins>

#### Generics allow classes, interfaces, and methods to be parameterized by type. Their benefits include:

- Reusability
- Type Safety
- Performance

### <ins>Solution with Generics</ins>

#### Write a program that reads a set of N integers, where N ranges from 1 to 10. Then, display the numbers in an organized format, as shown in the example. Finally, display the first value entered.

<img src="Imagens\PrinService - UML.png" alt="PrinService - UML">

#### Example:

How many values? <strong>3</strong><br>
<strong>10</strong><br>
<strong>8</strong><br>
<strong>23</strong><br>
[10, 8, 23]<br>
First: 10

### <ins>Restrictions for Generics</ins>

#### A consulting company wants to evaluate the performance of products, employees, and other things. One of the calculations it needs is to find the largest value among a set of elements. Write a program that reads a set of N products, as shown in the example, and then displays the most expensive one.

<img src="Imagens\Restrictions for Generics - UML.png" alt="Restrictions for Generics - UML">

#### Example:

Enter N: 3</strong><br>
<strong>Computer,890.50</strong><br>
<strong>IPhone X,910.00</strong><br>
<strong>Tablet,550.00</strong><br>
Max:<br>
IPhone, 910.00<br>

### <ins>HashSet and SortedSet</ins>

#### Represents a collection of elements (similar to sets in algebra)

- Does not allow duplicates
- Elements have no specific order
- Fast access, insertion, and removal of elements
- Provides efficient set operations: intersection, union, and difference

#### Differences

#### HashSet

 - Stores elements in a hash table
 - Extremely fast: insertion, removal, and lookup - O(1)
 - Element order is not guaranteed