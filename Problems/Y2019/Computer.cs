namespace Problems.Y2019;

enum Opcode
{
    Add = 1,
    Multiply = 2,
    Halt = 99
}
class Computer
{
    private int[] _program = new int[0];
    private int _programPointer = 0;
    private bool _halt = false;

    private int _regA = 0;

    public Computer()
    {
    }

    private void Init(string program)
    {
        _programPointer = 0;
        _halt = false;
        _program = program.Replace("\n", "").Split(",").Select(int.Parse).ToArray();
    }

    public int Run(string program, int? noun = null, int? verb = null)
    {
        Init(program);

        if (noun != null) { _program[1] = (int)noun; }
        if (verb != null) { _program[2] = (int)verb; }

        while (!_halt)
        {
            switch ((Opcode)_program[_programPointer])
            {
                case Opcode.Halt:
                    Halt(); break;
                case Opcode.Add:
                    Add() ; break;
                case Opcode.Multiply:
                    Multiply(); break;
            }
        }
        return _regA;
    }

    private void Halt()
    {
        _halt = true;
    }

    private int Inspect(int address)
    {
        return _program[address];
    }

    private void Write(int value, int address)
    {
        _program[address] = value;
    }

    private void Add()
    {
        int a = Inspect(_program[_programPointer + 1]);
        int b = Inspect(_program[_programPointer + 2]);
        _regA = a + b;
        Write(_regA, _program[_programPointer + 3]);
        _programPointer += 4;
    }

    private void Multiply()
    {
        int a = Inspect(_program[_programPointer + 1]);
        int b = Inspect(_program[_programPointer + 2]);
        _regA = a * b;
        Write(_regA, _program[_programPointer + 3]);
        _programPointer += 4;
    }
}