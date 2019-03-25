using CommandAndQuery.Commands;
using CommandAndQuery.Queries;
using CommandAndQuery.Services;

namespace CommandAndQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestDispatcher = new RequestDispatcher();
            var command = new Execute();
            requestDispatcher.Dispatch(command);
            var query = new SomeQuery();
            requestDispatcher.Dispatch(query);
            var someCommand = new SomeCommad();
            requestDispatcher.Dispatch(someCommand);
            var ask = new Ask();
            requestDispatcher.Dispatch(ask);
        }
    }
}
