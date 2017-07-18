using ChookBook.Domain;

namespace ChookBook.Repository
{
    public interface INotesRepository
    {
        void CreateNote(Note note);
    }
}