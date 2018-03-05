
using Geracao.Services;

public class RepositorioDeContas
{
    public void Atualizar(ContaCorrente entidade)
    {
        // Atualizar Base de Dados

        DispararEventos(entidade);
    }
    private static void DispararEventos(Entidade entidade)
    {
        foreach (var evento in entidade.Eventos)
            DomainEvents.Dispatch(evento);

            entidade.RemoverEventos();
    }
}