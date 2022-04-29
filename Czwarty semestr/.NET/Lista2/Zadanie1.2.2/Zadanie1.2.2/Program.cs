using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadanie1._2._2
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;
        public T Value;

        public IEnumerable DFS()
        {
            yield return this.Value;
            if (this.Left != null)
            {
                foreach (object item in this.Left.DFS())
                {
                    yield return item;
                }
            }
            if (this.Right != null)
            {
                foreach (object item in this.Right.DFS())
                {
                    yield return item;
                }
            }
        }

        public IEnumerable BFS()
        {
            Queue<BinaryTreeNode<T>> q = new Queue<BinaryTreeNode<T>>();
            q.Enqueue(this);
            while (q.Count != 0)
            {
                BinaryTreeNode<T> node = q.Dequeue();
                if (node.Left != null)
                    q.Enqueue(node.Left);
                if (node.Right != null)
                    q.Enqueue(node.Right);
                yield return node.Value;
            }

        }

        public class MyBFSEnumerator : IEnumerator
        {
            private BinaryTreeNode<T> _parent;
            Queue<BinaryTreeNode<T>> q = new Queue<BinaryTreeNode<T>>();

            public MyBFSEnumerator(BinaryTreeNode<T> parent)
            {
                this._parent = parent;
                Reset();
            }

            public object Current
            {
                get
                {
                    BinaryTreeNode<T> n = q.Peek();
                    return n.Value;
                }
            }

            public bool MoveNext()
            {
                if (q.Peek().Left != null)
                    q.Enqueue(q.Peek().Left);
                if (q.Peek().Right != null)
                    q.Enqueue(q.Peek().Right);
                q.Dequeue();
                return (q.Count > 0);
            }

            public void Reset()
            {
                q.Clear();
                BinaryTreeNode<T> fr = new BinaryTreeNode<T>();
                fr.Left = this._parent;
                q.Enqueue(fr);
            }
        }

        public class MyDFSEnumerator : IEnumerator
        {
            private BinaryTreeNode<T> _parent;
            Stack<BinaryTreeNode<T>> q = new Stack<BinaryTreeNode<T>>();

            public MyDFSEnumerator(BinaryTreeNode<T> parent)
            {
                this._parent = parent;
                Reset();
            }

            public object Current
            {
                get
                {
                    BinaryTreeNode<T> n = q.Peek();
                    return n.Value;
                }
            }

            public bool MoveNext()
            {
                BinaryTreeNode<T> n = q.Pop();
                if (n.Right != null)
                    q.Push(n.Right);
                if (n.Left != null)
                    q.Push(n.Left);
                
                
                return (q.Count > 0);
            }

            public void Reset()
            {
                q.Clear();
                BinaryTreeNode<T> fr = new BinaryTreeNode<T>();
                fr.Left = this._parent;
                q.Push(fr);
            }
        }

        public IEnumerator GetEnumerator()
        {
            //return new MyBFSEnumerator(this);
            return new MyDFSEnumerator(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //       1
            //    /     \
            //   2       3
            //  / \      /
            // 10  0    4
            //    /      \
            //   5        7
            //  /
            //  6

            BinaryTreeNode<int> root = new BinaryTreeNode<int>()
            {
                Left = new BinaryTreeNode<int>()
                {
                    Left = new BinaryTreeNode<int>
                    {
                        Value = 10
                    },
                    Right = new BinaryTreeNode<int>
                    {
                        Left = new BinaryTreeNode<int>
                        {
                            Left = new BinaryTreeNode<int>
                            {
                                Value = 6
                            },
                            Value = 5
                        },
                        Value = 0
                    },
                    Value = 2
                },
                Right = new BinaryTreeNode<int>()
                {
                    Left = new BinaryTreeNode<int>()
                    {
                        Right = new BinaryTreeNode<int>()
                        {
                            Value = 7
                        },
                        Value = 4
                    },
                    Value = 3
                },
                Value = 1
            };

            foreach (object item in root.DFS())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");

            foreach (object item in root.BFS())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");

            foreach (object item in root)
            {
                Console.WriteLine(item);
            }
        }
    }
}
