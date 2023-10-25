namespace G19_20231021;

public class MyLinkedListNode<T>
{
	public T? Value { get; set; }
	public MyLinkedListNode<T>? Next { get; set; }

	public override string? ToString() => Value?.ToString();
}