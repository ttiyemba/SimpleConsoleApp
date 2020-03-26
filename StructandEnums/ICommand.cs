namespace StructandEnums
{
    interface ICommand
    {
        void Execute();
        void Undo(); 
    }
}