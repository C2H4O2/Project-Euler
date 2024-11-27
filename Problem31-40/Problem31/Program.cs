using System;
using System.Collections.Generic;
using System.Linq;

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

    // Method to get all leaf nodes
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
    static void Main()
    {
        List<int> values = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
        var paths = FindUniquePaths(values);
        Console.WriteLine("Total unique paths to zero: " + paths.Count);
    }

    private static List<List<int>> FindUniquePaths(List<int> values)
    {
        var root = new TreeNode<int>(200);
        var uniquePaths = new List<List<int>>();  // Store each complete path leading to zero

        while (true)
        {
            List<TreeNode<int>> leafNodes = root.GetLeafNodes();
            bool newChildrenAdded = false;

            foreach (var leafNode in leafNodes)
            {
                if (leafNode.Data > 0)  // Only branch if data > 0
                {
                    foreach (var coin in values)
                    {
                        int result = leafNode.Data - coin;

                        if (result >= 0)
                        {
                            // Check if this path reaches zero
                            if (result == 0)
                            {
                                // Store the complete path to zero
                                var pathToZero = GetFullPath(leafNode);
                                pathToZero.Add(0);  // Include the zero to mark end of path
                                uniquePaths.Add(pathToZero);
                            }
                            else
                            {
                                // Continue branching with new child node
                                leafNode.AddChild(new TreeNode<int>(result));
                                newChildrenAdded = true;
                            }
                        }
                    }
                }
            }

            // Stop if no new nodes were added in the current iteration
            if (!newChildrenAdded)
            {
                break;
            }
        }

        return uniquePaths;
    }

    // Helper method to get the full path to a node as a list of integers
    private static List<int> GetFullPath(TreeNode<int> node)
    {
        var path = new List<int>();
        while (node != null)
        {
            path.Add(node.Data);
            if (node.Children.Count > 0) node = node.Children[0];
            else break;
        }
        path.Reverse(); // Reverse to get path from root to leaf
        return path;
    }
}
