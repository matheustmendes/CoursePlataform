namespace CoursePlataform.ContentContext;

public class Lecture
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int OrderInModule { get; set; }
    /// <summary>
    /// A classe Lecture não precisa saber se o conteúdo é um vídeo, um artigo ou um quiz. Ela só precisa saber que vai receber "algo" que cumpre o contrato de Content.
    /// Isso é uma boa prática de programação, pois evita que a classe Lecture dependa de implementações específicas, tornando o código mais flexível e fácil de manter.
    /// </summary>
    public Content ContentItem { get; set; }
    
    public Lecture(int id, string title, int orderInModule, Content contentItem)
    {
        Id = id;
        Title = title;
        OrderInModule = orderInModule;
        ContentItem = contentItem;
    }
}