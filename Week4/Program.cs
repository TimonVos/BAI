// OpgaveStackCalc("28+39*+=367+*=");
Random r = new Random();

Queue<int> queue = new Queue<int>();
for (int i = 0; i < 20; i++)
{
    queue.Enqueue(r.Next(100));
}
foreach (var item in queue)
{
    Console.WriteLine(item);
}
Console.Write("\n\n");
OpgaveQueueRev(queue);

foreach (var item in queue)
{
    Console.WriteLine(item);
}

static void OpgaveStackCalc(string input)
{
    Stack<int> stack = new Stack<int>();
    for (int i = 0; i < input.Length; i++)
    {
        if ((input[i] - '0') >= 0 && (input[i] - '0') < 10)
        {
            stack.Push((input[i] - '0'));
        }
        else
        {
            switch (input[i])
            {
                case '*':
                    stack.Push((stack.Pop() * stack.Pop()));
                    break;
                case '/':
                    stack.Push((stack.Pop() / stack.Pop()));
                    break;
                case '+':
                    stack.Push((stack.Pop() + stack.Pop()));
                    break;
                case '-':
                    stack.Push((stack.Pop() - stack.Pop()));
                    break;
            }
        }
    }
    foreach (var item in stack)
    {
        Console.WriteLine(item);
    }

}

static void OpgaveQueueRev(Queue<int> inputQueue)
{
    Stack<int> tempStack = new Stack<int>();
    while (inputQueue.Count != 0)
    {
        tempStack.Push(inputQueue.Dequeue());
    }
    while (tempStack.Count != 0)
    {
        inputQueue.Enqueue(tempStack.Pop());
    }
}