# Generics, Set, Dictionary and Hash collections - C#

#### This exercise is based on the <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MT260714G2">"C# COMPLETO Programação Orientada a Objetos + Projetos"</a> course.

#### This repository covers the concepts and use of Generics, Set, Dictionary, HashSet, SortedSet, GetHashCode and Equals collections in C#.

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

#### SortedSet

- Stores elements in a tree
- Fast: insertion, removal, and lookup - O(log(n))
- Elements are stored in sorted order, according to the implementation of `IComparer<T>`

### <ins>GetHashCode and Equals<ins>

#### These are methods from the `Object` class used to determine whether one object is equal to another.

#### `Equals`: slower, but provides an exact comparison result.

#### `GetHashCode`: faster, but matching hash codes do not guarantee that two objects are equal.

#### Built-in types already provide implementations of these methods. Custom classes and structs need to override them.

#### How Do Hash Collections Test Equality?

#### If `GetHashCode` and `Equals` are implemented:

- First, `GetHashCode` is called. If the hash codes match, `Equals` is used to confirm equality.

#### If `GetHashCode` and `Equals` are NOT implemented:

- Reference types: compare object references.
- Value types: compare the values of their fields.

### <ins>GetHashCode and Equals: Example Problem<ins>

#### A website records a log of user visits. Each log entry consists of the username and the timestamp when the user accessed the website, in ISO 8601 format, separated by a space, as shown in the example.

#### Write a program that reads the access log from a file and reports how distinct users accessed the website.

#### Example:

<strong>Input file:</strong><br>
amanda 2020-08-26T20:45:08<br>
alex86 2020-08-26T21:49:37<br>
bobbrown 2020-08-27T03:19:13<br>
amanda 2020-08-27T08:11:00<br>
jeniffer3 2020-08-27T09:19:24<br>
alex86 2020-08-27T22:39:52<br>
amanda 2020-08-28T07:42:19

<strong>Execution:</strong><br>
Enter file full path: <strong>c:\temp\in.txt</strong><br>
Total users: 4