using System.Collections;

namespace StringTransform
{
    class TextTransformer : IEnumerable
    {
        public TextTransformer(int Amount)
        {
            tempstring = new string[Amount];
        }
        public string[] tempstring;

        public IEnumerator GetEnumerator()
        {
            for (int Counter = 0; Counter < tempstring.Length; Counter++)
            {
                if (tempstring[Counter] == null)
                {
                    yield return tempstring[Counter] = "valuable";
                }
                else
                {
                    yield return tempstring[Counter].ToUpper();
                }
            }
        }
    }
}
