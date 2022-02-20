using advanced_multi_threading;
using advanced_multi_threading.PLINQ;
using Semaphore = advanced_multi_threading.Semaphore;

//new Thread(() => ThreadUnsafe.Operation()).Start();
//new Thread(() => ThreadUnsafe.Operation()).Start();
//new Thread(() => ThreadUnsafe.Operation()).Start();

//new Thread(() => ThreadSafe.Operation()).Start();
//new Thread(() => ThreadSafe.Operation()).Start();
//new Thread(() => ThreadSafe.Operation()).Start();

//Semaphore.Start();

//new Thread(() => ResetEvents.Method(1)).Start();
//new Thread(() => ResetEvents.Method(2)).Start();
//new Thread(() => ResetEvents.Method(3)).Start();
//new Thread(() => ResetEvents.Method(4)).Start();

//for (int i = 0; i < 4; i++)
//{
//    ResetEvents.a.Set();
//    Thread.Sleep(1000);
//}

//new Thread(() => BarrierClass.CounterWithBearer()).Start();
//new Thread(() => BarrierClass.CounterWithBearer()).Start();
//new Thread(() => BarrierClass.CounterWithBearer()).Start();

var plinq = new PLINQTraining(9999999);

plinq.CheckingWordParallel();
plinq.CheckingWord();