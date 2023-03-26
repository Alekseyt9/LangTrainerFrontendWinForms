

namespace LangTrainerFrontendWinForms.Model
{
    internal class BadRequestException : Exception
    {
        public BadRequestException() { }
        public BadRequestException(string msg) : base(msg)
        { }
    }
}
