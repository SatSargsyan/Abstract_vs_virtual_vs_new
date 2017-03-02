# Abstract vs virtual vs new
The <a href=https://msdn.microsoft.com/en-us/library/aa645615(v=vs.71).aspx> abstract </a> modifier is used to indicate that a class is incomplete and that it is intended to be used only as a base class. An abstract class differs from a non-abstract class in the following ways:
<ul>
<li>An abstract class cannot be instantiated directly, and it is a compile-time error to use the new operator on an abstract class. While it is possible to have variables and values whose compile-time types are abstract, such variables and values will necessarily either be null or contain references to instances of non-abstract classes derived from the abstract types.
<li>An abstract class is permitted (but not required) to contain abstract members.
<li>An abstract class cannot be sealed.
</ul>
When a non-abstract class is derived from an abstract class, the non-abstract class must include actual implementations of all inherited abstract members, thereby overriding those abstract members.
```C#
abstract class A
{
   public abstract void F();
}
abstract class B: A
{
   public void G() {}
}
class C: B
{
   public override void F() {
      // actual implementation of F
   }
}
```
The abstract class A introduces an abstract method F. Class B introduces an additional method G, but since it doesn't provide an implementation of F,<b> B must also be declared abstract</b>. Class C overrides F and provides an actual implementation. Since there are no abstract members in C, C is permitted (but not required) to be non-abstract.
