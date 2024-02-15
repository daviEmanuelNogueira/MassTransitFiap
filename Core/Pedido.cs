namespace Core;
public class Pedido
{
    public int Id { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime DataCriacao { get; set; }

    public Pedido(int id, Usuario usuario)
    {
        Id = id;
        Usuario = usuario;
        DataCriacao = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Pedido Id {Id}, Usuário {Usuario.Nome}, Data criação {DataCriacao:dd/MM/yyyy}.";
    }
}
