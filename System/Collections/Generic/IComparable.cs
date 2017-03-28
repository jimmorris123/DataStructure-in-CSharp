namespace System.Collections.Generic
{
    internal interface IComparable<AnyType> where AnyType : IComparable<AnyType>
    {
    }
}