using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BST
{
    public class TreeNode
    {
        private TreeNode left_child;
        private TreeNode right_child;
        private TreeNode parent;
        private int elemen;
        private char character;

        public TreeNode()
        {

        }

        public TreeNode(int data, TreeNode parent)
        {
            this.elemen = data;
            right_child = left_child = null;
            this.parent = parent;
        }

        public void setLeftChild(TreeNode left_child)
        {
            this.left_child = left_child;
        }

        public TreeNode getLeftChild()
        {
            return left_child;
        }

        public void setRightChild(TreeNode right_child)
        {
            this.right_child = right_child;
        }

        public TreeNode getRightChild()
        {
            return right_child;
        }

        public void setParent(TreeNode parent)
        {
            this.parent = parent;
        }

        public TreeNode getParent()
        {
            return parent;
        }

        public void setElemen(int elemen)
        {
            this.elemen = elemen;
        }

        public int getElemen()
        {
            return elemen;
        }

        public char getCharacter(char character)
        {
            return character;
        }

        public void setCharacter(char character)
        {
            this.character = character;
        }
    }
}