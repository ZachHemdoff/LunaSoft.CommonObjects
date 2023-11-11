using System;
using System.Collections.Generic;
using System.Text;

namespace LunaSoft.CommonObjects.Collections.Generic
{
    public class Dictionary<TKEY, TITEM> : System.Collections.Generic.Dictionary<TKEY, TITEM>, IObject
    {
        public new void Add(TKEY Key, TITEM Item)
        {
            try 
            {
                base.Add(Key, Item);

                OnInserted(Count - 1, new KeyValuePair<TKEY, TITEM>(Key, Item));

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected virtual void OnInserted(int index, KeyValuePair<TKEY, TITEM> Item)
        {

        }

        public new Type GetType()
        {
            return Type.TypeOf(this);
        }



    }
}
