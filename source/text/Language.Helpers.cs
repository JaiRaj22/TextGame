using System.Text;

namespace oopadv;
public partial class Language
{
    private readonly StringBuilder _sb = new();

    public virtual string JoinedWordlist (string[] words, string conjuction)
    {
        _sb.Clear();
        for(var i=0; i<words.Length; i++)
        {
            if(i>0)
            {
                _sb.Append(words.Length > 2 ? Comma + Space : Space);
            }
            if( i== words.Length-1 && words.Length>1) 
            {
                _sb.Append(conjuction + Space);
            }
            _sb.Append(words[i]);
        }
        return _sb.ToString();
    }
}