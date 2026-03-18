namespace Momento;

public class Originator
{
    private string content = string.Empty;

    public string getContent()
    {
        return content;
    }

    public Memento save()
    {
        return new Memento(content);
    }

    public void setContent(string contentToSet)
    {
        this.content = contentToSet;
    }
}