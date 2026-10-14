public class Country
{
    string name;
    string capital;
    int population;
    string Language;
    public Country(){}
    public Country(string name, string capital, int pop, string lan)
    {
        this.name=name;
        this.capital=capital;
        population=pop;
        Language=lan;
    }
    public void SetCapital(string a)
    {
        capital=a;
    }
    public string GetCapital()
    {
        return capital;
    }
    public void SetPop(int a)
    {
        population=a;
    }
    public int GetPop()
    {
        return population;
    }
    public void SetLanguage(string a)
    {
        Language=a;
    }
    public string GetLanguage()
    {
        return Language;
    }
}