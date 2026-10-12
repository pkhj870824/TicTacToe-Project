using System;
using System.Threading;
using TicTacToe_pg;

GameBoard gameBoard = new GameBoard();
char player = 'X';
int count = 0;
gameBoard.StartBoard();

while (true)
{
Console.Clear();
Console.WriteLine("=== 틱택토 게임 · 1 단계 ===");
Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
Console.WriteLine("");
Console.WriteLine("위치 번호:");
gameBoard.PrintLocation();
Console.WriteLine("");
Console.WriteLine("현재 보드:");
gameBoard.PrintBoard();
Console.WriteLine("");
Console.WriteLine($"플레이어 {player}의 차례입니다.");
Console.Write("위치를 선택하세요 (1~9): ");

    bool isSelect = int.TryParse(Console.ReadLine(), out int select);

    if (isSelect == false)
    {
        Console.WriteLine("숫자를 입력해주세요");
        Thread.Sleep(1500);
        continue;
    }
    else if (select < 1 || select > 9)
    {
        Console.WriteLine("범위를 벗어난 입력입니다");
        Thread.Sleep(1500);
        continue;
    }

    bool success = gameBoard.SelectLocation(select, player);

    if(success == false)
    {
        Console.WriteLine("중복된 값입니다");
        Thread.Sleep(1500);
        continue;
    }

    bool win = gameBoard.CheckWin(player);
    if (win)
    {
        Console.Clear();
        Console.WriteLine("=== 틱택토 게임 · 1 단계 ===");
        Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
        Console.WriteLine("");
        Console.WriteLine("위치 번호:");
        gameBoard.PrintLocation();
        Console.WriteLine("");
        Console.WriteLine("현재 보드:");
        gameBoard.PrintBoard();
        Console.WriteLine("");
        Console.WriteLine($"플레이어 {player}승리!");
        break;
    }

    if (player == 'X')
    {
        player = 'O';
        count++;
    }
    else if (player == 'O')
    {
        player = 'X';
        count++;
    }

    if (count == 9)
    {
        Console.Clear();
        Console.WriteLine("=== 틱택토 게임 · 1 단계 ===");
        Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
        Console.WriteLine("");
        Console.WriteLine("위치 번호:");
        gameBoard.PrintLocation();
        Console.WriteLine("");
        Console.WriteLine("현재 보드:");
        gameBoard.PrintBoard();
        Console.WriteLine("");
        Console.WriteLine($"비겼습니다!");
        break;
    }
}


