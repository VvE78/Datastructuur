using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuur
{
    
    public class Systeem
    {
        private List<Item> list;

        public Systeem()
        {
            list = new List<Item>();
        }

        public Item AddItem(Item item)
        {
            Items.Add(item);
            return item;
        }

        public List<Item> Items { get { return list; } }

        public override string ToString()
        {
            string output = "Systeem bevat " + Items.Count.ToString() + " items";
            foreach (Item item in Items)
            {
                output += Environment.NewLine + item.ToString();                
            }
            return output;
        }

        public List<Item> ToplevelItems()
        {
            var TLI = from i in Items where i.Reason == null select i;
            var Result = new List<Item>();
            foreach (Item i in TLI)
                Result.Add(i);
            return Result;            
        }

//        public List<Item> LowlevelItems()
        //{ 
        //  //  var LLI = from i in Items where i.reas
        //}

        public List<Item> NextActions()
        {
            var NA = from i in Items where i.IsActionable == true select i;
            var Result = new List<Item>();
            foreach (Item i in NA)
                Result.Add(i);
            return Result;
        }
    }

    public class Item
    {
        public string Titel;

        public Item Reason;

        public bool IsActionable;

        public override string ToString()
        {
            if (Reason == null)
                return Titel + "; Reason = leeg" + "; IsActionable = " + IsActionable.ToString();
            else
                return Titel + "; Reason = " + Reason.Titel + "; IsActionable = " + IsActionable.ToString();
        }
    }
}
