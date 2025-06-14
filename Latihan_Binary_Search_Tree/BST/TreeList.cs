using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BST
{
    public class TreeList
    {
        private TreeNode root;
        private int size = 1;

        public TreeList()
        {
            root = null;
        }

        public void add_data(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data, null);
            }
            else
            {
                TreeNode bantu = root;
                while (bantu != null)
                {
                    if (data < bantu.getElemen())
                    {
                        if (bantu.getLeftChild() == null)
                        {
                            bantu.setLeftChild(new TreeNode(data, bantu));
                            size++;
                            bantu = null;
                        }
                        else
                        {
                            bantu = bantu.getLeftChild();
                        }
                    }
                    else
                    {
                        if (bantu.getRightChild() == null)
                        {
                            bantu.setRightChild(new TreeNode(data, bantu));
                            size++;
                            bantu = null;
                        }
                        else
                        {
                            bantu = bantu.getRightChild();
                        }
                    }

                }
            }
        }

        public void print_preorder(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.getElemen() + ", ");
                print_preorder(node.getLeftChild());
                print_preorder(node.getRightChild());
            }
        }

        public void print_inorder(TreeNode node)
        {
            if (node != null)
            {
                print_inorder(node.getLeftChild());
                Console.Write(node.getElemen() + ", ");
                print_inorder(node.getRightChild());

            }
        }


        public void print_postorder(TreeNode node)
        {
            if (node != null)
            {
                print_postorder(node.getLeftChild());
                print_postorder(node.getRightChild());
                Console.Write(node.getElemen() + ", ");
            }
        }

        public int search(int data)
        {
            TreeNode bantu = getRoot();
            while (bantu != null)
            {
                if (bantu.getElemen() == data)
                {
                    return bantu.getElemen();
                }
                else if (data < bantu.getElemen())
                {
                    bantu = bantu.getLeftChild();
                }
                else
                {
                    bantu = bantu.getRightChild();
                }
            }
            return -1;
        }

        public TreeNode get_Node(int data)
        {
            TreeNode bantu = getRoot();

            while (bantu != null)
            {
                if (bantu.getElemen() == data)
                {
                    return bantu;
                }
                else if (data < bantu.getElemen())
                {
                    try
                    {
                        if (bantu.getLeftChild().getElemen() == data)
                        {
                            return bantu.getLeftChild();
                        }
                        else
                        {
                            bantu = bantu.getLeftChild(); ;
                        }
                    }
                    catch (System.Exception)
                    {

                        return null;
                    }
                }
                else
                {
                    try
                    {
                        if (bantu.getRightChild().getElemen() == data)
                        {
                            return bantu.getRightChild();
                        }
                        else
                        {
                            bantu = bantu.getRightChild();
                        }
                    }
                    catch (System.Exception)
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        public Boolean isLeaf(int a)
        {
            TreeNode bantu = get_Node(a);
            if (bantu.getLeftChild() == null & bantu.getRightChild() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TreeNode get_Predecessor(TreeNode x)
        {
            if (x.getLeftChild() == null)
            {
                return null;
            }
            else
            {
                x = x.getLeftChild();
                while (x.getRightChild() != null)
                {
                    x = x.getRightChild();
                }
            }
            return x;   
        }

        public TreeNode delete_node(int x)
        {
            TreeNode bantu = get_Node(x);
            if (bantu == null)
            {
                return null;
            }
            else
            {
                // hapus root  memiliki 1 anak
                if (bantu.getElemen() == getRoot().getElemen())
                {
                    if (isLeaf(bantu.getElemen()))
                    {
                        setRoot(null);
                    }
                    else if (bantu.getRightChild() == null)
                    {
                        setRoot(bantu.getLeftChild());
                        getRoot().setParent(null);
                    }
                    else if (bantu.getLeftChild() == null)
                    {
                        setRoot(bantu.getRightChild());
                        getRoot().setParent(null);
                    }
                    else
                    {
                        // hapus root memiliki 0 anak
                        TreeNode predecessor = get_Predecessor(bantu);
                        TreeNode parent_predecessor = predecessor.getParent();
                        bantu.setElemen(predecessor.getElemen());

                        if (parent_predecessor != bantu)
                        {
                            if (predecessor.getLeftChild() != null)
                            {
                                parent_predecessor.setRightChild(predecessor.getLeftChild());
                            }
                            else
                            {
                                parent_predecessor.setRightChild(null);

                            }
                        }
                        else
                        {
                            bantu.setLeftChild(predecessor.getLeftChild());
                        }
                    }
                }
                else
                {
                    TreeNode parent_node = bantu.getParent();
                    if (bantu.getElemen() < parent_node.getElemen())
                    {
                        if (isLeaf(bantu.getElemen()))
                        {
                            // Hapus 0 anak
                            parent_node.setLeftChild(null);
                        }
                        else if (bantu.getLeftChild() == null)
                        {
                            // Hapus 1 anak (SubTree kiri)
                            parent_node.setLeftChild(bantu.getLeftChild());
                            bantu.getLeftChild().setParent(bantu.getParent());
                        }
                        else if (bantu.getLeftChild() == null)
                        {
                            // Hapus 1 anak (SubTree kiri)

                            parent_node.setLeftChild(bantu.getRightChild());
                            bantu.getLeftChild().setParent(bantu.getParent());
                        }
                        else
                        {
                            // Hapus Root (Memiliki 2 anak)
                            TreeNode predecessor = get_Predecessor(bantu);
                            TreeNode parent_predecessor = predecessor.getParent();
                            bantu.setElemen(predecessor.getElemen());
                            if (parent_predecessor != bantu)
                            {
                                if (predecessor.getLeftChild() != null)
                                {
                                    parent_predecessor.setRightChild(predecessor.getLeftChild());
                                }
                                else
                                {
                                    parent_predecessor.setRightChild(null);
                                }
                            }
                            else
                            {
                                bantu.setLeftChild(predecessor.getRightChild());
        
                            }
                        }
                    }
                    else
                    {
                        if (isLeaf(bantu.getElemen()))
                        {
                            // Hapus 0 anak
                            parent_node.setRightChild(null);
                        }
                        else if (bantu.getRightChild() == null)
                        {
                            // Hapus 1 anak (SubTree Kanan)
                            parent_node.setRightChild(bantu.getLeftChild());
                            bantu.getLeftChild().setParent(bantu.getParent());
                        }
                        else if (bantu.getLeftChild() == null)
                        {
                            // Hapus 1 anak (SubTree Kanan)
                            parent_node.setRightChild(bantu.getRightChild());
                            bantu.getRightChild().setParent(bantu.getParent());
                        }
                        else
                        {
                            // Hapus Root (memiliki 2 anak)
                            TreeNode predecessor = get_Predecessor(bantu);
                            TreeNode parent_predecessor = predecessor.getParent();
                            bantu.setElemen(predecessor.getElemen());
                            if (parent_predecessor != bantu)
                            {
                                if (predecessor.getLeftChild() != null)
                                {
                                    parent_predecessor.setRightChild(predecessor.getLeftChild());
                                }
                                else
                                {
                                    parent_predecessor.setRightChild(null);
                                }
                            }
                            else
                            {
                                bantu.setLeftChild(predecessor.getLeftChild());
                            }
                        }

                    }
                }
            }
            return bantu;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getSize()
        {
            return size;
        }
        public void setRoot(TreeNode root)
        {
            this.root = root;
        }

        public TreeNode getRoot()
        {
            return root;
        }
    }
}