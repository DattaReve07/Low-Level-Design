// See https://aka.ms/new-console-template for more information

using Singleton;

Console.WriteLine("=============== Singleton design pattern ============================");


var eagerLoadedDbConnection = EagerDbConnection.GetDbInstance();
var lazyLoadedDbConnection = LazyDbConnection.GetDbInstance();
var singleLockDbConnection = SingleLockDbConnection.GetDbInstance();
var doubleLockDbConnection = DoubleLockDbConnection.GetDbInstance();