namespace GenericClasses
{
	public class LinkedList<T>
	{
		public T Data { get; set; }
		public LinkedList<T>? List { get; set; }

		public LinkedList(T data, LinkedList<T>? linkedList)
		{
			Data = data;
			List = linkedList;
		}

	}
}
