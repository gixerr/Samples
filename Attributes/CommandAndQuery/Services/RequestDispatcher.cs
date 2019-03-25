using CommandAndQuery.Attributes;
using System;

namespace CommandAndQuery.Services
{
    public class RequestDispatcher
    {
        public void Dispatch<T>(T request) where T : class
        {
            if (request is null)
            {
                throw new ArgumentException($"{nameof(request)} can not be null");
            }
            var requestKind = GetRequestKind<T>();
            if (requestKind == typeof(CommandAttribute))
            {
                Console.WriteLine($"{request.GetType().Name} is a command. Executing command hadler for {typeof(T)}");
            }
            if (requestKind == typeof(QueryAttribute))
            {
                Console.WriteLine($"{request.GetType().Name} is a query. Executing query hadler for {typeof(T)}");
            }
        }

        private Type GetRequestKind<T>() where T : class
        {
            var isCommand = Attribute.IsDefined(typeof(T), typeof(CommandAttribute));
            var isQuery = Attribute.IsDefined(typeof(T), typeof(QueryAttribute));
            if (!isCommand && !isQuery)
            {
                throw new ArgumentException("Request must be command or query.");
            }
            if (isCommand && isQuery)
            {
                throw new ArgumentException("Request can not be query and command simultaneously.");
            }
            return isCommand ? typeof(CommandAttribute) : typeof(QueryAttribute);
        }
    }
}
