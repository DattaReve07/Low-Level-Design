// See https://aka.ms/new-console-template for more information

using TicTacToe;

Console.WriteLine("Lets play Tic Tac Toe!");

var game = new TicTacToeGame();

var status = game.startGame();

Console.WriteLine(
    status == GameStatus.WIN ?
        $"Congratulations {game.winner!.Name}, you win!"
        : "It's a draw!");