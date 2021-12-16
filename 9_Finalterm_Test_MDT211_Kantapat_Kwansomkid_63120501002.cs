using System;

namespace _9_Finalterm_Test_MDT211_Kantapat_Kwansomkid_63120501002
{
    private Classic Skill;

    public void Push(Node node)
    {
        if (root == null)
        {
            root = node;
        }
        else
        {
            Node ptr = root;
            while (ptr.Next != null)
            {
                ptr = ptr.Next;
            }
            ptr.Next = node;
        }
    }

    public Node Pop()
    {
        Node node = root;
        if (root != null)
        {
            root = root.Next;
            node.Next = null;
        }
        return node;
    }

    public int GetLength()
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            Node ptr = root;
            int length = 1;
            while (ptr.Next != null)
            {
                ptr = ptr.Next;
                length++;
            }
            return length;
        }
    }

    public override string ToString()
    {
        string message = "";
        if (root != null)
        {
            Node ptr = root;
            message = message + "," + root;
            while (ptr.Next != null)
            {
                ptr = ptr.Next;
                message = message + "," + ptr;
            }
        }
        return message;
    }
}
