using System.Text;


namespace DataStructure
{
    public class ReverseWordInString
    {
        //TODO: never never user += when concatenating strings, This is because each concatenation with +=
     //creates a new string object, which can lead to increased memory usage, especially for large strings
        public string ReverseWords(string s)
            {
                if (s.Length == 0)
                    return s;
            string[] str = s.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var reversedString = new StringBuilder();
          
               for(int i = str.Length -1; i >0 ; i--)
            {
                reversedString.Append(str[i]);  
            }
            reversedString.Append(str[0]);

            return reversedString.ToString();
            }
        }
    
}
//TODO: this was my first solution.
/*public string ReverseWords(string s)
{
    if (s.Length == 0)
        return s;
    var stack = new Stack<string>();

    var helperString = new StringBuilder(s);
    int i = 0;
    while (i < s.Length)
    {
        if (s[i] == ' ')
        {

            helperString[i] = '8';
            i++;
        }
        else
        {
            var spaceIndex = helperString.ToString().IndexOf(' ');
            var word = spaceIndex != -1 ? s.Substring(i, spaceIndex - i) : s.Substring(i);
            stack.Push(word);
            i = spaceIndex == -1 ? s.Length : spaceIndex;
        }
    }

    var reversedString = new StringBuilder();

    while (stack.Count != 0)
    {
        reversedString.Append(stack.Pop());
        if (stack.Count != 0)
            reversedString.Append(' ');
    }
    return reversedString.ToString();
}*/