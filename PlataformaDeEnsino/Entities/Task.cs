using PlataformaDeEnsino.Entities;

namespace PlataformaDeEnsino.Entities
{
    internal class TasK : Lesson
    {
        public string Description { get; set; }
        public int QuestionCount { get; set; }

        public TasK(string title, string description, int questionCount) : base(title) 
        {
            Description = description;
            QuestionCount = questionCount;
        }

        public override int Duration()
        {
            return QuestionCount * 5 * 60; 
        }
    }
}
