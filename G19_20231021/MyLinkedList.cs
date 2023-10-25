using System.Collections;

namespace G19_20231021;

public class MyLinkedList<T> : IEnumerable<T>
{
    public MyLinkedListNode<T>? _first;
    public MyLinkedListNode<T>? _last;

    public MyLinkedList()
    {
        _first = null;
        _last = null;
    }

    #region  --Methods--

    public void AddFirst(MyLinkedListNode<T> node)
    {
        if (_first != null)
        {
            node.Next = _first;

        }
        _first = node;

        if (_last == null)
        {
            _last = node;
        }
    }


    public MyLinkedListNode<T> AddFirst(T value)
    {
        MyLinkedListNode<T> node = new() { Value = value };
        AddFirst(node);
        return node;
    }


    public void AddLast(MyLinkedListNode<T> node)
    {
        if (_last == null)
        {
            _first = node;
            _last = node;
        }
        else
        {
            _last.Next = node;
            _last = node;
        }
    }

    public MyLinkedListNode<T> AddLast(T value)
    {
        MyLinkedListNode<T> node = new() { Value = value };
        AddLast(node);
        return node;
    }

    #endregion
    public IEnumerator<T> GetEnumerator()
    {
        MyLinkedListNode<T> current = _first;

        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void AddAfter(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
    {
        throw new NotImplementedException();
    }

    public MyLinkedListNode<T> AddAfter(MyLinkedListNode<T> node, T value)
    {
        throw new NotImplementedException();
    }

    public void AddBefore(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
    {
        throw new NotImplementedException();
    }

    public MyLinkedListNode<T> AddBefore(MyLinkedListNode<T> node, T value)
    {
        throw new NotImplementedException();
    }
}
