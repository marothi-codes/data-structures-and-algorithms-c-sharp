#nullable disable

namespace BinaryTree;
public class BinarySearchTree<T> where T : IComparable<T>
{
	public Node<T> Root { get; set; }

	public void Insert(T value)
	{
		Root = Insert(Root, value);
	}

	public bool Search(T value)
	{
		return Search(Root, value) != null;
	}

	public void Delete(T value)
	{
		Root = Delete(Root, value);
	}

	public void TraverseInOrder()
	{
		TraverseInOrder(Root);
		Console.WriteLine();
	}

	private static Node<T> FindMinNode(Node<T> node)
	{
		Node<T> current = node;

		while (current.Left != null)
		{
			current = current.Left;
		}

		return current;
	}

	private static Node<T> Insert(Node<T> node, T value)
	{
		if (node == null)
			return new Node<T>(value);

		int compare = value.CompareTo(node.Value);

		if (compare < 0)
			node.Left = Insert(node.Left, value);
		else if (compare > 0)
			node.Right = Insert(node.Right, value);

		return node;

	}

	private static Node<T> Search(Node<T> node, T value)
	{
		if (node == null)
		{
			return null;
		}

		int compare = value.CompareTo(node.Value);

		if (compare < 0)
		{
			return Search(node.Left, value);
		}
		else if (compare > 0)
		{
			return Search(node.Right, value);
		}
		else
		{
			return node;
		}
	}

	private Node<T> Delete(Node<T> node, T value)
	{
		if (node == null)
		{
			return null;
		}

		int compare = value.CompareTo(node.Value);

		if (compare < 0)
		{
			node.Left = Delete(node.Left, value);
		}
		else if (compare > 0)
		{
			node.Right = Delete(node.Right, value);
		}
		else
		{
			if (node.Left == null)
			{
				return node.Right;
			}
			else if (node.Right == null)
			{
				return node.Left;
			}
			else
			{
				Node<T> temp = FindMinNode(node.Right);
				node.Value = temp.Value;
				node.Right = Delete(node.Right, temp.Value);
			}
		}

		return node;
	}

	private static void TraverseInOrder(Node<T> node)
	{
		if (node != null)
		{
			TraverseInOrder(node.Left);
			Console.Write(node.Value + " ");
			TraverseInOrder(node.Right);
		}
	}

}
