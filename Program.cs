SimpleStack<string> stack = new SimpleStack<string>();
stack.Push("Sword");    
stack.Push("Shield");
stack.Push("Potion");


Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Count);

