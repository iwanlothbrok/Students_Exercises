Stack<int> stack = new Stack<int>();


stack.Push(7);
stack.Push(6);
stack.Push(5);
stack.Push(4);
stack.Push(3);
stack.Push(2);
stack.Push(1);
stack.Push(0);

//Извършени са следните операции: push 5, pop, pop,
//pop, pop, push 3, pop, pop.След операциите стекът съдържа следни

stack.Push(5);
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Push(3);
stack.Pop();
stack.Pop();

