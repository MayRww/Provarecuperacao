  public class Aluno
{
	public int Id { get; set; }
	public string Nome { get; set; }
	public decimal Imc { get; set; }
    
    public Datetime CriadoEm {get;set;} = Datetime.Now;
}
