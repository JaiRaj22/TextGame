namespace oopadv;

public static class Text
{
    private static Language _language;
    public static Language Language
    {
        get
        {
            if (_language == null)
            {
                throw new Exception("NO language loaded");
            }
            return _language;
        }
    }
    public static void LoadLanguage(Language language)
    {
        _language = language;
    }
}