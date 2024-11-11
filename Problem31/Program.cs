using System;
using System.Collections.Generic;
using System.Numerics;

public class TreeNode<T>
{
    public T Data { get; set; }
    public List<TreeNode<T>> Children { get; private set; }

    public TreeNode(T data)
    {
        Data = data;
        Children = new List<TreeNode<T>>();
    }

    public void AddChild(TreeNode<T> child)
    {
        Children.Add(child);
    }

    public void RemoveChild(TreeNode<T> child)
    {
        Children.Remove(child);
    }

    public void Traverse(TreeNode<T> node, Action<T> visitAction)
    {
        visitAction(node.Data); 

        foreach (var child in node.Children)
        {
            Traverse(child, visitAction);
        }
    }

    public List<TreeNode<T>> GetLeafNodes()
    {
        var leafNodes = new List<TreeNode<T>>();

        if (Children.Count == 0)
        {
            leafNodes.Add(this);
        }
        else
        {
            foreach (var child in Children)
            {
                leafNodes.AddRange(child.GetLeafNodes());
            }
        }

        return leafNodes;
    }
}

public class Problem31
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>
        {
            1,    // 1p
            2,    // 2p
            5,    // 5p
            10,   // 10p
            20,   // 20p
            50,   // 50p
            100,  // £1
            200   // £2
        };

        var root = new TreeNode<int>(200);
     
        while (true) {// All leaf nodes are not equal to zero
            List<TreeNode<T>> leafnodes = root.GetLeafNodes();
            foreach (var leafnode in leafnodes) {
                if(leafnode.Data > 0) {
                    foreach (var coin in values) {
                        int result = leafnode.Data - coin;
                        if (result >= 0) {
                            leafnode.AddChild(new TreeNode<int>(result));
                        }
                    }
                }   
            }
            if(allZeros(root.GetLeafNodes())) {
                break;
            }
            //loop through all leaf nodes, if node.data > 0
            //add child that is the result
        }
        
        Console.WriteLine(root.GetLeafNodes().Count);
        //return the count of the tree nodes
    }

    private static bool allZeros(List<TreeNode<int>> nums) {
        foreach (var num in nums) {
            if (num.Data != 0) {
                return false;
            }
        }
        return true;
    }
    
}
