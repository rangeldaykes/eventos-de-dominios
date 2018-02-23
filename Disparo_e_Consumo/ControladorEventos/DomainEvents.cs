
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Linq;
using Geracao.Interfaces;

public static class DomainEvents
{
    private static List<Type> handlers = new List<Type>();

    static DomainEvents()
    {
        handlers = 
        (
            from t in Assembly.GetExecutingAssembly().GetTypes()
            from i in t.GetInterfaces()
            where
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IHandler<>)
            select t
        ).ToList();
    }

    public static void Raise<T>(T @event) where T : IDomainEvent
    {
        handlers.ForEach(h =>
        {
            if (typeof(IHandler<T>).IsAssignableFrom(h))
                ((IHandler<T>)Activator.CreateInstance(h)).Handler(@event);
        });
    }
}