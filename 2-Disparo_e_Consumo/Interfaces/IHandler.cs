

using Geracao.Interfaces;

public interface IHandler<T> where T : IDomainEvent
{
    void Handler(T @event);
}