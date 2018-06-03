using System;
using System.Collections.Generic;
using System.IO;

namespace Basic_Tech_Stack
{
    internal class DatetimeOverlap
    {
        public DatetimeOverlap()
        {
            try
            {
                string path = @"D:\Basic Tech Stack\Basic Tech Stack\Data\1.in";

                TextReader rd = Console.In;
                rd = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                new Solution().Run(rd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }
    }
    public class Slot
    {

        public int Task { get; set; }

        public int Time { get; set; }

        public int Difference { get; set; }

        public Slot(int task, int time, int diff)
        {
            this.Time = time;
            this.Task = task;
            this.Difference = diff;
        }

        public override string ToString()
        {
            if (Task - 1 < 0) Task = 1;
            return string.Format("T{0}              {1}               {2} ", (Task - 1), Time, Difference);
        }
    }

    public class Solution
    {

        private int max = 0;
        private LinkedList<Slot> slots = new LinkedList<Slot>();
        private LinkedListNode<Slot> maxNode = null;

        private void ParseLine(string ln, out int D, out int M)
        {
            string[] parts = ln.Split(' ');
            D = int.Parse(parts[0]);
            M = int.Parse(parts[1]);
        }

        private void Clean()
        {
            try
            {
                LinkedListNode<Slot> first = slots.First;
                LinkedListNode<Slot> node = maxNode.Previous;

                while (node != null && node != first)
                {
                    LinkedListNode<Slot> lastNode = node.Previous;
                    slots.Remove(node);
                    node = lastNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }

        private void PostProcess(LinkedListNode<Slot> slotNode, int diff, int T, int M)
        {
            try
            {

                Slot slot = slotNode.Value;
                LinkedListNode<Slot> newNode = new LinkedListNode<Slot>(new Slot(T, slot.Time + M, diff));
                slots.AddAfter(slotNode, newNode);
                if (diff > max)
                {
                    max = diff;
                    maxNode = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }

        private int FindMax(int T, int D, int M)
        {
            try
            {

                LinkedListNode<Slot> slotNode = slots.Last;

                for (; ; )
                {
                    LinkedListNode<Slot> lastSlotNode = slotNode.Previous;

                    Slot slot = slotNode.Value;

                    int diffOfStay = slot.Time + M - D;

                    if (lastSlotNode == null)
                    {
                        PostProcess(slotNode, diffOfStay, T, M);
                        break;
                    }

                    Slot lastSlot = lastSlotNode.Value;
                    int diffOfMoveUp = lastSlot.Time + M - D;
                    int maxOfMoveUp = Math.Max(diffOfMoveUp, slot.Difference + M);
                    int maxOfStay = Math.Max(diffOfStay, slot.Difference);

                    if (maxOfMoveUp < maxOfStay)
                    {
                        slot.Difference += M;
                        slot.Time += M;
                        if (slot.Difference > max)
                        {
                            max = slot.Difference;
                            maxNode = slotNode;
                        }
                        slotNode = lastSlotNode;
                    }
                    else
                    {
                        PostProcess(slotNode, diffOfStay, T, M);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
            Clean();
            return max;


        }

        private void Print()
        {
            foreach (var slot in slots)
            {
                Console.WriteLine(slot);
            }
        }

        public void Run(TextReader rd)
        {
            try
            {
                int T = int.Parse(rd.ReadLine());
                int D, M;

                slots.AddFirst(new Slot(0, 0, 0));
                maxNode = slots.First;

                Console.WriteLine("Task#       Deadline          Accomplish");
                Console.WriteLine("--------------------------------------");

                for (int i = 1; i <= T; i++)
                {
                    ParseLine(rd.ReadLine(), out D, out M);
                    FindMax(i, D, M);
                    Console.WriteLine("T{0}            {1}                  {2}", i - 1, D, M);
                }

                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Task#       Differnce          Overshoot");
                Console.WriteLine("--------------------------------------");

                Print();

                Console.WriteLine("--------------------------------------");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }
    }
}
